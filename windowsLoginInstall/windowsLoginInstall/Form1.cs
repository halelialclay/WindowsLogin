using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace windowsLoginInstall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string pathRegistry = "HKEY_LOCAL_MACHINE\\SOFTWARE\\OTPLogin";
            //string nameRegistry = "myWindoseLogin";
            //string idRegistry = textBoxID.Text;
            //Registry.SetValue(pathRegistry, nameRegistry, idRegistry);
            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software", true);

            key.CreateSubKey("OTPLogin");
            key = key.OpenSubKey("OTPLogin", true);

            key.SetValue("myWindoseLogin", textBoxID.Text);


        }
    }
}
