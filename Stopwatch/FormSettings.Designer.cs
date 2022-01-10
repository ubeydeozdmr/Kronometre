namespace Stopwatch
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.radioButtonDark = new System.Windows.Forms.RadioButton();
            this.radioButtonLight = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.labelPrintLocation = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.checkBoxShowFrames = new System.Windows.Forms.CheckBox();
            this.buttonNewLocation = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelInfoDetails = new System.Windows.Forms.Label();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.labelContact = new System.Windows.Forms.Label();
            this.buttonTwitter = new System.Windows.Forms.Button();
            this.buttonTelegram = new System.Windows.Forms.Button();
            this.buttonReddit = new System.Windows.Forms.Button();
            this.buttonGithub = new System.Windows.Forms.Button();
            this.buttonSourceCode = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSettings.Location = new System.Drawing.Point(12, 9);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(100, 32);
            this.labelSettings.TabIndex = 0;
            this.labelSettings.Text = "Settings";
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTheme.Location = new System.Drawing.Point(12, 70);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(57, 21);
            this.labelTheme.TabIndex = 1;
            this.labelTheme.Text = "Theme";
            // 
            // radioButtonDark
            // 
            this.radioButtonDark.AutoSize = true;
            this.radioButtonDark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonDark.Location = new System.Drawing.Point(124, 123);
            this.radioButtonDark.Name = "radioButtonDark";
            this.radioButtonDark.Size = new System.Drawing.Size(49, 19);
            this.radioButtonDark.TabIndex = 7;
            this.radioButtonDark.Text = "Dark";
            this.radioButtonDark.UseVisualStyleBackColor = true;
            this.radioButtonDark.Visible = false;
            this.radioButtonDark.CheckedChanged += new System.EventHandler(this.RadioButtonDark_CheckedChanged);
            // 
            // radioButtonLight
            // 
            this.radioButtonLight.AutoSize = true;
            this.radioButtonLight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonLight.Location = new System.Drawing.Point(124, 98);
            this.radioButtonLight.Name = "radioButtonLight";
            this.radioButtonLight.Size = new System.Drawing.Size(52, 19);
            this.radioButtonLight.TabIndex = 5;
            this.radioButtonLight.Text = "Light";
            this.radioButtonLight.UseVisualStyleBackColor = true;
            this.radioButtonLight.Visible = false;
            this.radioButtonLight.CheckedChanged += new System.EventHandler(this.RadioButtonLight_CheckedChanged);
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonDefault.Location = new System.Drawing.Point(124, 73);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(63, 19);
            this.radioButtonDefault.TabIndex = 6;
            this.radioButtonDefault.Text = "Default";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            this.radioButtonDefault.Visible = false;
            this.radioButtonDefault.CheckedChanged += new System.EventHandler(this.RadioButtonDefault_CheckedChanged);
            // 
            // labelPrintLocation
            // 
            this.labelPrintLocation.AutoSize = true;
            this.labelPrintLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrintLocation.Location = new System.Drawing.Point(12, 180);
            this.labelPrintLocation.Name = "labelPrintLocation";
            this.labelPrintLocation.Size = new System.Drawing.Size(106, 21);
            this.labelPrintLocation.TabIndex = 8;
            this.labelPrintLocation.Text = "Print Location";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Enabled = false;
            this.textBoxLocation.Location = new System.Drawing.Point(124, 180);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(278, 23);
            this.textBoxLocation.TabIndex = 9;
            this.textBoxLocation.Text = "C:\\Stopwatch";
            this.textBoxLocation.Visible = false;
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLanguage.Location = new System.Drawing.Point(12, 236);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(78, 21);
            this.labelLanguage.TabIndex = 10;
            this.labelLanguage.Text = "Language";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Follow system language"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(124, 238);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(278, 23);
            this.comboBoxLanguage.TabIndex = 11;
            this.comboBoxLanguage.Visible = false;
            // 
            // checkBoxShowFrames
            // 
            this.checkBoxShowFrames.AutoSize = true;
            this.checkBoxShowFrames.Location = new System.Drawing.Point(124, 148);
            this.checkBoxShowFrames.Name = "checkBoxShowFrames";
            this.checkBoxShowFrames.Size = new System.Drawing.Size(96, 19);
            this.checkBoxShowFrames.TabIndex = 12;
            this.checkBoxShowFrames.Text = "Show Frames";
            this.checkBoxShowFrames.UseVisualStyleBackColor = true;
            this.checkBoxShowFrames.Visible = false;
            // 
            // buttonNewLocation
            // 
            this.buttonNewLocation.Location = new System.Drawing.Point(302, 209);
            this.buttonNewLocation.Name = "buttonNewLocation";
            this.buttonNewLocation.Size = new System.Drawing.Size(100, 23);
            this.buttonNewLocation.TabIndex = 13;
            this.buttonNewLocation.Text = "New Location";
            this.buttonNewLocation.UseVisualStyleBackColor = true;
            this.buttonNewLocation.Visible = false;
            this.buttonNewLocation.Click += new System.EventHandler(this.ButtonNewLocation_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.Location = new System.Drawing.Point(12, 289);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(37, 21);
            this.labelInfo.TabIndex = 14;
            this.labelInfo.Text = "Info";
            // 
            // labelInfoDetails
            // 
            this.labelInfoDetails.AutoSize = true;
            this.labelInfoDetails.Location = new System.Drawing.Point(124, 294);
            this.labelInfoDetails.Name = "labelInfoDetails";
            this.labelInfoDetails.Size = new System.Drawing.Size(273, 15);
            this.labelInfoDetails.TabIndex = 15;
            this.labelInfoDetails.Text = "Stopwatch v2.0 - Created by Ubeyde Emir Özdemir";
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(124, 342);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(100, 23);
            this.buttonEmail.TabIndex = 16;
            this.buttonEmail.Text = "Email";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.ButtonEmail_Click);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContact.Location = new System.Drawing.Point(12, 341);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(63, 21);
            this.labelContact.TabIndex = 17;
            this.labelContact.Text = "Contact";
            // 
            // buttonTwitter
            // 
            this.buttonTwitter.Location = new System.Drawing.Point(230, 342);
            this.buttonTwitter.Name = "buttonTwitter";
            this.buttonTwitter.Size = new System.Drawing.Size(100, 23);
            this.buttonTwitter.TabIndex = 18;
            this.buttonTwitter.Text = "Twitter";
            this.buttonTwitter.UseVisualStyleBackColor = true;
            this.buttonTwitter.Click += new System.EventHandler(this.ButtonTwitter_Click);
            // 
            // buttonTelegram
            // 
            this.buttonTelegram.Location = new System.Drawing.Point(124, 371);
            this.buttonTelegram.Name = "buttonTelegram";
            this.buttonTelegram.Size = new System.Drawing.Size(100, 23);
            this.buttonTelegram.TabIndex = 19;
            this.buttonTelegram.Text = "Telegram";
            this.buttonTelegram.UseVisualStyleBackColor = true;
            this.buttonTelegram.Click += new System.EventHandler(this.ButtonTelegram_Click);
            // 
            // buttonReddit
            // 
            this.buttonReddit.Location = new System.Drawing.Point(230, 371);
            this.buttonReddit.Name = "buttonReddit";
            this.buttonReddit.Size = new System.Drawing.Size(100, 23);
            this.buttonReddit.TabIndex = 20;
            this.buttonReddit.Text = "Reddit";
            this.buttonReddit.UseVisualStyleBackColor = true;
            this.buttonReddit.Click += new System.EventHandler(this.ButtonReddit_Click);
            // 
            // buttonGithub
            // 
            this.buttonGithub.Location = new System.Drawing.Point(124, 400);
            this.buttonGithub.Name = "buttonGithub";
            this.buttonGithub.Size = new System.Drawing.Size(100, 23);
            this.buttonGithub.TabIndex = 21;
            this.buttonGithub.Text = "Github";
            this.buttonGithub.UseVisualStyleBackColor = true;
            this.buttonGithub.Click += new System.EventHandler(this.ButtonGithub_Click);
            // 
            // buttonSourceCode
            // 
            this.buttonSourceCode.Location = new System.Drawing.Point(230, 400);
            this.buttonSourceCode.Name = "buttonSourceCode";
            this.buttonSourceCode.Size = new System.Drawing.Size(100, 23);
            this.buttonSourceCode.TabIndex = 22;
            this.buttonSourceCode.Text = "Source Code";
            this.buttonSourceCode.UseVisualStyleBackColor = true;
            this.buttonSourceCode.Click += new System.EventHandler(this.ButtonSourceCode_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(414, 50);
            this.panelTitle.TabIndex = 23;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.buttonSourceCode);
            this.Controls.Add(this.buttonGithub);
            this.Controls.Add(this.buttonReddit);
            this.Controls.Add(this.buttonTelegram);
            this.Controls.Add(this.buttonTwitter);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.labelInfoDetails);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonNewLocation);
            this.Controls.Add(this.checkBoxShowFrames);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelPrintLocation);
            this.Controls.Add(this.radioButtonDark);
            this.Controls.Add(this.radioButtonLight);
            this.Controls.Add(this.radioButtonDefault);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.panelTitle);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSettings;
        private Label labelTheme;
        private RadioButton radioButtonDark;
        private RadioButton radioButtonLight;
        private RadioButton radioButtonDefault;
        private Label labelPrintLocation;
        private TextBox textBoxLocation;
        private Label labelLanguage;
        private ComboBox comboBoxLanguage;
        private CheckBox checkBoxShowFrames;
        private Button buttonNewLocation;
        private Label labelInfo;
        private Label labelInfoDetails;
        private Button buttonEmail;
        private Label labelContact;
        private Button buttonTwitter;
        private Button buttonTelegram;
        private Button buttonReddit;
        private Button buttonGithub;
        private Button buttonSourceCode;
        private Panel panelTitle;
        private FolderBrowserDialog folderBrowserDialog;
    }
}