using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace GIPAddrTool
{
    partial class Form1
    {
        protected RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings", true);
        private Settings appSettings;
        private static string filename = "settings.config";
  
        public void regProxyEdit()
        {
            int proxy_enable_status = (int)regkey.GetValue("ProxyEnable");

            if(proxy_enable_status == 0)
            {
                DialogResult result = MessageBox.Show("プロキシ設定が有効になっていません。\r\n有効にしますか？", 
                    "確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string pipaddr = get_proxy_address();
                        string pnum = get_port_number();

                        regkey.SetValue("ProxyEnable", 1);
                        //regkey.SetValue("ProxyServer", "160.16.116.86:64827");
                        regkey.SetValue("ProxyServer", pipaddr + ":" + pnum);
                        regkey.SetValue("ProxyOverride", "<local>");
                        MessageBox.Show("プロキシ設定を有効にしました。", "通知");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("システムエラーです。チームリーダーに報告してください。\r\n" + ex.ToString(), "警告");
                    }

                }
            }
            else if(proxy_enable_status == 1)
            {
                DialogResult result = MessageBox.Show("プロキシ設定が有効です。\r\n無効にしますか？",
                    "確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        regkey.SetValue("ProxyEnable", 0);
                        MessageBox.Show("プロキシ設定を無効にしました。", "通知");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("システムエラーです。チームリーダーに報告してください。\r\n" + ex.ToString(), "警告");

                    }
                }

            }
            //Debug.WriteLine(proxy_enable_status);
        }

        private Settings loadAppSettings()
        {
            Settings appSettings = null;

            try
            {
                XmlSerializer xsz = new XmlSerializer(typeof(Settings));
                StreamReader sr = new StreamReader(
                    filename,
                    new System.Text.UTF8Encoding(false)
                );
                appSettings = (Settings)xsz.Deserialize(sr);
                sr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return appSettings;
        }

        private string get_proxy_address()
        {
            Settings st = loadAppSettings();
            return st.proxy_address;
        }

        private string get_port_number()
        {
            Settings st = loadAppSettings();
            return st.port_number;
        }

        private void showSettingDialog()
        {
            SettingDialog sd = new SettingDialog();
            sd.ShowDialog(this);
            sd.Dispose();
        }
    }
}
