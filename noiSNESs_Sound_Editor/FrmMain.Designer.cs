namespace noiSNESs_Sound_Editor
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.grbFile = new System.Windows.Forms.GroupBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.labFileName = new System.Windows.Forms.Label();
            this.lab01 = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.grbSoundFinder = new System.Windows.Forms.GroupBox();
            this.lab04 = new System.Windows.Forms.Label();
            this.lab03 = new System.Windows.Forms.Label();
            this.lab05 = new System.Windows.Forms.Label();
            this.lab02 = new System.Windows.Forms.Label();
            this.nudMinModePercentage = new System.Windows.Forms.NumericUpDown();
            this.nudMaxStdDeviation = new System.Windows.Forms.NumericUpDown();
            this.nudMinStdDeviation = new System.Windows.Forms.NumericUpDown();
            this.nudMinBrrSize = new System.Windows.Forms.NumericUpDown();
            this.btnFindBrrs = new System.Windows.Forms.Button();
            this.grbSoundManager = new System.Windows.Forms.GroupBox();
            this.lab08 = new System.Windows.Forms.Label();
            this.btnLoadWav = new System.Windows.Forms.Button();
            this.chbTrebleBoost = new System.Windows.Forms.CheckBox();
            this.cmbInterpolationType = new System.Windows.Forms.ComboBox();
            this.lab06 = new System.Windows.Forms.Label();
            this.labWavName = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnPlayAsBrr = new System.Windows.Forms.Button();
            this.lab07 = new System.Windows.Forms.Label();
            this.nudSampleRate = new System.Windows.Forms.NumericUpDown();
            this.grbBRRSelector = new System.Windows.Forms.GroupBox();
            this.chbAutoNext = new System.Windows.Forms.CheckBox();
            this.chbGaussian = new System.Windows.Forms.CheckBox();
            this.btnExportSample = new System.Windows.Forms.Button();
            this.btnPlayBrr = new System.Windows.Forms.Button();
            this.cmbSampleToEdit = new System.Windows.Forms.ComboBox();
            this.lab09 = new System.Windows.Forms.Label();
            this.btnExportAllSamples = new System.Windows.Forms.Button();
            this.grbFile.SuspendLayout();
            this.grbSoundFinder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinModePercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStdDeviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinStdDeviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinBrrSize)).BeginInit();
            this.grbSoundManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleRate)).BeginInit();
            this.grbBRRSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFile
            // 
            this.grbFile.Controls.Add(this.btnSaveFile);
            this.grbFile.Controls.Add(this.labFileName);
            this.grbFile.Controls.Add(this.lab01);
            this.grbFile.Controls.Add(this.btnLoadFile);
            this.grbFile.Location = new System.Drawing.Point(24, 23);
            this.grbFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbFile.Name = "grbFile";
            this.grbFile.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbFile.Size = new System.Drawing.Size(616, 242);
            this.grbFile.TabIndex = 0;
            this.grbFile.TabStop = false;
            this.grbFile.Text = "File";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(454, 37);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(150, 44);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save file";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // labFileName
            // 
            this.labFileName.AutoSize = true;
            this.labFileName.Location = new System.Drawing.Point(134, 102);
            this.labFileName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFileName.Name = "labFileName";
            this.labFileName.Size = new System.Drawing.Size(19, 25);
            this.labFileName.TabIndex = 3;
            this.labFileName.Text = "-";
            // 
            // lab01
            // 
            this.lab01.AutoSize = true;
            this.lab01.Location = new System.Drawing.Point(12, 102);
            this.lab01.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab01.Name = "lab01";
            this.lab01.Size = new System.Drawing.Size(112, 25);
            this.lab01.TabIndex = 2;
            this.lab01.Text = "File name:";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 37);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(150, 44);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load file";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // grbSoundFinder
            // 
            this.grbSoundFinder.Controls.Add(this.lab04);
            this.grbSoundFinder.Controls.Add(this.lab03);
            this.grbSoundFinder.Controls.Add(this.lab05);
            this.grbSoundFinder.Controls.Add(this.lab02);
            this.grbSoundFinder.Controls.Add(this.nudMinModePercentage);
            this.grbSoundFinder.Controls.Add(this.nudMaxStdDeviation);
            this.grbSoundFinder.Controls.Add(this.nudMinStdDeviation);
            this.grbSoundFinder.Controls.Add(this.nudMinBrrSize);
            this.grbSoundFinder.Controls.Add(this.btnFindBrrs);
            this.grbSoundFinder.Location = new System.Drawing.Point(652, 23);
            this.grbSoundFinder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbSoundFinder.Name = "grbSoundFinder";
            this.grbSoundFinder.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbSoundFinder.Size = new System.Drawing.Size(616, 242);
            this.grbSoundFinder.TabIndex = 1;
            this.grbSoundFinder.TabStop = false;
            this.grbSoundFinder.Text = "Sound finder";
            // 
            // lab04
            // 
            this.lab04.AutoSize = true;
            this.lab04.Location = new System.Drawing.Point(202, 146);
            this.lab04.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab04.Name = "lab04";
            this.lab04.Size = new System.Drawing.Size(236, 25);
            this.lab04.TabIndex = 8;
            this.lab04.Text = "Max standard deviation";
            // 
            // lab03
            // 
            this.lab03.AutoSize = true;
            this.lab03.Location = new System.Drawing.Point(208, 96);
            this.lab03.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab03.Name = "lab03";
            this.lab03.Size = new System.Drawing.Size(230, 25);
            this.lab03.TabIndex = 7;
            this.lab03.Text = "Min standard deviation";
            // 
            // lab05
            // 
            this.lab05.AutoSize = true;
            this.lab05.Location = new System.Drawing.Point(216, 196);
            this.lab05.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab05.Name = "lab05";
            this.lab05.Size = new System.Drawing.Size(220, 25);
            this.lab05.TabIndex = 6;
            this.lab05.Text = "Min mode percentage";
            // 
            // lab02
            // 
            this.lab02.AutoSize = true;
            this.lab02.Location = new System.Drawing.Point(294, 46);
            this.lab02.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab02.Name = "lab02";
            this.lab02.Size = new System.Drawing.Size(142, 25);
            this.lab02.TabIndex = 4;
            this.lab02.Text = "Min BRR size";
            // 
            // nudMinModePercentage
            // 
            this.nudMinModePercentage.Location = new System.Drawing.Point(448, 192);
            this.nudMinModePercentage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudMinModePercentage.Name = "nudMinModePercentage";
            this.nudMinModePercentage.Size = new System.Drawing.Size(156, 31);
            this.nudMinModePercentage.TabIndex = 5;
            this.nudMinModePercentage.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudMaxStdDeviation
            // 
            this.nudMaxStdDeviation.Location = new System.Drawing.Point(448, 142);
            this.nudMaxStdDeviation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudMaxStdDeviation.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudMaxStdDeviation.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudMaxStdDeviation.Name = "nudMaxStdDeviation";
            this.nudMaxStdDeviation.Size = new System.Drawing.Size(156, 31);
            this.nudMaxStdDeviation.TabIndex = 4;
            this.nudMaxStdDeviation.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMinStdDeviation
            // 
            this.nudMinStdDeviation.Location = new System.Drawing.Point(448, 92);
            this.nudMinStdDeviation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudMinStdDeviation.Name = "nudMinStdDeviation";
            this.nudMinStdDeviation.Size = new System.Drawing.Size(156, 31);
            this.nudMinStdDeviation.TabIndex = 3;
            this.nudMinStdDeviation.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // nudMinBrrSize
            // 
            this.nudMinBrrSize.Increment = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudMinBrrSize.Location = new System.Drawing.Point(448, 42);
            this.nudMinBrrSize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudMinBrrSize.Maximum = new decimal(new int[] {
            63000,
            0,
            0,
            0});
            this.nudMinBrrSize.Minimum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nudMinBrrSize.Name = "nudMinBrrSize";
            this.nudMinBrrSize.Size = new System.Drawing.Size(156, 31);
            this.nudMinBrrSize.TabIndex = 2;
            this.nudMinBrrSize.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            // 
            // btnFindBrrs
            // 
            this.btnFindBrrs.Location = new System.Drawing.Point(12, 37);
            this.btnFindBrrs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFindBrrs.Name = "btnFindBrrs";
            this.btnFindBrrs.Size = new System.Drawing.Size(150, 44);
            this.btnFindBrrs.TabIndex = 1;
            this.btnFindBrrs.Text = "Find BRRs";
            this.btnFindBrrs.UseVisualStyleBackColor = true;
            this.btnFindBrrs.Click += new System.EventHandler(this.btnFindBrrs_Click);
            // 
            // grbSoundManager
            // 
            this.grbSoundManager.Controls.Add(this.lab08);
            this.grbSoundManager.Controls.Add(this.btnLoadWav);
            this.grbSoundManager.Controls.Add(this.chbTrebleBoost);
            this.grbSoundManager.Controls.Add(this.cmbInterpolationType);
            this.grbSoundManager.Controls.Add(this.lab06);
            this.grbSoundManager.Controls.Add(this.labWavName);
            this.grbSoundManager.Controls.Add(this.btnImport);
            this.grbSoundManager.Controls.Add(this.btnPlayAsBrr);
            this.grbSoundManager.Location = new System.Drawing.Point(650, 275);
            this.grbSoundManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSoundManager.Name = "grbSoundManager";
            this.grbSoundManager.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSoundManager.Size = new System.Drawing.Size(618, 246);
            this.grbSoundManager.TabIndex = 11;
            this.grbSoundManager.TabStop = false;
            this.grbSoundManager.Text = "Sound Importer";
            // 
            // lab08
            // 
            this.lab08.AutoSize = true;
            this.lab08.Location = new System.Drawing.Point(10, 148);
            this.lab08.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab08.Name = "lab08";
            this.lab08.Size = new System.Drawing.Size(189, 25);
            this.lab08.TabIndex = 18;
            this.lab08.Text = "Interpolation mode";
            // 
            // btnLoadWav
            // 
            this.btnLoadWav.Location = new System.Drawing.Point(10, 35);
            this.btnLoadWav.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoadWav.Name = "btnLoadWav";
            this.btnLoadWav.Size = new System.Drawing.Size(150, 44);
            this.btnLoadWav.TabIndex = 15;
            this.btnLoadWav.Text = "Load sample";
            this.btnLoadWav.UseVisualStyleBackColor = true;
            this.btnLoadWav.Click += new System.EventHandler(this.btnLoadWav_Click);
            // 
            // chbTrebleBoost
            // 
            this.chbTrebleBoost.AutoSize = true;
            this.chbTrebleBoost.Checked = true;
            this.chbTrebleBoost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTrebleBoost.Location = new System.Drawing.Point(210, 200);
            this.chbTrebleBoost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbTrebleBoost.Name = "chbTrebleBoost";
            this.chbTrebleBoost.Size = new System.Drawing.Size(164, 29);
            this.chbTrebleBoost.TabIndex = 13;
            this.chbTrebleBoost.Text = "Treble boost";
            this.chbTrebleBoost.UseVisualStyleBackColor = true;
            // 
            // cmbInterpolationType
            // 
            this.cmbInterpolationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterpolationType.FormattingEnabled = true;
            this.cmbInterpolationType.Items.AddRange(new object[] {
            "Nearest neighboor",
            "Linear",
            "Cubic",
            "Sine",
            "Bandlimited"});
            this.cmbInterpolationType.Location = new System.Drawing.Point(208, 142);
            this.cmbInterpolationType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbInterpolationType.Name = "cmbInterpolationType";
            this.cmbInterpolationType.Size = new System.Drawing.Size(394, 33);
            this.cmbInterpolationType.TabIndex = 12;
            // 
            // lab06
            // 
            this.lab06.AutoSize = true;
            this.lab06.Location = new System.Drawing.Point(10, 98);
            this.lab06.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab06.Name = "lab06";
            this.lab06.Size = new System.Drawing.Size(149, 25);
            this.lab06.TabIndex = 10;
            this.lab06.Text = "Sample name:";
            // 
            // labWavName
            // 
            this.labWavName.AutoSize = true;
            this.labWavName.Location = new System.Drawing.Point(170, 98);
            this.labWavName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labWavName.Name = "labWavName";
            this.labWavName.Size = new System.Drawing.Size(19, 25);
            this.labWavName.TabIndex = 11;
            this.labWavName.Text = "-";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(456, 192);
            this.btnImport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(150, 44);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPlayAsBrr
            // 
            this.btnPlayAsBrr.Enabled = false;
            this.btnPlayAsBrr.Location = new System.Drawing.Point(456, 35);
            this.btnPlayAsBrr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPlayAsBrr.Name = "btnPlayAsBrr";
            this.btnPlayAsBrr.Size = new System.Drawing.Size(150, 44);
            this.btnPlayAsBrr.TabIndex = 8;
            this.btnPlayAsBrr.Text = "Play as BRR";
            this.btnPlayAsBrr.UseVisualStyleBackColor = true;
            this.btnPlayAsBrr.Click += new System.EventHandler(this.btnPlayAsBrr_Click);
            // 
            // lab07
            // 
            this.lab07.AutoSize = true;
            this.lab07.Location = new System.Drawing.Point(34, 94);
            this.lab07.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab07.Name = "lab07";
            this.lab07.Size = new System.Drawing.Size(121, 25);
            this.lab07.TabIndex = 17;
            this.lab07.Text = "Samplerate";
            // 
            // nudSampleRate
            // 
            this.nudSampleRate.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSampleRate.Location = new System.Drawing.Point(170, 90);
            this.nudSampleRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudSampleRate.Maximum = new decimal(new int[] {
            48000,
            0,
            0,
            0});
            this.nudSampleRate.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSampleRate.Name = "nudSampleRate";
            this.nudSampleRate.Size = new System.Drawing.Size(156, 31);
            this.nudSampleRate.TabIndex = 16;
            this.nudSampleRate.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // grbBRRSelector
            // 
            this.grbBRRSelector.Controls.Add(this.btnExportAllSamples);
            this.grbBRRSelector.Controls.Add(this.chbAutoNext);
            this.grbBRRSelector.Controls.Add(this.chbGaussian);
            this.grbBRRSelector.Controls.Add(this.btnExportSample);
            this.grbBRRSelector.Controls.Add(this.btnPlayBrr);
            this.grbBRRSelector.Controls.Add(this.cmbSampleToEdit);
            this.grbBRRSelector.Controls.Add(this.lab09);
            this.grbBRRSelector.Controls.Add(this.nudSampleRate);
            this.grbBRRSelector.Controls.Add(this.lab07);
            this.grbBRRSelector.Location = new System.Drawing.Point(24, 275);
            this.grbBRRSelector.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbBRRSelector.Name = "grbBRRSelector";
            this.grbBRRSelector.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbBRRSelector.Size = new System.Drawing.Size(616, 246);
            this.grbBRRSelector.TabIndex = 4;
            this.grbBRRSelector.TabStop = false;
            this.grbBRRSelector.Text = "BRR Selector";
            // 
            // chbAutoNext
            // 
            this.chbAutoNext.AutoSize = true;
            this.chbAutoNext.Checked = true;
            this.chbAutoNext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAutoNext.Location = new System.Drawing.Point(454, 146);
            this.chbAutoNext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chbAutoNext.Name = "chbAutoNext";
            this.chbAutoNext.Size = new System.Drawing.Size(135, 29);
            this.chbAutoNext.TabIndex = 24;
            this.chbAutoNext.Text = "Auto next";
            this.chbAutoNext.UseVisualStyleBackColor = true;
            // 
            // chbGaussian
            // 
            this.chbGaussian.AutoSize = true;
            this.chbGaussian.Checked = true;
            this.chbGaussian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGaussian.Location = new System.Drawing.Point(170, 146);
            this.chbGaussian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbGaussian.Name = "chbGaussian";
            this.chbGaussian.Size = new System.Drawing.Size(182, 29);
            this.chbGaussian.TabIndex = 23;
            this.chbGaussian.Text = "Gaussian filter";
            this.chbGaussian.UseVisualStyleBackColor = true;
            // 
            // btnExportSample
            // 
            this.btnExportSample.Enabled = false;
            this.btnExportSample.Location = new System.Drawing.Point(454, 190);
            this.btnExportSample.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExportSample.Name = "btnExportSample";
            this.btnExportSample.Size = new System.Drawing.Size(150, 44);
            this.btnExportSample.TabIndex = 22;
            this.btnExportSample.Text = "Export";
            this.btnExportSample.UseVisualStyleBackColor = true;
            this.btnExportSample.Click += new System.EventHandler(this.btnExportSample_Click);
            // 
            // btnPlayBrr
            // 
            this.btnPlayBrr.Enabled = false;
            this.btnPlayBrr.Location = new System.Drawing.Point(454, 85);
            this.btnPlayBrr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPlayBrr.Name = "btnPlayBrr";
            this.btnPlayBrr.Size = new System.Drawing.Size(150, 44);
            this.btnPlayBrr.TabIndex = 21;
            this.btnPlayBrr.Text = "Play";
            this.btnPlayBrr.UseVisualStyleBackColor = true;
            this.btnPlayBrr.Click += new System.EventHandler(this.btnPlayBrr_Click);
            // 
            // cmbSampleToEdit
            // 
            this.cmbSampleToEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSampleToEdit.FormattingEnabled = true;
            this.cmbSampleToEdit.Items.AddRange(new object[] {
            "Nearest neighboor",
            "Linear",
            "Cubic",
            "Sine",
            "Bandlimited"});
            this.cmbSampleToEdit.Location = new System.Drawing.Point(170, 35);
            this.cmbSampleToEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSampleToEdit.Name = "cmbSampleToEdit";
            this.cmbSampleToEdit.Size = new System.Drawing.Size(432, 33);
            this.cmbSampleToEdit.TabIndex = 20;
            // 
            // lab09
            // 
            this.lab09.AutoSize = true;
            this.lab09.Location = new System.Drawing.Point(12, 44);
            this.lab09.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab09.Name = "lab09";
            this.lab09.Size = new System.Drawing.Size(149, 25);
            this.lab09.TabIndex = 19;
            this.lab09.Text = "Sample to edit";
            // 
            // btnExportAllSamples
            // 
            this.btnExportAllSamples.Enabled = false;
            this.btnExportAllSamples.Location = new System.Drawing.Point(12, 190);
            this.btnExportAllSamples.Margin = new System.Windows.Forms.Padding(6);
            this.btnExportAllSamples.Name = "btnExportAllSamples";
            this.btnExportAllSamples.Size = new System.Drawing.Size(150, 44);
            this.btnExportAllSamples.TabIndex = 25;
            this.btnExportAllSamples.Text = "Export all";
            this.btnExportAllSamples.UseVisualStyleBackColor = true;
            this.btnExportAllSamples.Click += new System.EventHandler(this.btnExportAllSamples_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 542);
            this.Controls.Add(this.grbBRRSelector);
            this.Controls.Add(this.grbSoundManager);
            this.Controls.Add(this.grbSoundFinder);
            this.Controls.Add(this.grbFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "noiSNESs_Sound_Editor";
            this.grbFile.ResumeLayout(false);
            this.grbFile.PerformLayout();
            this.grbSoundFinder.ResumeLayout(false);
            this.grbSoundFinder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinModePercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStdDeviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinStdDeviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinBrrSize)).EndInit();
            this.grbSoundManager.ResumeLayout(false);
            this.grbSoundManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleRate)).EndInit();
            this.grbBRRSelector.ResumeLayout(false);
            this.grbBRRSelector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFile;
        private System.Windows.Forms.Label labFileName;
        private System.Windows.Forms.Label lab01;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.GroupBox grbSoundFinder;
        private System.Windows.Forms.Label lab04;
        private System.Windows.Forms.Label lab03;
        private System.Windows.Forms.Label lab05;
        private System.Windows.Forms.Label lab02;
        private System.Windows.Forms.NumericUpDown nudMinModePercentage;
        private System.Windows.Forms.NumericUpDown nudMaxStdDeviation;
        private System.Windows.Forms.NumericUpDown nudMinStdDeviation;
        private System.Windows.Forms.NumericUpDown nudMinBrrSize;
        private System.Windows.Forms.Button btnFindBrrs;
        private System.Windows.Forms.GroupBox grbSoundManager;
        private System.Windows.Forms.Label lab08;
        private System.Windows.Forms.Button btnLoadWav;
        private System.Windows.Forms.CheckBox chbTrebleBoost;
        private System.Windows.Forms.ComboBox cmbInterpolationType;
        private System.Windows.Forms.Label lab06;
        private System.Windows.Forms.Label labWavName;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnPlayAsBrr;
        private System.Windows.Forms.Label lab07;
        private System.Windows.Forms.NumericUpDown nudSampleRate;
        private System.Windows.Forms.GroupBox grbBRRSelector;
        private System.Windows.Forms.Button btnPlayBrr;
        private System.Windows.Forms.ComboBox cmbSampleToEdit;
        private System.Windows.Forms.Label lab09;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnExportSample;
        private System.Windows.Forms.CheckBox chbGaussian;
        private System.Windows.Forms.CheckBox chbAutoNext;
        private System.Windows.Forms.Button btnExportAllSamples;
    }
}

