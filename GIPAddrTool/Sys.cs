using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;

namespace GIPAddrTool
{
    partial class Form1
    {
        protected RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings", true);

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
                        regkey.SetValue("ProxyEnable", 1);
                        regkey.SetValue("ProxyServer", "160.16.116.86:64827");
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
    }
}
