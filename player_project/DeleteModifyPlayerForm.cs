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
    public partial class DeleteModifyPlayerForm : Form
    {
        private string action;//attribut
        public DeleteModifyPlayerForm(string action)
        {
            InitializeComponent();
            this.action = action;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteModifyPlayerForm_Load(object sender, EventArgs e)
        {
            lab_title.Text = "Modify Player";
            if(action=="Delete")
            {
                lab_title.Text = "Delete Player";
                bt_Delete_ModifyPlayer.Text = "Delete Player";
                this.Text = "Delete Player";
                //groupBox1.Controls --> retourne tous les composants graphiques du groupBox
                //Les bouttons, les textBox, les labels,... sont tous des Controles.
                //La propriété Enabled=false <==> le controle graphique devient grisé
                foreach (Control x in groupBox1.Controls)
                {
                    if(!(x is Label))
                        x.Enabled = false;
                }
                cmb_Id.Enabled = true;
            }

        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            //Show()==>permet de visualize une form
            //Hide()==>permet de caher la form sans detruire l'instance
            //Close() ==>permet de fermer la form et detruit l'instance
            this.Close();
        }
    }
}
