using System.Globalization;

namespace Stopwatch
{
    public partial class FormMain : Form
    {
#pragma warning disable CS8618 // Null atanamaz alan, oluþturucudan çýkýþ yaparken null olmayan bir deðer içermelidir. Alaný null atanabilir olarak bildirmeyi düþünün.
        public FormMain()
#pragma warning restore CS8618 // Null atanamaz alan, oluþturucudan çýkýþ yaparken null olmayan bir deðer içermelidir. Alaný null atanabilir olarak bildirmeyi düþünün.
        {
            InitializeComponent();
        }

        // Global readonly strings
        readonly string configspath = @"C:\Stopwatch\Configs";
        readonly static string themepath = @"C:\Stopwatch\Configs\Theme.txt";
        readonly CultureInfo culture = CultureInfo.InstalledUICulture;

        private void FormMain_Load(object sender, EventArgs e)
        {
            Height = 313;
            panelSettings.Height = 47;
            panelContainer.Location = new Point(14, 12);

            switch (culture.ToString()[..2])
            {
                case "tr":
                    buttonStart.Text = "Baþlat";
                    buttonSave.Text = "Turu Kaydet";
                    buttonReset.Text = "Sýfýrla";
                    buttonPrint.Text = "Turlarý Yazdýr";
                    buttonPause.Text = "Duraklat";
                    buttonNewLocation.Text = "Yeni Konum";
                    labelRecords.Text = "Turlar";
                    checkBoxAdvanced.Text = "Geliþmiþ";
                    radioButtonDefault.Text = "Varsayýlan";
                    radioButtonLight.Text = "Açýk";
                    radioButtonDark.Text = "Koyu";
                    radioButtonDefault.Location = new Point(radioButtonDefault.Location.X - 10, radioButtonDefault.Location.Y);
                    break;
                case "en":
                    buttonStart.Text = "Start";
                    buttonSave.Text = "Save Lap";
                    buttonReset.Text = "Reset";
                    buttonPrint.Text = "Print Laps";
                    buttonPause.Text = "Pause";
                    buttonNewLocation.Text = "New Location";
                    labelRecords.Text = "Saved Laps";
                    checkBoxAdvanced.Text = "Advanced";
                    radioButtonDefault.Text = "Default";
                    radioButtonLight.Text = "Light";
                    radioButtonDark.Text = "Dark";
                    break;
            }

            if (!Directory.Exists(configspath))
            {
                Directory.CreateDirectory(configspath);
            }

            if (File.Exists(themepath))
            {
                string line = File.ReadLines(themepath).First();

                switch (line)
                {
                    case "default":
                        DefaultTheme();
                        ThemeRadio(true, false, false);
                        break;
                    case "light":
                        LightTheme();
                        ThemeRadio(false, true, false);
                        break;
                    case "dark":
                        DarkTheme();
                        ThemeRadio(false, false, true);
                        break;
                    default:
                        break;
                }

                void ThemeRadio(bool deftheme, bool light, bool dark){
                    radioButtonDefault.Checked = deftheme;
                    radioButtonLight.Checked = light;
                    radioButtonDark.Checked = dark;
                }
            }
        }

        // Global variables
        int hour = 0, minute = 0, second = 0, lap = 0;

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
            buttonReset.Enabled = true;
            buttonStart.Visible = false;
            buttonPause.Visible = true;
            buttonPause.Enabled = true;
            buttonStart.Text = "Resume";
            timer.Start();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            hour = 0;
            minute = 0;
            second = 0;
            lap = 0;
            labelHour.Text = "0" + hour.ToString();
            labelMinute.Text = "0" + minute.ToString();
            labelSecond.Text = "0" + second.ToString();
            timer.Stop();
            buttonStart.Enabled = true;
            buttonStart.Visible = true;
            buttonPause.Enabled = false;
            buttonPause.Visible = false;
            buttonSave.Enabled = false;
            buttonReset.Enabled = false;
            buttonStart.Text = "Start";
            listBoxSavedMoments.Items.Clear();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            lap++;
            listBoxSavedMoments.Items.Add("     " + lap + " - " + labelHour.Text + ":" + labelMinute.Text + ":" + labelSecond.Text);
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = false;
            buttonPause.Visible = false;
            buttonStart.Visible = true;
            timer.Stop();
        }

        public string folderpath = @"C:\Stopwatch";
        public string filepath;

