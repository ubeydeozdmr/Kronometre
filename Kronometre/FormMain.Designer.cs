
namespace Kronometre
{
    partial class Kronometre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kronometre));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHour = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMinute = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelSecond = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addRecord = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.locationButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.labelHour);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 0;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Segoe UI", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHour.ForeColor = System.Drawing.Color.White;
            this.labelHour.Location = new System.Drawing.Point(4, 4);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(210, 170);
            this.labelHour.TabIndex = 0;
            this.labelHour.Text = "00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.labelMinute);
            this.panel2.Location = new System.Drawing.Point(218, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 1;
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Segoe UI", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinute.ForeColor = System.Drawing.Color.White;
            this.labelMinute.Location = new System.Drawing.Point(4, 4);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(210, 170);
            this.labelMinute.TabIndex = 0;
            this.labelMinute.Text = "00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.labelSecond);
            this.panel3.Location = new System.Drawing.Point(424, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 200);
            this.panel3.TabIndex = 2;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Segoe UI", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSecond.ForeColor = System.Drawing.Color.White;
            this.labelSecond.Location = new System.Drawing.Point(4, 4);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(210, 170);
            this.labelSecond.TabIndex = 0;
            this.labelSecond.Text = "00";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 219);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Kronometreyi Başlat";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(424, 219);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(200, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Kronometreyi Durdur";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(219, 219);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(199, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Kronometreyi Sıfırla";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(14, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(117, 199);
            this.listBox1.TabIndex = 9;
            // 
            // addRecord
            // 
            this.addRecord.Location = new System.Drawing.Point(137, 22);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(99, 23);
            this.addRecord.TabIndex = 3;
            this.addRecord.Text = "Anlık Kaydet";
            this.addRecord.UseVisualStyleBackColor = true;
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Location = new System.Drawing.Point(137, 51);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(99, 23);
            this.deleteRecord.TabIndex = 4;
            this.deleteRecord.Text = "Kayıtları Sil";
            this.deleteRecord.UseVisualStyleBackColor = true;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.locationButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.infoButton);
            this.groupBox1.Controls.Add(this.printButton);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.deleteRecord);
            this.groupBox1.Controls.Add(this.addRecord);
            this.groupBox1.Location = new System.Drawing.Point(630, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 238);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlar";
            // 
            // locationButton
            // 
            this.locationButton.Location = new System.Drawing.Point(137, 111);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(99, 23);
            this.locationButton.TabIndex = 12;
            this.locationButton.Text = "Yazdır Konumu";
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(138, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 50);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diller";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "EN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "TR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(137, 142);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(98, 23);
            this.infoButton.TabIndex = 6;
            this.infoButton.Text = "Bilgi";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(137, 81);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(99, 23);
            this.printButton.TabIndex = 5;
            this.printButton.Text = "Yazdır";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // folderInfo
            // 
            this.folderInfo.AutoSize = true;
            this.folderInfo.Location = new System.Drawing.Point(644, 232);
            this.folderInfo.Name = "folderInfo";
            this.folderInfo.Size = new System.Drawing.Size(86, 15);
            this.folderInfo.TabIndex = 10;
            this.folderInfo.Text = "C:\\Kronometre";
            this.folderInfo.Visible = false;
            // 
            // Kronometre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 249);
            this.Controls.Add(this.folderInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kronometre";
            this.Text = "Kronometre";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label folderInfo;
    }
}

