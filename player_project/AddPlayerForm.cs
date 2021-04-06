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
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_AddPlayer_Click(object sender, EventArgs e)
        {

            //Add Player
            //1-Instantier un player
            Player p = new Player();
            //2-initialiser les propriétés du Player à partir des données saisies dans la Forme
            p.Id = int.Parse(txt_Id.Text);
            p.Name = txt_Name.Text;
            p.BirthDate = dtp_birthdate.Value;
            p.Position = (PlayerPosition)cmb_position.SelectedItem;
            p.State = PlayerState.Safe;
            if (rdb_injured.Checked)
                p.State = PlayerState.Injured;
            //3-Ajouter le player dans la liste
            bool result=MenuForm.team.AddPlayer(p);
            if(result)
                MessageBox.Show("Player has been added successfuly");
            else
                MessageBox.Show("This player already exist");

        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_position.DataSource = Enum.GetValues(typeof(PlayerPosition));
        }

        private void txt_Id_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txt_Id.Text) < 0)
            {
                MessageBox.Show("Id erroné");
                bt_AddPlayer.Enabled = false;
            }
            else
                bt_AddPlayer.Enabled = true;

        }
    }
}
