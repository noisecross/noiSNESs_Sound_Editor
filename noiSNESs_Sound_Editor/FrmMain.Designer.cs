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
            this.chbGaussian = new System.Windows.Forms.CheckBox();
            this.btnExportSample = new System.Windows.Forms.Button();
            this.btnPlayBrr = new System.Windows.Forms.Button();
            this.cmbSampleToEdit = new System.Windows.Forms.ComboBox();
            this.lab09 = new System.Windows.Forms.Label();
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
            this.grbFile.Location = new System.Drawing.Point(12, 12);
            this.grbFile.Name = "grbFile";
            this.grbFile.Size = new System.Drawing.Size(308, 126);
            this.grbFile.TabIndex = 0;
            this.grbFile.TabStop = false;
            this.grbFile.Text = "File";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(227, 19);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save file";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // labFileName
            // 
            this.labFileName.AutoSize = true;
            this.labFileName.Location = new System.Drawing.Point(67, 53);
            this.labFileName.Name = "labFileName";
            this.labFileName.Size = new System.Drawing.Size(10, 13);
            this.labFileName.TabIndex = 3;
            this.labFileName.Text = "-";
            // 
            // lab01
            // 
            this.lab01.AutoSize = true;
            this.lab01.Location = new System.Drawing.Point(6, 53);
            this.lab01.Name = "lab01";
            this.lab01.Size = new System.Drawing.Size(55, 13);
            this.lab01.TabIndex = 2;
            this.lab01.Text = "File name:";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(6, 19);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
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
            this.grbSoundFinder.Location = new System.Drawing.Point(326, 12);
            this.grbSoundFinder.Name = "grbSoundFinder";
            this.grbSoundFinder.Size = new System.Drawing.Size(308, 126);
            this.grbSoundFinder.TabIndex = 1;
            this.grbSoundFinder.TabStop = false;
            this.grbSoundFinder.Text = "Sound finder";
            // 
            // lab04
            // 
            this.lab04.AutoSize = true;
            this.lab04.Location = new System.Drawing.Point(101, 76);
            this.lab04.Name = "lab04";
            this.lab04.Size = new System.Drawing.Size(117, 13);
            this.lab04.TabIndex = 8;
            this.lab04.Text = "Max standard deviation";
            // 
            // lab03
            // 
            this.lab03.AutoSize = true;
            this.lab03.Location = new System.Drawing.Point(104, 50);
            this.lab03.Name = "lab03";
            this.lab03.Size = new System.Drawing.Size(114, 13);
            this.lab03.TabIndex = 7;
            this.lab03.Text = "Min standard deviation";
            // 
            // lab05
            // 
            this.lab05.AutoSize = true;
            this.lab05.Location = new System.Drawing.Point(108, 102);
            this.lab05.Name = "lab05";
            this.lab05.Size = new System.Drawing.Size(110, 13);
            this.lab05.TabIndex = 6;
            this.lab05.Text = "Min mode percentage";
            // 
            // lab02
            // 
            this.lab02.AutoSize = true;
            this.lab02.Location = new System.Drawing.Point(147, 24);
            this.lab02.Name = "lab02";
            this.lab02.Size = new System.Drawing.Size(71, 13);
            this.lab02.TabIndex = 4;
            this.lab02.Text = "Min BRR size";
            // 
            // nudMinModePercentage
            // 
            this.nudMinModePercentage.Location = new System.Drawing.Point(224, 100);
            this.nudMinModePercentage.Name = "nudMinModePercentage";
            this.nudMinModePercentage.Size = new System.Drawing.Size(78, 20);
            this.nudMinModePercentage.TabIndex = 5;
            this.nudMinModePercentage.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudMaxStdDeviation
            // 
            this.nudMaxStdDeviation.Location = new System.Drawing.Point(224, 74);
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
            this.nudMaxStdDeviation.Size = new System.Drawing.Size(78, 20);
            this.nudMaxStdDeviation.TabIndex = 4;
            this.nudMaxStdDeviation.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMinStdDeviation
            // 
            this.nudMinStdDeviation.Location = new System.Drawing.Point(224, 48);
            this.nudMinStdDeviation.Name = "nudMinStdDeviation";
            this.nudMinStdDeviation.Size = new System.Drawing.Size(78, 20);
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
            this.nudMinBrrSize.Location = new System.Drawing.Point(224, 22);
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
            this.nudMinBrrSize.Size = new System.Drawing.Size(78, 20);
            this.nudMinBrrSize.TabIndex = 2;
            this.nudMinBrrSize.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            // 
            // btnFindBrrs
            // 
            this.btnFindBrrs.Location = new System.Drawing.Point(6, 19);
            this.btnFindBrrs.Name = "btnFindBrrs";
            this.btnFindBrrs.Size = new System.Drawing.Size(75, 23);
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
            this.grbSoundManager.Location = new System.Drawing.Point(325, 143);
            this.grbSoundManager.Margin = new System.Windows.Forms.Padding(2);
            this.grbSoundManager.Name = "grbSoundManager";
            this.grbSoundManager.Padding = new System.Windows.Forms.Padding(2);
            this.grbSoundManager.Size = new System.Drawing.Size(309, 128);
            this.grbSoundManager.TabIndex = 11;
            this.grbSoundManager.TabStop = false;
            this.grbSoundManager.Text = "Sound Importer";
            // 
            // lab08
            // 
            this.lab08.AutoSize = true;
            this.lab08.Location = new System.Drawing.Point(5, 77);
            this.lab08.Name = "lab08";
            this.lab08.Size = new System.Drawing.Size(94, 13);
            this.lab08.TabIndex = 18;
            this.lab08.Text = "Interpolation mode";
            // 
            // btnLoadWav
            // 
            this.btnLoadWav.Location = new System.Drawing.Point(5, 18);
            this.btnLoadWav.Name = "btnLoadWav";
            this.btnLoadWav.Size = new System.Drawing.Size(75, 23);
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
            this.chbTrebleBoost.Location = new System.Drawing.Point(105, 104);
            this.chbTrebleBoost.Margin = new System.Windows.Forms.Padding(2);
            this.chbTrebleBoost.Name = "chbTrebleBoost";
            this.chbTrebleBoost.Size = new System.Drawing.Size(85, 17);
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
            this.cmbInterpolationType.Location = new System.Drawing.Point(104, 74);
            this.cmbInterpolationType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbInterpolationType.Name = "cmbInterpolationType";
            this.cmbInterpolationType.Size = new System.Drawing.Size(199, 21);
            this.cmbInterpolationType.TabIndex = 12;
            // 
            // lab06
            // 
            this.lab06.AutoSize = true;
            this.lab06.Location = new System.Drawing.Point(5, 51);
            this.lab06.Name = "lab06";
            this.lab06.Size = new System.Drawing.Size(74, 13);
            this.lab06.TabIndex = 10;
            this.lab06.Text = "Sample name:";
            // 
            // labWavName
            // 
            this.labWavName.AutoSize = true;
            this.labWavName.Location = new System.Drawing.Point(85, 51);
            this.labWavName.Name = "labWavName";
            this.labWavName.Size = new System.Drawing.Size(10, 13);
            this.labWavName.TabIndex = 11;
            this.labWavName.Text = "-";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(228, 100);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPlayAsBrr
            // 
            this.btnPlayAsBrr.Enabled = false;
            this.btnPlayAsBrr.Location = new System.Drawing.Point(228, 18);
            this.btnPlayAsBrr.Name = "btnPlayAsBrr";
            this.btnPlayAsBrr.Size = new System.Drawing.Size(75, 23);
            this.btnPlayAsBrr.TabIndex = 8;
            this.btnPlayAsBrr.Text = "Play as BRR";
            this.btnPlayAsBrr.UseVisualStyleBackColor = true;
            this.btnPlayAsBrr.Click += new System.EventHandler(this.btnPlayAsBrr_Click);
            // 
            // lab07
            // 
            this.lab07.AutoSize = true;
            this.lab07.Location = new System.Drawing.Point(17, 49);
            this.lab07.Name = "lab07";
            this.lab07.Size = new System.Drawing.Size(60, 13);
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
            this.nudSampleRate.Location = new System.Drawing.Point(85, 47);
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
            this.nudSampleRate.Size = new System.Drawing.Size(78, 20);
            this.nudSampleRate.TabIndex = 16;
            this.nudSampleRate.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // grbBRRSelector
            // 
            this.grbBRRSelector.Controls.Add(this.chbGaussian);
            this.grbBRRSelector.Controls.Add(this.btnExportSample);
            this.grbBRRSelector.Controls.Add(this.btnPlayBrr);
            this.grbBRRSelector.Controls.Add(this.cmbSampleToEdit);
            this.grbBRRSelector.Controls.Add(this.lab09);
            this.grbBRRSelector.Controls.Add(this.nudSampleRate);
            this.grbBRRSelector.Controls.Add(this.lab07);
            this.grbBRRSelector.Location = new System.Drawing.Point(12, 143);
            this.grbBRRSelector.Name = "grbBRRSelector";
            this.grbBRRSelector.Size = new System.Drawing.Size(308, 128);
            this.grbBRRSelector.TabIndex = 4;
            this.grbBRRSelector.TabStop = false;
            this.grbBRRSelector.Text = "BRR Selector";
            // 
            // chbGaussian
            // 
            this.chbGaussian.AutoSize = true;
            this.chbGaussian.Checked = true;
            this.chbGaussian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGaussian.Location = new System.Drawing.Point(85, 104);
            this.chbGaussian.Margin = new System.Windows.Forms.Padding(2);
            this.chbGaussian.Name = "chbGaussian";
            this.chbGaussian.Size = new System.Drawing.Size(92, 17);
            this.chbGaussian.TabIndex = 23;
            this.chbGaussian.Text = "Gaussian filter";
            this.chbGaussian.UseVisualStyleBackColor = true;
            // 
            // btnExportSample
            // 
            this.btnExportSample.Enabled = false;
            this.btnExportSample.Location = new System.Drawing.Point(227, 100);
            this.btnExportSample.Name = "btnExportSample";
            this.btnExportSample.Size = new System.Drawing.Size(75, 23);
            this.btnExportSample.TabIndex = 22;
            this.btnExportSample.Text = "Export";
            this.btnExportSample.UseVisualStyleBackColor = true;
            this.btnExportSample.Click += new System.EventHandler(this.btnExportSample_Click);
            // 
            // btnPlayBrr
            // 
            this.btnPlayBrr.Enabled = false;
            this.btnPlayBrr.Location = new System.Drawing.Point(227, 44);
            this.btnPlayBrr.Name = "btnPlayBrr";
            this.btnPlayBrr.Size = new System.Drawing.Size(75, 23);
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
            this.cmbSampleToEdit.Location = new System.Drawing.Point(85, 18);
            this.cmbSampleToEdit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSampleToEdit.Name = "cmbSampleToEdit";
            this.cmbSampleToEdit.Size = new System.Drawing.Size(218, 21);
            this.cmbSampleToEdit.TabIndex = 20;
            // 
            // lab09
            // 
            this.lab09.AutoSize = true;
            this.lab09.Location = new System.Drawing.Point(6, 23);
            this.lab09.Name = "lab09";
            this.lab09.Size = new System.Drawing.Size(74, 13);
            this.lab09.TabIndex = 19;
            this.lab09.Text = "Sample to edit";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 282);
            this.Controls.Add(this.grbBRRSelector);
            this.Controls.Add(this.grbSoundManager);
            this.Controls.Add(this.grbSoundFinder);
            this.Controls.Add(this.grbFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

