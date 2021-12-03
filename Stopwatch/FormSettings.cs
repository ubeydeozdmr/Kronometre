using System.Diagnostics;

namespace Stopwatch
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        //readonly string configspath = @"C:\Stopwatch\Configs";
        readonly static string themepath = @"C:\Stopwatch\Configs\Theme.txt";

        private void FormSettings_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.SelectedIndex = 0;

            if (File.Exists(themepath))
            {
                string line = File.ReadLines(themepath).First();

                switch (line)
                {
                    case "classic":
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

                void ThemeRadio(bool deftheme, bool light, bool dark)
                {
                    radioButtonDefault.Checked = deftheme;
                    radioButtonLight.Checked = light;
                    radioButtonDark.Checked = dark;
                }
            }
        }

        public void DefaultTheme()
        {
            ForeColor = SystemColors.ControlText;
            BackColor = SystemColors.ControlDark;
            labelSettings.ForeColor = Color.White;
            labelSettings.BackColor = SystemColors.ControlDarkDark;
            panelTitle.BackColor = SystemColors.ControlDarkDark;
            SavedTheme("classic");
        }

        public void LightTheme()
        {
            ForeColor = SystemColors.ControlText;
            BackColor = SystemColors.ControlLightLight;
            labelSettings.ForeColor = SystemColors.ControlText;
            labelSettings.BackColor = SystemColors.ControlLight;
            panelTitle.BackColor = SystemColors.ControlLight;
            SavedTheme("light");
        }

        public void DarkTheme()
        {
            var color = Color.FromArgb(40, 40, 40).ToArgb();
            ForeColor = Color.White;
            BackColor = Color.FromArgb(30, 30, 30);
            labelSettings.ForeColor = Color.White;
            labelSettings.BackColor = Color.FromArgb(color);
            panelTitle.BackColor = Color.FromArgb(color);
            radioButtonDefault.ForeColor = Color.White;
            radioButtonLight.ForeColor = Color.White;
            radioButtonDark.ForeColor = Color.White;
            checkBoxShowFrames.ForeColor = Color.White;
            buttonEmail.BackColor = Color.FromArgb(color);
            buttonGithub.BackColor = Color.FromArgb(color);
            buttonNewLocation.BackColor = Color.FromArgb(color);
            buttonReddit.BackColor = Color.FromArgb(color);
            buttonSourceCode.BackColor = Color.FromArgb(color);
            buttonTelegram.BackColor = Color.FromArgb(color);
            buttonTwitter.BackColor = Color.FromArgb(color);
            SavedTheme("dark");
        }

        public static void Browse(string link)
        {
            Process process = new();

            try
            {
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = link;
                process.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ButtonEmail_Click(object sender, EventArgs e) => Browse("mailto:ubeydeozdmr@gmail.com");
        private void ButtonTwitter_Click(object sender, EventArgs e) => Browse("https://twitter.com/ubeydeozdmr");
        private void ButtonTelegram_Click(object sender, EventArgs e) => Browse("https://t.me/ubeydeozdmr");
        private void ButtonReddit_Click(object sender, EventArgs e) => Browse("https://www.reddit.com/user/ubeydeozdmr");
        private void ButtonGithub_Click(object sender, EventArgs e) => Browse("https://github.com/ubeydeozdmr");
        private void ButtonSourceCode_Click(object sender, EventArgs e) => Browse("https://github.com/ubeydeozdmr/Stopwatch");

        private void RadioButtonDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDefault.Checked)
            {
                DefaultTheme();
            }
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

        public static void SavedTheme(string theme)
        {
            using FileStream fileStream = new(themepath, FileMode.OpenOrCreate, FileAccess.Write);
            using StreamWriter streamWriter = new(fileStream);
            streamWriter.WriteLine(theme);
        }

        public string folderpath = @"C:\Stopwatch";

        private void ButtonNewLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderpath = folderBrowserDialog.SelectedPath.ToString();
                textBoxLocation.Text = folderpath;
            }
        }
    }
}