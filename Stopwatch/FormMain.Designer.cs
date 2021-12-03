namespace Stopwatch
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonNewLocation = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.radioButtonDark = new System.Windows.Forms.RadioButton();
            this.radioButtonLight = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.checkBoxAdvanced = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.panelArea = new System.Windows.Forms.Panel();
            this.panelSavedLaps = new System.Windows.Forms.Panel();
            this.listBoxSavedMoments = new System.Windows.Forms.ListBox();
            this.labelRecords = new System.Windows.Forms.Label();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelSecond = new System.Windows.Forms.Panel();
            this.labelMillisecond = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.panelMinute = new System.Windows.Forms.Panel();
            this.labelMinute = new System.Windows.Forms.Label();
            this.panelHour = new System.Windows.Forms.Panel();
            this.labelHour = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelSettings.SuspendLayout();
            this.panelArea.SuspendLayout();
            this.panelSavedLaps.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelSecond.SuspendLayout();
            this.panelMinute.SuspendLayout();
            this.panelHour.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSettings.Controls.Add(this.buttonSettings);
            this.panelSettings.Controls.Add(this.buttonNewLocation);
            this.panelSettings.Controls.Add(this.buttonPrint);
            this.panelSettings.Controls.Add(this.textBoxLocation);
            this.panelSettings.Controls.Add(this.radioButtonDark);
            this.panelSettings.Controls.Add(this.radioButtonLight);
            this.panelSettings.Controls.Add(this.radioButtonDefault);
            this.panelSettings.Controls.Add(this.checkBoxAdvanced);
            this.panelSettings.Controls.Add(this.buttonSave);
            this.panelSettings.Controls.Add(this.buttonReset);
            this.panelSettings.Controls.Add(this.buttonStart);
            this.panelSettings.Controls.Add(this.buttonPause);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSettings.Location = new System.Drawing.Point(0, 227);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(745, 77);
            this.panelSettings.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.Location = new System.Drawing.Point(636, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(100, 23);
            this.buttonSettings.TabIndex = 9;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Visible = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonNewLocation
            // 
            this.buttonNewLocation.Location = new System.Drawing.Point(384, 51);
            this.buttonNewLocation.Name = "buttonNewLocation";
            this.buttonNewLocation.Size = new System.Drawing.Size(100, 23);
            this.buttonNewLocation.TabIndex = 7;
            this.buttonNewLocation.Text = "New Location";
            this.buttonNewLocation.UseVisualStyleBackColor = true;
            this.buttonNewLocation.Click += new System.EventHandler(this.ButtonNewLocation_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(490, 51);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(100, 23);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "Print Laps";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Enabled = false;
            this.textBoxLocation.Location = new System.Drawing.Point(14, 52);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(364, 23);
            this.textBoxLocation.TabIndex = 5;
            this.textBoxLocation.Text = "C:\\Stopwatch";
            // 
            // radioButtonDark
            // 
            this.radioButtonDark.AutoSize = true;
            this.radioButtonDark.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonDark.Location = new System.Drawing.Point(541, 14);
            this.radioButtonDark.Name = "radioButtonDark";
            this.radioButtonDark.Size = new System.Drawing.Size(49, 19);
            this.radioButtonDark.TabIndex = 4;
            this.radioButtonDark.TabStop = true;
            this.radioButtonDark.Text = "Dark";
            this.radioButtonDark.UseVisualStyleBackColor = true;
            this.radioButtonDark.CheckedChanged += new System.EventHandler(this.RadioButtonDark_CheckedChanged);
            // 
            // radioButtonLight
            // 
            this.radioButtonLight.AutoSize = true;
            this.radioButtonLight.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonLight.Location = new System.Drawing.Point(483, 14);
            this.radioButtonLight.Name = "radioButtonLight";
            this.radioButtonLight.Size = new System.Drawing.Size(52, 19);
            this.radioButtonLight.TabIndex = 3;
            this.radioButtonLight.TabStop = true;
            this.radioButtonLight.Text = "Light";
            this.radioButtonLight.UseVisualStyleBackColor = true;
            this.radioButtonLight.CheckedChanged += new System.EventHandler(this.RadioButtonLight_CheckedChanged);
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Checked = true;
            this.radioButtonDefault.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonDefault.Location = new System.Drawing.Point(414, 14);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(63, 19);
            this.radioButtonDefault.TabIndex = 3;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Default";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            this.radioButtonDefault.CheckedChanged += new System.EventHandler(this.RadioButtonDefault_CheckedChanged);
            // 
            // checkBoxAdvanced
            // 
            this.checkBoxAdvanced.AutoSize = true;
            this.checkBoxAdvanced.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxAdvanced.Location = new System.Drawing.Point(330, 15);
            this.checkBoxAdvanced.Name = "checkBoxAdvanced";
            this.checkBoxAdvanced.Size = new System.Drawing.Size(79, 19);
            this.checkBoxAdvanced.TabIndex = 1;
            this.checkBoxAdvanced.Text = "Advanced";
            this.checkBoxAdvanced.UseVisualStyleBackColor = true;
            this.checkBoxAdvanced.CheckedChanged += new System.EventHandler(this.CheckBoxAdvanced_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(224, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save Lap";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(118, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(14, 12);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(98, 23);
            this.buttonPause.TabIndex = 8;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Visible = false;
            this.buttonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // panelArea
            // 
            this.panelArea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelArea.Controls.Add(this.panelSavedLaps);
            this.panelArea.Controls.Add(this.panelContainer);
            this.panelArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArea.Location = new System.Drawing.Point(0, 0);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(745, 227);
            this.panelArea.TabIndex = 1;
            // 
            // panelSavedLaps
            // 
            this.panelSavedLaps.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSavedLaps.Controls.Add(this.listBoxSavedMoments);
            this.panelSavedLaps.Controls.Add(this.labelRecords);
            this.panelSavedLaps.Controls.Add(this.panelLabel);
            this.panelSavedLaps.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSavedLaps.Location = new System.Drawing.Point(608, 0);
            this.panelSavedLaps.Name = "panelSavedLaps";
            this.panelSavedLaps.Size = new System.Drawing.Size(137, 227);
            this.panelSavedLaps.TabIndex = 0;
            // 
            // listBoxSavedMoments
            // 
            this.listBoxSavedMoments.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBoxSavedMoments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSavedMoments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSavedMoments.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxSavedMoments.FormattingEnabled = true;
            this.listBoxSavedMoments.HorizontalScrollbar = true;
            this.listBoxSavedMoments.ItemHeight = 15;
            this.listBoxSavedMoments.Location = new System.Drawing.Point(0, 41);
            this.listBoxSavedMoments.Name = "listBoxSavedMoments";
            this.listBoxSavedMoments.Size = new System.Drawing.Size(137, 186);
            this.listBoxSavedMoments.TabIndex = 3;
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecords.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRecords.Location = new System.Drawing.Point(12, 9);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(116, 30);
            this.labelRecords.TabIndex = 1;
            this.labelRecords.Text = "Saved Laps";
            // 
            // panelLabel
            // 
            this.panelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabel.Location = new System.Drawing.Point(0, 0);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(137, 41);
            this.panelLabel.TabIndex = 4;
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContainer.Controls.Add(this.panelSecond);
            this.panelContainer.Controls.Add(this.panelMinute);
            this.panelContainer.Controls.Add(this.panelHour);
            this.panelContainer.Location = new System.Drawing.Point(14, 12);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(578, 201);
            this.panelContainer.TabIndex = 1;
            // 
            // panelSecond
            // 
            this.panelSecond.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSecond.Controls.Add(this.labelMillisecond);
            this.panelSecond.Controls.Add(this.labelSecond);
            this.panelSecond.Location = new System.Drawing.Point(370, 25);
            this.panelSecond.Name = "panelSecond";
            this.panelSecond.Size = new System.Drawing.Size(150, 150);
            this.panelSecond.TabIndex = 2;
            // 
            // labelMillisecond
            // 
            this.labelMillisecond.AutoSize = true;
            this.labelMillisecond.Location = new System.Drawing.Point(131, 135);
            this.labelMillisecond.Name = "labelMillisecond";
            this.labelMillisecond.Size = new System.Drawing.Size(19, 15);
            this.labelMillisecond.TabIndex = 3;
            this.labelMillisecond.Text = "00";
            this.labelMillisecond.Visible = false;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSecond.Location = new System.Drawing.Point(0, 9);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(158, 128);
            this.labelSecond.TabIndex = 2;
            this.labelSecond.Text = "00";
            // 
            // panelMinute
            // 
            this.panelMinute.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMinute.Controls.Add(this.labelMinute);
            this.panelMinute.Location = new System.Drawing.Point(214, 25);
            this.panelMinute.Name = "panelMinute";
            this.panelMinute.Size = new System.Drawing.Size(150, 150);
            this.panelMinute.TabIndex = 2;
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinute.Location = new System.Drawing.Point(-2, 9);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(158, 128);
            this.labelMinute.TabIndex = 1;
            this.labelMinute.Text = "00";
            // 
            // panelHour
            // 
            this.panelHour.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelHour.Controls.Add(this.labelHour);
            this.panelHour.Location = new System.Drawing.Point(58, 25);
            this.panelHour.Name = "panelHour";
            this.panelHour.Size = new System.Drawing.Size(150, 150);
            this.panelHour.TabIndex = 0;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHour.Location = new System.Drawing.Point(0, 9);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(158, 128);
            this.labelHour.TabIndex = 0;
            this.labelHour.Text = "00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 304);
            this.Controls.Add(this.panelArea);
            this.Controls.Add(this.panelSettings);
            this.MinimumSize = new System.Drawing.Size(761, 313);
            this.Name = "FormMain";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelArea.ResumeLayout(false);
            this.panelSavedLaps.ResumeLayout(false);
            this.panelSavedLaps.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelSecond.ResumeLayout(false);
            this.panelSecond.PerformLayout();
            this.panelMinute.ResumeLayout(false);
            this.panelMinute.PerformLayout();
            this.panelHour.ResumeLayout(false);
            this.panelHour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSettings;
        private Button buttonStart;
        private Button buttonSave;
        private Button buttonReset;
        private Panel panelArea;
        private Panel panelSavedLaps;
        private ListBox listBoxSavedMoments;
        private CheckBox checkBoxAdvanced;
        private Label labelRecords;
        private Panel panelContainer;
        private Panel panelHour;
        private Panel panelSecond;
        private Panel panelMinute;
        private Label labelHour;
        private Label labelSecond;
        private Label labelMinute;
        private RadioButton radioButtonLight;
        private RadioButton radioButtonDefault;
        private RadioButton radioButtonDark;
        private TextBox textBoxLocation;
        private Button buttonPrint;
        private Button buttonNewLocation;
        private System.Windows.Forms.Timer timer;
        private Button buttonPause;
        private Panel panelLabel;
        private FolderBrowserDialog folderBrowserDialog;
        private Label labelMillisecond;
        private Button buttonSettings;
    }
}