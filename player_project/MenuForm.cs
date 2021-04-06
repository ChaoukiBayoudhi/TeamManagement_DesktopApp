using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace player_project
{
    public partial class MenuForm : Form
    {
        internal static Players team = new Players(); //En fait, nous manipulons un seul team
        //internal ==>team sera visible partout dans le projet courant
        //on accède à team via "MenuForm.team"
        public MenuForm()
        {
            InitializeComponent();
        }

        private void bt_AddPlayer_Click(object sender, EventArgs e)
        {
            //create the object
            AddPlayerForm f1 = new AddPlayerForm();
            //visualize the form
            f1.Show();

        }

        private void bt_ShowPlayers_Click(object sender, EventArgs e)
        {
            ShowPlayersForm f1 = new ShowPlayersForm();
            f1.Show();
        }

        private void bt_ExitApplication_Click(object sender, EventArgs e)
        {
            DialogResult choice=MessageBox.Show("Really you want to exit ?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(choice==DialogResult.Yes)
                Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_DeletePlayer_Click(object sender, EventArgs e)
        {
            //creation d'une instance (un objet)
            DeleteModifyPlayerForm dmf = new DeleteModifyPlayerForm("Delete");
            dmf.Show();
        }

        private void bt_ModifyPlayer_Click(object sender, EventArgs e)
        {
            DeleteModifyPlayerForm dmf = new DeleteModifyPlayerForm("Modify");
            dmf.Show();
        }
    }
}
