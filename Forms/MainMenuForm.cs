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
        public static Launcher RegSettings = new Launcher();

        
        public MainMenuForm()
        {
            InitializeComponent();
            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\ThoaLauncher", "PathEXE", null) == null)
            {
                var PathForm = new PathEditForm();
                PathForm.ShowDialog();
                RegSettings.CreateRegeditKey(RegSettings.GetPathRegedit(), "PathEXE");
            }
        }


        private void GameInterface_button_Click(object sender, EventArgs e)
        {
            Hide();
            var InterfaceSettings = new GameInterfaceSettingsForm {Left = Left, Top = Top};
            InterfaceSettings.ShowDialog();
            Show();
        }

        private void Launch_button_Click(object sender, EventArgs e)
        {
         InterfaceManipulator Language = new InterfaceManipulator();
         if (languageBox.Checked)
         {
             Language.ChangeLanguage(true);
             var LaunchGamePath = RegSettings.GetRegeditValue("PathEXE");
             if (LaunchGamePath != null)
                 Process.Start(LaunchGamePath);
             else
                 MessageBox.Show("Ошибка", "Путь к игре не найден.", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         else
         {
             Language.ChangeLanguage(false);
             var LaunchGamePath = RegSettings.GetRegeditValue("PathEXE");
             if (LaunchGamePath != null)
                 Process.Start(LaunchGamePath);
             else
                 MessageBox.Show("Ошибка", "Путь к игре не найден.", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
            
        }

        private void Vk_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "https://vk.com/thoakodding";
            var si = new ProcessStartInfo(url);
            Process.Start(si);
            Vk_LinkLabel.LinkVisited = true;
        }

        private void Fb_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "https://www.facebook.com/Battle-for-Middle-earth-The-History-of-Ages-104300344528100/";
            var si = new ProcessStartInfo(url);
            Process.Start(si);
            Fb_LinkLabel.LinkVisited = true;
        }

        private void GameSetting_button_Click(object sender, EventArgs e)
        {
            Hide();
            var GameSettings = new GameSettingsForm {Left = Left, Top = Top};
            GameSettings.ShowDialog();
            Show();
        }

        private void WorldBuilderButton_Click(object sender, EventArgs e)
        {
            InterfaceManipulator WB = new InterfaceManipulator();
            var Path =  WB.GetGamePath();
            var length = Path.Length - 1;
            for (var i = length; i > 0; --i)
            {
                if (Path[i] == '\\')
                {
                    Path = Path.Substring(0, i);
                    break;
                }
            }
            Process.Start(Path+ "\\Worldbuilder.exe");
        }


    }
}
