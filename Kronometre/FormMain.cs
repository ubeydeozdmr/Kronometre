using System;
using System.Windows.Forms;
using System.IO;

namespace Kronometre
{
    public partial class Kronometre : Form
    {
        public Kronometre()
        {
            InitializeComponent();
        }

        //genel değişkenler && global variables
        int hour = 0, minute = 0, second = 0, lap = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Sayının daima çift haneli olarak gözükmesi için eğer saniye, dakika veya saat değeri 10'dan küçük ise başına 0 eklenir.
            //If the second, minute, or hour value is less than 10, a 0 is prepended so that the number always appears as double digits.

            second++;
            if (second < 10)
            {
                labelSecond.Text = "0" + second.ToString();
            }
            else
            {
                labelSecond.Text = second.ToString();
            }

            if (second == 60)
            {
                second = 0;
                labelSecond.Text = "0" + second.ToString();
                minute++;
                if (minute < 10)
                {
                    labelMinute.Text = "0" + minute.ToString();
                }
                else
                {
                    labelMinute.Text = minute.ToString();
                }
                if (minute == 60)
                {
                    second = 0;
                    labelSecond.Text = "0" + second.ToString();
                    minute = 0;
                    labelMinute.Text = "0" + minute.ToString();
                    hour++;
                    if (hour < 10)
                    {
                        labelHour.Text = "0" + hour.ToString();
                    }
                    else
                    {
                        labelHour.Text = hour.ToString();
                    }
                }
            }

            if (hour == 100)
            {
                hour = 0;
                minute = 0;
                second = 0;
                if (!button1.Enabled) { startButton.Text = "Kronometre zaman aşımından dolayı sıfırlandı."; }
                else if (!button2.Enabled) { startButton.Text = "Chronometer reset due to timeout."; }
                else { }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            hour = 0;
            minute = 0;
            second = 0;
            lap = 0;
            labelHour.Text = "0" + hour.ToString();
            labelMinute.Text = "0" + minute.ToString();
            labelSecond.Text = "0" + second.ToString();
            timer1.Stop();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            resetButton.Enabled = false;
            if (!button1.Enabled) { startButton.Text = "Kronometreyi Başlat"; }
            else if (!button2.Enabled) { startButton.Text = "Start Chronometer"; }
            else { }
        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            lap++;
            listBox1.Items.Add(labelHour.Text + ":" + labelMinute.Text + ":" + labelSecond.Text + " " + "{" + lap + "}");
            //Saat, dakika ve saniye değerlerinin arasında : işareti bulunurken tur sayısı { } işareti içerisinde gösterilir.
            //Hour, minute and second values ​​are marked with : while the number of laps is shown in { }
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lap = 0;
        }

        public string folderpath = "C:\\Kronometre";
        public string filepath;

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Yazdırma sayacı her yazdır düğmesine basıldığında daha önceki dosyanın üzerine yazmaması ve "kayit" yazısından sonra gelen rakamın artması için gereklidir.
                //The print counter is required so that each time the print button is pressed, the previous file is not overwritten and the number after "save" increases.
                int printCounter = 1;

                filepath = folderpath + "\\kayit1.txt";

                while (File.Exists(filepath))
                {
                    //Kronometre uygulaması kapatılsa bile dosya ismi denetlemesi yapılarak önceki metin belgeleri korunur.
                    //Even if the chronometer application is turned off, the previous text documents are preserved by performing a file name check.
                    printCounter++;
                    filepath = folderpath + "\\kayit" + printCounter + ".txt";
                }

                Directory.CreateDirectory(folderpath);

                var currentDate = DateTime.Now;

