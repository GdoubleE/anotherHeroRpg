namespace HerosWorld
{
    partial class EntryScreen
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
            this.Btn_CreateCharacter = new System.Windows.Forms.Button();
            this.Lbl_GameTitle = new System.Windows.Forms.Label();
            this.Btn_LoadGame = new System.Windows.Forms.Button();
            this.Btn_Options = new System.Windows.Forms.Button();
            this.Btn_GetStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_CreateCharacter
            // 
            this.Btn_CreateCharacter.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreateCharacter.Location = new System.Drawing.Point(52, 103);
            this.Btn_CreateCharacter.Name = "Btn_CreateCharacter";
            this.Btn_CreateCharacter.Size = new System.Drawing.Size(149, 57);
            this.Btn_CreateCharacter.TabIndex = 0;
            this.Btn_CreateCharacter.Text = "Create Hero";
            this.Btn_CreateCharacter.UseVisualStyleBackColor = true;
            this.Btn_CreateCharacter.Click += new System.EventHandler(this.Btn_CreateCharacter_Click);
            // 
            // Lbl_GameTitle
            // 
            this.Lbl_GameTitle.AutoSize = true;
            this.Lbl_GameTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GameTitle.Location = new System.Drawing.Point(132, 9);
            this.Lbl_GameTitle.Name = "Lbl_GameTitle";
            this.Lbl_GameTitle.Size = new System.Drawing.Size(263, 36);
            this.Lbl_GameTitle.TabIndex = 1;
            this.Lbl_GameTitle.Text = "Hero\'s World";
            // 
            // Btn_LoadGame
            // 
            this.Btn_LoadGame.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LoadGame.Location = new System.Drawing.Point(320, 103);
            this.Btn_LoadGame.Name = "Btn_LoadGame";
            this.Btn_LoadGame.Size = new System.Drawing.Size(149, 57);
            this.Btn_LoadGame.TabIndex = 2;
            this.Btn_LoadGame.Text = "Load Game";
            this.Btn_LoadGame.UseVisualStyleBackColor = true;
            // 
            // Btn_Options
            // 
            this.Btn_Options.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Options.Location = new System.Drawing.Point(320, 198);
            this.Btn_Options.Name = "Btn_Options";
            this.Btn_Options.Size = new System.Drawing.Size(149, 57);
            this.Btn_Options.TabIndex = 3;
            this.Btn_Options.Text = "Options";
            this.Btn_Options.UseVisualStyleBackColor = true;
            // 
            // Btn_GetStats
            // 
            this.Btn_GetStats.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GetStats.Location = new System.Drawing.Point(52, 198);
            this.Btn_GetStats.Name = "Btn_GetStats";
            this.Btn_GetStats.Size = new System.Drawing.Size(149, 57);
            this.Btn_GetStats.TabIndex = 4;
            this.Btn_GetStats.Text = "Get Stats";
            this.Btn_GetStats.UseVisualStyleBackColor = true;
            // 
            // EntryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 502);
            this.Controls.Add(this.Btn_GetStats);
            this.Controls.Add(this.Btn_Options);
            this.Controls.Add(this.Btn_LoadGame);
            this.Controls.Add(this.Lbl_GameTitle);
            this.Controls.Add(this.Btn_CreateCharacter);
            this.Name = "EntryScreen";
            this.Text = "Hero\'s World Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CreateCharacter;
        private System.Windows.Forms.Label Lbl_GameTitle;
        private System.Windows.Forms.Button Btn_LoadGame;
        private System.Windows.Forms.Button Btn_Options;
        private System.Windows.Forms.Button Btn_GetStats;
    }
}

