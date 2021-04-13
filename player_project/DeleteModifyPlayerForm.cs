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
            //La propriété DataSource : affecte un contenu à un controle graphique (combobox, dataGridView,...)
            //DataSource peut avoir ces valeurs à partir d'une liste, d'une table dans la bases de données ou d'une colonne
            cmb_Id.DataSource = MenuForm.team.getAllIds();
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

        private void cmb_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(cmb_Id.Text);//conversion de chaine de caratères vers entier
            Player p1=MenuForm.team.FindPlayerById(id);
            if (p1 == null)
                MessageBox.Show("This Player is not find");
            else
            {
                txt_Name.Text = p1.Name;
                dtp_birthdate.Value = p1.BirthDate;
                cmb_position.Text = p1.Position.ToString();
                rdb_safe.Checked = true;
                if (p1.State == PlayerState.Injured)
                    rdb_injured.Checked = true;
            }
        }

        private void bt_Delete_ModifyPlayer_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "Delete":
                    bool res=MenuForm.team.RemovePlayer(int.Parse(cmb_Id.Text));
                    if(res==true)
                        MessageBox.Show("The Player has been deleted");
                    else
                        MessageBox.Show("This player is not find");
                    break;
                case "Modify":
                    break;

            }
        }
    }
}