                using (FileStream fileStream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        int maxlist = listBox1.Items.Count;

                        //Kayıtların olduğu kutudaki değerler metin belgesi olarak yazdırılır.
                        //The values ​​in the box with the records are printed as a text document.

                        streamWriter.WriteLine(currentDate);
                        streamWriter.WriteLine("--------------------");

                        for (int i = 0; i < maxlist; i++)
                        {
                            streamWriter.WriteLine(listBox1.Items[i]);
                        }
                    }
                }
                if (!button1.Enabled) { MessageBox.Show("Kayıtlarınız " + folderpath + " dizinine metin belgesi olarak kaydedildi.", "Başarılı"); }
                else if (!button2.Enabled) { MessageBox.Show("Your recordings are saved as a text document in " + folderpath, "Successful"); }
                else { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            string author = "Ubeyde Emir Özdemir";
            string version = "v1.1";
            string email = "ubeydeozdmr@gmail.com";
            string github = "ubeydeozdmr/kronometre";

            if (!button1.Enabled) {
                MessageBox.Show("Kronometreyi Başlat, Kronometreyi Devam Ettir, Kronometreyi Durdur, Kronometreyi Sıfırla düğmelerini kullanarak kronometreyi kontrol edebilirsiniz."
+ "\nBunun dışında isterseniz kayıt alabilir hatta bu kayıtları metin belgesi olarak yazdırabilirsiniz."
+ "\nYazdırdığınız kayıtlara C:\\Kronometre dizininden ulaşabilirsiniz. Bu dizini değiştirmek için ise \"Yazdırma Konumu\" düğmesine basın, yeni dizini seçin ve \"Klasör Seç\"'e tıklayın. "
+ "\nUygulama "+ author +" tarafından oluşturuldu. ("+ version +")"
+ "\nE-posta: " + email
+ "\nGithub: " + github, "Bilgi");
            } else if (!button2.Enabled)
            {
                MessageBox.Show("You can control the stopwatch using the Start Chronometer, Resume Chronometer, Stop Chronometer, Reset Chronometer buttons."
+ "\nIn addition, if you want, you can get records and even print these records as text documents."
+ "\nYou can access the records you have printed from the C:\\Kronometre directory. To change this directory, press the \"Print To\" button, select the new directory and click \"Select Folder\"."
+ "\nThe application was created by " + author +". (" + version +")"
+ "\nE-mail: " + email
+ "\nGithub: " + github, "Info");
            } else { }
            
        }

        //Çeviriler && Translations

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            resetButton.Text = "Kronometreyi Sıfırla";
            stopButton.Text = "Kronometreyi Durdur";
            if (startButton.Text == "Start Chronometer")
            {
                startButton.Text = "Kronometreyi Başlat";
            } else if (startButton.Text == "Resume Chronometer")
            {
                startButton.Text = "Kronometreyi Devam Ettir";
            } else { }
            addRecord.Text = "Turu Kaydet";
            deleteRecord.Text = "Kayıtları Sil";
            printButton.Text = "Yazdır";
            locationButton.Text = "Yazdır Konumu";
            infoButton.Text = "Bilgi";
            groupBox1.Text = "Kayıtlar";
            groupBox2.Text = "Diller";
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderpath = folderBrowserDialog1.SelectedPath.ToString();
                folderInfo.Text = folderpath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            resetButton.Text = "Reset Chronometer";
            stopButton.Text = "Stop Chronometer";
            if (startButton.Text == "Kronometreyi Başlat")
            {
                startButton.Text = "Start Chronometer";
            } else if (startButton.Text == "Kronometreyi Devam Ettir") {
                startButton.Text = "Resume Chronometer";
            } else { }
            addRecord.Text = "Save Lap";
            deleteRecord.Text = "Delete Records";
            printButton.Text = "Print";
            locationButton.Text = "Print to...";
            infoButton.Text = "Info";
            groupBox1.Text = "Records";
            groupBox2.Text = "Languages";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            stopButton.Enabled = true;
            startButton.Enabled = false;
            resetButton.Enabled = true;
            if (!button1.Enabled)
            {
                startButton.Text = "Kronometreyi Devam Ettir";
            }
            else if (!button1.Enabled)
            {
                startButton.Text = "Resume Chronometer";
            } else { }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            resetButton.Enabled = true;
            if (!button1.Enabled)
            {
                startButton.Text = "Kronometreyi Devam Ettir";
            }
            else if (!button1.Enabled)
            {
                startButton.Text = "Resume Chronometer";
            }
            else { }
        }
    }
}
