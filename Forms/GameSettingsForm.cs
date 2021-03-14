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

namespace The_History_Of_Ages_Launcher.Forms
{
    public partial class GameSettingsForm : Form
    {
        public static BfmeIniParser GameSettings = new BfmeIniParser();
        public GameSettingsForm()
        {
            InitializeComponent();
            GameSettings.SetParsedIni(GameSettings.ParserIni());
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

            GameSettings.EditIniOption("Resolution", Resolution);
            GameSettings.EditIniOption("StaticGameLOD", Graphic);
        }
    }
}