        private void ButtonNewLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderpath = folderBrowserDialog.SelectedPath.ToString();
                textBoxLocation.Text = folderpath;
            }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int printCounter = 0;

                filepath = folderpath + @"\record1.txt";

                while (File.Exists(filepath))
                {
                    printCounter++;
                    filepath = folderpath + @"\record" + printCounter + ".txt";
                }

                Directory.CreateDirectory(folderpath);

                var currentDate = DateTime.Now;

                using (FileStream fileStream = new(filepath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using StreamWriter writer = new(fileStream);
                    int maxlist = listBoxSavedMoments.Items.Count;

                    writer.WriteLine(currentDate.ToString());
                    writer.WriteLine("--------------------");

                    for (int i = 0; i < maxlist; i++)
                    {
                        writer.WriteLine(listBoxSavedMoments.Items[i]);
                    }
                }

                MessageBox.Show("Your recordings are saved as a text document in " + folderpath, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadioButtonDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDefault.Checked)
            {
                DefaultTheme();
            }
        }

        public static void SavedTheme(string theme)
        {
            using FileStream fileStream = new(themepath, FileMode.OpenOrCreate, FileAccess.Write);
            using StreamWriter streamWriter = new(fileStream);
            streamWriter.WriteLine(theme);
        }

        public void DefaultTheme()
        {
            panelArea.BackColor = SystemColors.ControlDark;
            panelContainer.BackColor = SystemColors.ControlDarkDark;
            panelHour.BackColor = SystemColors.ControlDark;
            panelMinute.BackColor = SystemColors.ControlDark;
            panelSecond.BackColor = SystemColors.ControlDark;
            panelSavedLaps.BackColor = SystemColors.ControlDarkDark;
            panelSettings.BackColor = SystemColors.ControlDarkDark;
            labelHour.ForeColor = SystemColors.ControlText;
            labelMinute.ForeColor = SystemColors.ControlText;
            labelSecond.ForeColor = SystemColors.ControlText;
            listBoxSavedMoments.ForeColor = SystemColors.ScrollBar;
            listBoxSavedMoments.BackColor = SystemColors.ControlDarkDark;
            checkBoxAdvanced.ForeColor = SystemColors.Control;
            radioButtonDefault.ForeColor = SystemColors.Control;
            radioButtonLight.ForeColor = SystemColors.Control;
            radioButtonDark.ForeColor = SystemColors.Control;
            labelRecords.ForeColor = SystemColors.Control;
            SavedTheme("default");
        }

        public void LightTheme()
        {
            panelArea.BackColor = SystemColors.ControlLight;
            panelContainer.BackColor = SystemColors.Control;
            panelHour.BackColor = SystemColors.ControlLight;
            panelMinute.BackColor = SystemColors.ControlLight;
            panelSecond.BackColor = SystemColors.ControlLight;
            panelSavedLaps.BackColor = SystemColors.Control;
            panelSettings.BackColor= SystemColors.Control;
            labelHour.ForeColor = SystemColors.ControlText;
            labelMinute.ForeColor = SystemColors.ControlText;
            labelSecond.ForeColor = SystemColors.ControlText;
            listBoxSavedMoments.ForeColor = SystemColors.ControlText;
            listBoxSavedMoments.BackColor = SystemColors.Control;
            checkBoxAdvanced.ForeColor = SystemColors.ControlText;
            radioButtonDefault.ForeColor = SystemColors.ControlText;
            radioButtonLight.ForeColor = SystemColors.ControlText;
            radioButtonDark.ForeColor = SystemColors.ControlText;
            labelRecords.ForeColor = SystemColors.ControlText;
            SavedTheme("light");
        }

        public void DarkTheme()
        {
            panelArea.BackColor = Color.FromArgb(30, 30, 30);
            panelContainer.BackColor = Color.FromArgb(40, 40, 40);
            panelHour.BackColor = Color.FromArgb(30, 30, 30);
            panelMinute.BackColor = Color.FromArgb(30, 30, 30);
            panelSecond.BackColor = Color.FromArgb(30, 30, 30);
            panelSavedLaps.BackColor = Color.FromArgb(40, 40, 40);
            panelSettings.BackColor = Color.FromArgb(40, 40, 40);
            labelHour.ForeColor = SystemColors.Control;
            labelMinute.ForeColor = SystemColors.Control;
            labelSecond.ForeColor = SystemColors.Control;
            listBoxSavedMoments.ForeColor = SystemColors.ScrollBar;
            listBoxSavedMoments.BackColor = Color.FromArgb(40, 40, 40);
            checkBoxAdvanced.ForeColor = SystemColors.Control;
            radioButtonDefault.ForeColor = SystemColors.Control;
            radioButtonLight.ForeColor = SystemColors.Control;
            radioButtonDark.ForeColor = SystemColors.Control;
            labelRecords.ForeColor = SystemColors.Control;
            SavedTheme("dark");
        }

        private void RadioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLight.Checked)
            {
                LightTheme();
            }
        }

        private void RadioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDark.Checked)
            {
                DarkTheme();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
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
        }

        private void CheckBoxAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdvanced.Checked)
            {
                Height += 30;
                panelSettings.Height = 77;
                //panelContainer.Location = new Point(panelContainer.Location.X, panelContainer.Location.Y - 15);
            }
            else
            {
                Height -= 30;
                panelSettings.Height = 47;
                //panelContainer.Location = new Point(panelContainer.Location.X, panelContainer.Location.Y + 15);
            }
        }
    }
}