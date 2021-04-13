
namespace player_project
{
    partial class DeleteModifyPlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Id = new System.Windows.Forms.ComboBox();
            this.rdb_safe = new System.Windows.Forms.RadioButton();
            this.rdb_injured = new System.Windows.Forms.RadioButton();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lab_title = new System.Windows.Forms.Label();
            this.bt_Close = new System.Windows.Forms.Button();
            this.bt_Delete_ModifyPlayer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Id);
            this.groupBox1.Controls.Add(this.rdb_safe);
            this.groupBox1.Controls.Add(this.rdb_injured);
            this.groupBox1.Controls.Add(this.cmb_position);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_birthdate);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 262);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Informations";
            // 
            // cmb_Id
            // 
            this.cmb_Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Id.FormattingEnabled = true;
            this.cmb_Id.Location = new System.Drawing.Point(137, 29);
            this.cmb_Id.Name = "cmb_Id";
            this.cmb_Id.Size = new System.Drawing.Size(182, 26);
            this.cmb_Id.TabIndex = 6;
            this.cmb_Id.SelectedIndexChanged += new System.EventHandler(this.cmb_Id_SelectedIndexChanged);
            // 
            // rdb_safe
            // 
            this.rdb_safe.AutoSize = true;
            this.rdb_safe.Location = new System.Drawing.Point(259, 219);
            this.rdb_safe.Name = "rdb_safe";
            this.rdb_safe.Size = new System.Drawing.Size(60, 22);
            this.rdb_safe.TabIndex = 5;
            this.rdb_safe.TabStop = true;
            this.rdb_safe.Text = "Safe";
            this.rdb_safe.UseVisualStyleBackColor = true;
            // 
            // rdb_injured
            // 
            this.rdb_injured.AutoSize = true;
            this.rdb_injured.Location = new System.Drawing.Point(109, 219);
            this.rdb_injured.Name = "rdb_injured";
            this.rdb_injured.Size = new System.Drawing.Size(76, 22);
            this.rdb_injured.TabIndex = 4;
            this.rdb_injured.TabStop = true;
            this.rdb_injured.Text = "Injured";
            this.rdb_injured.UseVisualStyleBackColor = true;
            // 
            // cmb_position
            // 
            this.cmb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Location = new System.Drawing.Point(137, 170);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(182, 26);
            this.cmb_position.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "BirthDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(16, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(16, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "State";
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.Location = new System.Drawing.Point(137, 123);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(182, 24);
            this.dtp_birthdate.TabIndex = 2;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(137, 79);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(182, 24);
            this.txt_Name.TabIndex = 1;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.Location = new System.Drawing.Point(194, 25);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(156, 25);
            this.lab_title.TabIndex = 9;
            this.lab_title.Text = "Modify Player";
            this.lab_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.Location = new System.Drawing.Point(349, 348);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(139, 35);
            this.bt_Close.TabIndex = 11;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_Delete_ModifyPlayer
            // 
            this.bt_Delete_ModifyPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete_ModifyPlayer.Location = new System.Drawing.Point(24, 348);
            this.bt_Delete_ModifyPlayer.Name = "bt_Delete_ModifyPlayer";
            this.bt_Delete_ModifyPlayer.Size = new System.Drawing.Size(151, 35);
            this.bt_Delete_ModifyPlayer.TabIndex = 10;
            this.bt_Delete_ModifyPlayer.Text = "Modify Player";
            this.bt_Delete_ModifyPlayer.UseVisualStyleBackColor = true;
            this.bt_Delete_ModifyPlayer.Click += new System.EventHandler(this.bt_Delete_ModifyPlayer_Click);
            // 
            // DeleteModifyPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Delete_ModifyPlayer);
            this.Name = "DeleteModifyPlayerForm";
            this.Text = "Modify Player";
            this.Load += new System.EventHandler(this.DeleteModifyPlayerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_safe;
        private System.Windows.Forms.RadioButton rdb_injured;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_Delete_ModifyPlayer;
        private System.Windows.Forms.ComboBox cmb_Id;
    }
}