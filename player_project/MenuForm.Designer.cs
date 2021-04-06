
namespace player_project
{
    partial class MenuForm
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
            this.bt_AddPlayer = new System.Windows.Forms.Button();
            this.bt_DeletePlayer = new System.Windows.Forms.Button();
            this.bt_ModifyPlayer = new System.Windows.Forms.Button();
            this.bt_ShowPlayers = new System.Windows.Forms.Button();
            this.bt_ExitApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_AddPlayer
            // 
            this.bt_AddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddPlayer.ForeColor = System.Drawing.Color.Blue;
            this.bt_AddPlayer.Location = new System.Drawing.Point(71, 23);
            this.bt_AddPlayer.Name = "bt_AddPlayer";
            this.bt_AddPlayer.Size = new System.Drawing.Size(175, 32);
            this.bt_AddPlayer.TabIndex = 0;
            this.bt_AddPlayer.Text = "Add Player";
            this.bt_AddPlayer.UseVisualStyleBackColor = true;
            this.bt_AddPlayer.Click += new System.EventHandler(this.bt_AddPlayer_Click);
            // 
            // bt_DeletePlayer
            // 
            this.bt_DeletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DeletePlayer.ForeColor = System.Drawing.Color.Blue;
            this.bt_DeletePlayer.Location = new System.Drawing.Point(71, 86);
            this.bt_DeletePlayer.Name = "bt_DeletePlayer";
            this.bt_DeletePlayer.Size = new System.Drawing.Size(175, 37);
            this.bt_DeletePlayer.TabIndex = 1;
            this.bt_DeletePlayer.Text = "Delete Player";
            this.bt_DeletePlayer.UseVisualStyleBackColor = true;
            this.bt_DeletePlayer.Click += new System.EventHandler(this.bt_DeletePlayer_Click);
            // 
            // bt_ModifyPlayer
            // 
            this.bt_ModifyPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ModifyPlayer.ForeColor = System.Drawing.Color.Blue;
            this.bt_ModifyPlayer.Location = new System.Drawing.Point(71, 151);
            this.bt_ModifyPlayer.Name = "bt_ModifyPlayer";
            this.bt_ModifyPlayer.Size = new System.Drawing.Size(175, 37);
            this.bt_ModifyPlayer.TabIndex = 2;
            this.bt_ModifyPlayer.Text = "Modify Player";
            this.bt_ModifyPlayer.UseVisualStyleBackColor = true;
            this.bt_ModifyPlayer.Click += new System.EventHandler(this.bt_ModifyPlayer_Click);
            // 
            // bt_ShowPlayers
            // 
            this.bt_ShowPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ShowPlayers.ForeColor = System.Drawing.Color.Blue;
            this.bt_ShowPlayers.Location = new System.Drawing.Point(71, 225);
            this.bt_ShowPlayers.Name = "bt_ShowPlayers";
            this.bt_ShowPlayers.Size = new System.Drawing.Size(175, 37);
            this.bt_ShowPlayers.TabIndex = 3;
            this.bt_ShowPlayers.Text = "Show Players";
            this.bt_ShowPlayers.UseVisualStyleBackColor = true;
            this.bt_ShowPlayers.Click += new System.EventHandler(this.bt_ShowPlayers_Click);
            // 
            // bt_ExitApplication
            // 
            this.bt_ExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ExitApplication.ForeColor = System.Drawing.Color.Blue;
            this.bt_ExitApplication.Location = new System.Drawing.Point(71, 291);
            this.bt_ExitApplication.Name = "bt_ExitApplication";
            this.bt_ExitApplication.Size = new System.Drawing.Size(175, 37);
            this.bt_ExitApplication.TabIndex = 4;
            this.bt_ExitApplication.Text = "Exit Appliction";
            this.bt_ExitApplication.UseVisualStyleBackColor = true;
            this.bt_ExitApplication.Click += new System.EventHandler(this.bt_ExitApplication_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(324, 344);
            this.Controls.Add(this.bt_ExitApplication);
            this.Controls.Add(this.bt_ShowPlayers);
            this.Controls.Add(this.bt_ModifyPlayer);
            this.Controls.Add(this.bt_DeletePlayer);
            this.Controls.Add(this.bt_AddPlayer);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_AddPlayer;
        private System.Windows.Forms.Button bt_DeletePlayer;
        private System.Windows.Forms.Button bt_ModifyPlayer;
        private System.Windows.Forms.Button bt_ShowPlayers;
        private System.Windows.Forms.Button bt_ExitApplication;
    }
}