using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using The_History_Of_Ages_Launcher.Classes;
using The_History_Of_Ages_Launcher.Forms;

namespace The_History_Of_Ages_Launcher
{
    
    public partial class MainMenuForm : Form
    {
        public static Launcher Settings = new Launcher();
        public MainMenuForm()
        {
            InitializeComponent();
            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\ThoaLauncher", "PathEXE", null) == null)
            {
                var PathForm = new PathEditForm();
                PathForm.ShowDialog();
                Settings.CreateRegeditKey(Settings.PathRegedit);
            }
        }


        private void GameInterface_button_Click(object sender, EventArgs e)
        {
            Hide();
            var InterfaceSettings = new GameInterfaceSettingsForm();
            InterfaceSettings.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            InterfaceSettings.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            InterfaceSettings.ShowDialog();
            Show();
        }

        private void Launch_button_Click(object sender, EventArgs e)
        {
            // TODO: добавить проверку языка
            string LaunchGamePath = Settings.GetRegeditPathExeValue();
            Process.Start(LaunchGamePath); //
        }

        private void Vk_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://vk.com/thoakodding";
            var si = new ProcessStartInfo(url);
            Process.Start(si);
            Vk_LinkLabel.LinkVisited = true;
        }

        private void Fb_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.facebook.com/Battle-for-Middle-earth-The-History-of-Ages-104300344528100/";
            var si = new ProcessStartInfo(url);
            Process.Start(si);
            Fb_LinkLabel.LinkVisited = true;
        }

 
    }
}
