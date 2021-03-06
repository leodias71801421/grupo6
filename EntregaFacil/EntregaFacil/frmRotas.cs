using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaFacil
{
    public partial class frmRotas : Form
    {
        public frmRotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text))
                MessageBox.Show("Por favor informe o ponto de início e o ponto de chegada");
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
                MessageBox.Show("Por favor informe o ponto de início");
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
                MessageBox.Show("Por favor informe o ponto chegada");
            else
            {
               NavigateToRoute(new string[2] { textBox1.Text, textBox2.Text });
            }
        }
              
        public void NavigateToRoute(IEnumerable<string> points)
        {
            string baseAdress = "https://www.google.com.br/maps/dir/";

            StringBuilder url = new StringBuilder(baseAdress);
            foreach (string point in points)
            {
                url.Append(Uri.EscapeDataString(point));
                url.Append("/");
            }

            webBrowser1.Navigate(new Uri(url.ToString()));
        }

        private void FixBrowser()
        {
            try
            {
                Microsoft.Win32.RegistryKey regDM = null;
                bool is64 = Environment.Is64BitOperatingSystem;
                string KeyPath = "";
                if (is64)
                {
                    KeyPath = "SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION";
                }
                else
                {
                    KeyPath = "SOFTWARE\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION";
                }

                regDM = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(KeyPath, false);
                if (regDM == null)
                {
                    regDM = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(KeyPath);
                }

                Microsoft.Win32.RegistryKey Sleutel = null;
                if ((regDM != null))
                {
                    string location = System.Environment.GetCommandLineArgs()[0];
                    string appName = System.IO.Path.GetFileName(location);
                    if (regDM.GetValue(appName) == null)
                    {
                        //Sleutel onbekend
                        regDM = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(KeyPath, true);
                        Sleutel = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(KeyPath, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);

                        //What OS are we using
                        Version OsVersion = System.Environment.OSVersion.Version;

                        if (OsVersion.Major == 6 & OsVersion.Minor == 1)
                        {
                            //WIN 7
                            Sleutel.SetValue(appName, 9000, Microsoft.Win32.RegistryValueKind.DWord);
                        }
                        else if (OsVersion.Major == 6 & OsVersion.Minor == 2)
                        {
                            //WIN 8
                            Sleutel.SetValue(appName, 10000, Microsoft.Win32.RegistryValueKind.DWord);
                        }
                        else if (OsVersion.Major == 5 & OsVersion.Minor == 1)
                        {
                            //WIN xp
                            Sleutel.SetValue(appName, 8000, Microsoft.Win32.RegistryValueKind.DWord);
                        }

                        Sleutel.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRotas_Load(object sender, EventArgs e)
        {
            FixBrowser();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url == webBrowser1.Url)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
        }

        
    }
}
