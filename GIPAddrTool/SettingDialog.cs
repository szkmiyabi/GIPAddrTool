using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Serialization;
using System.IO;

namespace GIPAddrTool
{
    public partial class SettingDialog : Form
    {

        private Settings appSettings;
        private string filename;

        //コンストラクタ
        public SettingDialog()
        {
            InitializeComponent();
            filename = Application.UserAppDataPath + @"\settings.config";
            appSettings = new Settings();
            loadSettings();
        }

        //環境設定を保存する
        private void saveSettings()
        {
            try
            {
                appSettings.proxy_address = proxyIPAddress.Text;
                appSettings.port_number = portNumber.Text;
                XmlSerializer xsz = new XmlSerializer(typeof(Settings));
                StreamWriter sw = new StreamWriter(
                    filename,
                    false,
                    new System.Text.UTF8Encoding(false)
                );
                xsz.Serialize(sw, appSettings);
                sw.Close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //環境設定をロードする
        private void loadSettings()
        {
            try
            {
                XmlSerializer xsz = new XmlSerializer(typeof(Settings));
                StreamReader sr = new StreamReader(
                    filename,
                    new System.Text.UTF8Encoding(false)
                );
                appSettings = (Settings)xsz.Deserialize(sr);
                sr.Close();
                proxyIPAddress.Text = appSettings.proxy_address;
                portNumber.Text = appSettings.port_number;
            }
            catch (FileNotFoundException exFileNotFound)
            {
                MessageBox.Show("設定ファイルが存在しません。このあと開くダイアログで設定を入力後にOKボタンをクリックすると自動的に" + filename + "を生成し、設定を保持できるようにします。");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //環境設定を削除する
        private void deleteSettings()
        {
            try
            {
                appSettings.proxy_address = "";
                appSettings.port_number = "";
                XmlSerializer xsz = new XmlSerializer(typeof(Settings));
                StreamWriter sw = new StreamWriter(
                    filename,
                    false,
                    new System.Text.UTF8Encoding(false)
                );
                xsz.Serialize(sw, appSettings);
                sw.Close();

                proxyIPAddress.Text = "";
                portNumber.Text = "";
                MessageBox.Show("設定が削除できました。");

            }
            catch (Exception ex)
            {
                MessageBox.Show("設定が削除できませんでした。" + ex.Message);
            }
        }

        private void settingSaveBtn_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

    }
}
