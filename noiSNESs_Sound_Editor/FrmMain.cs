using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using noiSNESs_SoundLib;

namespace noiSNESs_Sound_Editor
{
    public partial class FrmMain : Form
    {
        private byte[] _rom    = new byte[] { };
        private byte[] _sample = new byte[] { };
        private bool _sampleIsWav = false;
        private Dictionary<int, int> _brrsInRom = new Dictionary<int, int>();

        public FrmMain()
        {
            InitializeComponent();

            cmbInterpolationType.SelectedIndex = 4;
            btnPlayAsBrr.Enabled = false;
            resetAppStatus();
        }

        private void resetAppStatus()
        {
            btnFindBrrs.Enabled = false;
            btnPlayBrr.Enabled = false;
            btnExportSample.Enabled = false;
            btnExportAllSamples.Enabled = false;
            btnSaveFile.Enabled = false;
            cmbSampleToEdit.DataSource = null;
            labFileName.Text = "-";

            _brrsInRom.Clear();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            string shortFileName = string.Empty;
            bool fileOpened = Helper.fileDialogHelper(true,
                "Snes rom files(*.SMC;*.SFC;*.BIN)|*.SMC;*.SFC;*.BIN|SPC files (*.SPC)|*.SPC|All files (*.*)|*.*",
                "Choose a file",
                (string fileName) =>
                {
                    try
                    {
                        _rom = File.ReadAllBytes(fileName);
                        shortFileName = Path.GetFileName(fileName);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                });

            resetAppStatus();
            if (fileOpened)
            {
                labFileName.Text = shortFileName;
                btnFindBrrs.Enabled = true;
                btnSaveFile.Enabled = true;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (_rom == null || _rom.Length <= 0)
                return;

            bool fileOpened = Helper.fileDialogHelper(false,
                "Snes rom files(*.SMC;*.SFC;*.BIN)|*.SMC;*.SFC;*.BIN|SPC files (*.SPC)|*.SPC|All files (*.*)|*.*",
                "Choose a file",
            (string fileName) => {
                File.WriteAllBytes(fileName, _rom);
                return true;
            });
        }

        private void btnFindBrrs_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                int minimumSize = Convert.ToInt32(nudMinBrrSize.Value);
                int minimumStdDeviation = Convert.ToInt32(nudMinStdDeviation.Value);
                int maximumStdDeviation = Convert.ToInt32(nudMaxStdDeviation.Value);
                int maximumModePercentage = Convert.ToInt32(nudMinModePercentage.Value);

                _brrsInRom = Business.findBrrs(_rom,
                    minimumSize, minimumStdDeviation, maximumStdDeviation, maximumModePercentage);

                cmbSampleToEdit.DataSource = null;
                if (_brrsInRom.Count < 1) return;

                Dictionary<int, string> selectorDataSource = new Dictionary<int, string>();
                foreach (var item in _brrsInRom.OrderBy(_ => _.Key))
                    selectorDataSource.Add(item.Key, item.Key.ToString("X6") + " " + item.Value + " bytes");

                cmbSampleToEdit.DisplayMember = "Value";
                cmbSampleToEdit.ValueMember = "Key";
                cmbSampleToEdit.DataSource = new BindingSource(selectorDataSource, null);
                cmbSampleToEdit.SelectedIndex = 0;

                btnPlayBrr.Enabled = true;
                btnExportSample.Enabled = true;
                btnExportAllSamples.Enabled = true;
            }
            catch
            {
                cmbSampleToEdit.DataSource = null;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnPlayBrr_Click(object sender, EventArgs e)
        {
            try
            {
                int addressOfSample = (int)cmbSampleToEdit.SelectedValue;
                int lengthOfSample = _brrsInRom[addressOfSample];
                byte[] brrToPlay = _rom.Skip(addressOfSample).Take(lengthOfSample).ToArray();

                uint sampleRate = Convert.ToUInt32(nudSampleRate.Value);

                Brr.playBrr(brrToPlay, sampleRate, chbGaussian.Checked);

                if (chbAutoNext.Checked)
                    cmbSampleToEdit.SelectedIndex = cmbSampleToEdit.SelectedIndex + 1;
            }
            catch { }
        }

        private void btnExportSample_Click(object sender, EventArgs e)
        {
            try
            {
                int addressOfSample = (int)cmbSampleToEdit.SelectedValue;
                int lengthOfSample = _brrsInRom[addressOfSample];
                uint samplerate = Convert.ToUInt32(nudSampleRate.Value);
                byte[] brrToExport = _rom.Skip(addressOfSample).Take(lengthOfSample).ToArray();

                string stdFileName = addressOfSample.ToString("X6") + "_" + lengthOfSample + "_" + samplerate;

                bool fileOpened = Helper.fileDialogHelper(false, "Waveform files(*.WAV)|*.wav|BRR SNES file(*.BRR)|*.brr", "Choose the type and the output file",
                (string fileName) =>
                {
                    if(Path.GetExtension(fileName).ToLower() == ".brr")
                        File.WriteAllBytes(fileName, brrToExport);
                    else
                    {
                        bool loopedRef = false;
                        byte[] wav = Brr.decodeBRRToWav(brrToExport, ref loopedRef, true, chbGaussian.Checked, 16, 1, samplerate);

                        File.WriteAllBytes(fileName, wav);
                    }
                    return true;
                }, stdFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportAllSamples_Click(object sender, EventArgs e)
        {
            try
            {
                int addressOfSampleZero = ((KeyValuePair<int, string>)cmbSampleToEdit.Items[0]).Key;
                int lengthOfSampleZero = _brrsInRom[addressOfSampleZero];
                uint samplerate = Convert.ToUInt32(nudSampleRate.Value);

                string stdFileName = addressOfSampleZero.ToString("X6") + "_" + lengthOfSampleZero + "_" + samplerate;

                bool fileOpened = Helper.fileDialogHelper(false, "BRR SNES file(*.BRR)|*.brr", "Choose the type and the output file",
                (string firstFileName) =>
                {
                    string dir = Path.GetDirectoryName(firstFileName);

                    foreach (var item in cmbSampleToEdit.Items)
                    {
                        int addressOfSample = ((KeyValuePair<int, string>)item).Key;
                        int lengthOfSample = _brrsInRom[addressOfSample];
                        byte[] brrToExport = _rom.Skip(addressOfSample).Take(lengthOfSample).ToArray();
                        string fileName = addressOfSample.ToString("X6") + "_" + lengthOfSample + "_" + samplerate;

                        File.WriteAllBytes(dir + Path.DirectorySeparatorChar + fileName + ".brr", brrToExport);
                    }

                    return true;
                }, stdFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadWav_Click(object sender, EventArgs e)
        {
            string shortFileName = string.Empty;
            bool fileOpened = Helper.fileDialogHelper(true,
                "Waveform files(*.WAV)|*.wav|BRR SNES file(*.BRR)|*.brr",
                "Choose a sound file",
                (string fileName) =>
                {
                    try
                    {
                        _sampleIsWav = Path.GetExtension(fileName).ToLower() != ".brr";
                        _sample = File.ReadAllBytes(fileName);
                        shortFileName = Path.GetFileName(fileName);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                });

            if (fileOpened)
            {
                labWavName.Text = shortFileName;
                btnPlayAsBrr.Enabled = true;
            }                
        }

        private void btnPlayAsBrr_Click(object sender, EventArgs e)
        {
            //First, encode wav as BRR is needed
            UInt16 targetSamplerate = Convert.ToUInt16(nudSampleRate.Value);
            byte[] brr = encodeInputSampleAsBrr(targetSamplerate);
            if (brr.Length <= 0)
                return;

            //Second, decode the temporal created BRR to be played as a WAV
            bool loopedRef = false;
            byte[] wav = Brr.decodeBRRToWav(brr, ref loopedRef, true, true, 16, 1, targetSamplerate);
            using (MemoryStream msw = new MemoryStream(wav))
            {
                using (System.Media.SoundPlayer sp = new System.Media.SoundPlayer(msw))
                {
                    sp.Play();
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //First, encode wav as BRR
            byte[] brr = encodeInputSampleAsBrr(Convert.ToUInt16(nudSampleRate.Value));
            if (brr.Length <= 0)
                return;

            //Second, inject the BRR inside the ROM
            int addressOfSample = (int)cmbSampleToEdit.SelectedValue;
            int lengthOfSample = _brrsInRom[addressOfSample];

            for (int i = 0; i < lengthOfSample; i++)
                _rom[addressOfSample + i] = brr[i];
        }

        #region Helper

        private BrrEncoderOptions buildBrrEncoderOptions(UInt16 targetSamplerate, UInt16 truncateLen)
        {
            bool fixLoopEn    = false;
            bool trebleBoost  = chbTrebleBoost.Checked;
            char resampleType = cmbInterpolationType.Text.ToLower()[0];

            return new BrrEncoderOptions()
            {
                fixLoopEn = fixLoopEn,      // True if fixed loop is activated
                truncateLen = truncateLen,  // Point at which input wave will be truncated (if = 0, input wave is not truncated)
                trebleBoost = trebleBoost,  // True to boost the treble in the output BRR
                wrapEn = true,              // Enable wrapping (encoded sample would not be compatible with old SPC players)
                targetSamplerate = targetSamplerate,
                resampleType = resampleType // Resampling type (n = nearest neighboor, l = linear, c = cubic, s = sine, b = bandlimited)
            };
        }

        private byte[] encodeInputSampleAsBrr(UInt16 targetSamplerate)
        {
            if(_sample == null || _sample.Length == 0)
                return new byte[] { };

            int addressOfSample = (int)cmbSampleToEdit.SelectedValue;
            int lengthOfSample = _brrsInRom[addressOfSample];

            //If the sample is already a BRR, truncate it if needed and return
            if (!_sampleIsWav)
                return Brr.truncateBRR(_sample, lengthOfSample);

            Int16[] wavSampleData;
            var hdr = Brr.openWavFile(_sample, out wavSampleData);
            if (!hdr.validHeader)
            {
                MessageBox.Show(hdr.invalidHeaderMessage);
                return new byte[] { };
            }

            BrrEncoderOptions brrEncoderOptions = buildBrrEncoderOptions(
                targetSamplerate,
                Convert.ToUInt16((lengthOfSample / 9) * 16));
            return Brr.encodeBrr(hdr, wavSampleData, brrEncoderOptions);
        }

        #endregion
    }
}
