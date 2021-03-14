using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_History_Of_Ages_Launcher.Classes;
using The_History_Of_Ages_Launcher.Properties;

namespace The_History_Of_Ages_Launcher.Forms
{
    public partial class PathEditForm : Form
    {
        public PathEditForm()
        {
            InitializeComponent();
        }

        private void Path_button_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MainMenuForm.RegSettings.SetPathRegedit(openFileDialog.FileName);
                    Close();
                }
            }
        }
    }
}
