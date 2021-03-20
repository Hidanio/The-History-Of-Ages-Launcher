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

namespace The_History_Of_Ages_Launcher
{
    public partial class GameInterfaceSettingsForm : Form
    {
        public GameInterfaceSettingsForm()
        {
            InitializeComponent();
        }

        private void GameInterfaceSettings_Load(object sender, EventArgs e)
        {

        }

        private void ApplyGameInterfaceButton_Click(object sender, EventArgs e)
        {
            InterfaceManipulator ChangeVisual = new InterfaceManipulator();
            var Palantir = PalantirComboBox.Text;
            ChangeVisual.ChangePalantir(Palantir);
   
            var GameInterface = InterfaceComboBox.Text;
            ChangeVisual.ChangeGameInterface(GameInterface);


        }
    }
}
