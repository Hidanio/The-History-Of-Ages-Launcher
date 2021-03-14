using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_History_Of_Ages_Launcher.Forms
{
    public partial class GameSettingsForm : Form
    {
        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void ChangeReg_Button_Click(object sender, EventArgs e)
        {
            Hide();
            var PathEdit = new PathEditForm {Left = Left, Top = Top};
            PathEdit.ShowDialog();
            Show();
        }

        private void ApplyGameSettingButton_Click(object sender, EventArgs e)
        {
            var Resolution = ResolutionComboBox.Text;
            var Graphic = GraphicComboBox.Text;

            MainMenuForm.GameSettings.EditIniOption("Resolution", Resolution);
            MainMenuForm.GameSettings.EditIniOption("StaticGameLOD", Graphic);
        }
    }
}
