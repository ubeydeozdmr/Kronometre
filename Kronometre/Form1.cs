using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        #region h = hour, m = minute, s = second
        #endregion
        int h = 0, m = 0, s = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s < 10)
            {
                labelSecond.Text = "0" + s.ToString();
            }
            else
            {
                labelSecond.Text = s.ToString();
            }

            if (s == 60)
            {
                s = 0;
                labelSecond.Text = "0" + s.ToString();
                m++;
                if (m < 10)
                {
                    labelMinute.Text = "0" + m.ToString();
                }
                else
                {
                    labelMinute.Text = m.ToString();
                }
                if (m == 60)
                {
                    s = 0;
                    labelSecond.Text = "0" + s.ToString();
                    m = 0;
                    labelMinute.Text = "0" + m.ToString();
                    h++;
                    if (h < 10)
                    {
                        labelHour.Text = "0" + h.ToString();
                    }
                    else
                    {
                        labelHour.Text = h.ToString();
                    }
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            h = 0;
            m = 0;
            s = 0;
            lap = 0;
            labelHour.Text = "0" + h.ToString();
            labelMinute.Text = "0" + m.ToString();
            labelSecond.Text = "0" + s.ToString();
            timer1.Stop();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            resetButton.Enabled = false;
            startButton.Text = "Kronometreyi Başlat";
        }

        int lap = 0;

        private void addRecord_Click(object sender, EventArgs e)
        {
            lap++;
            listBox1.Items.Add(labelHour.Text + ":" + labelMinute.Text + ":" + labelSecond.Text + " " + "{" + lap + "}");
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lap = 0;
        }

        int printCounter = 0;

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                printCounter++;

                string path = @"C:\Kronometre\kayit" + printCounter + ".txt";

                while (File.Exists(path))
                {
                    printCounter++;
                    path = @"C:\Kronometre\kayit" + printCounter + ".txt";
                }

                Directory.CreateDirectory(@"C:\Kronometre");

                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        int maxlist = listBox1.Items.Count;

                        for (int i = 0; i < maxlist; i++)
                        {
                            streamWriter.WriteLine(listBox1.Items[i]);
                        }
                    }
                }
                if (!button1.Enabled) { MessageBox.Show("Kayıtlarınız C:\\Kronometre dizinine metin belgesi olarak kaydedildi.", "Başarılı"); }
                else if (!button2.Enabled) { MessageBox.Show("Your recordings are saved as a text document in C:\\Kronometre", "Successful"); }
                else { }
            }
            catch
            {
                if (!button1.Enabled) { MessageBox.Show("Bir sorun oluştu.", "Hata"); }
                else if (!button2.Enabled) { MessageBox.Show("An error occured", "Error"); }
                else { }
            }
            finally
            {
                
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            if (!button1.Enabled) {
                MessageBox.Show("Kronometreyi Başlat, Kronometreyi Devam Ettir, Kronometreyi Durdur, Kronometreyi Sıfırla düğmelerini kullanarak kronometreyi kontrol edebilirsiniz."
+ "\nBunun dışında isterseniz kayıt alabilir hatta bu kayıtları metin belgesi olarak yazdırabilirsiniz."
+ "\nYazdırdığınız kayıtlara C:\\Kronometre dizininden ulaşabilirsiniz."
+ "\nUygulama Ubeyde Emir Özdemir tarafından oluşturuldu. (v1)"
+ "\nE-posta: ubeydeozdmr@gmail.com"
+ "\nGithub: ubeydeozdmr/kronometre", "Bilgi");
            } else if (!button2.Enabled)
            {
                MessageBox.Show("You can control the stopwatch using the Start Chronometer, Resume Chronometer, Stop Chronometer, Reset Chronometer buttons."
+ "\nIn addition, if you want, you can get records and even print these records as text documents."
+ "\nYou can access the records you have printed from the C:\\Kronometre directory."
+ "\nThe application was created by Ubeyde Emir Özdemir. (v1)"
+ "\nE-mail: ubeydeozdmr@gmail.com"
+ "\nGithub: ubeydeozdmr/kronometre", "Info");
            } else { }
            
        }

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
            infoButton.Text = "Bilgi";
            groupBox1.Text = "Kayıtlar";
            groupBox2.Text = "Diller";
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
