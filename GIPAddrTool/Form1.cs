using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace GIPAddrTool
{
    public partial class Form1 : Form
    {

        private string filename;

        public Form1()
        {
            InitializeComponent();
            filename = Application.UserAppDataPath + @"\settings.config";
            if(System.IO.File.Exists(filename))
                loadAppSettings();
        }

        private void getGIPAddrBtn_Click(object sender, EventArgs e)
        {
            GIPAddrTxt.Text = "";
            string val = Main.getGIPAddr();
            GIPAddrTxt.Text = val;
        }

        private void proxyBtn_Click(object sender, EventArgs e)
        {
            regProxyEdit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ugtop.com/spill.shtml");
        }

        private void FileMenuInSettingItem_Click(object sender, EventArgs e)
        {
            showSettingDialog();
        }
    }
}
