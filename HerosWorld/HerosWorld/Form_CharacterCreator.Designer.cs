namespace HerosWorld
{
    partial class Form_CharacterCreator
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
            this.Lbl_CharacterName = new System.Windows.Forms.Label();
            this.Txt_CharacterName = new System.Windows.Forms.TextBox();
            this.Grp_Gender = new System.Windows.Forms.GroupBox();
            this.Rdo_GenderFemale = new System.Windows.Forms.RadioButton();
            this.Rdo_GenderMale = new System.Windows.Forms.RadioButton();
            this.Cmbo_CharacterRace = new System.Windows.Forms.ComboBox();
            this.Lbl_CharacterRace = new System.Windows.Forms.Label();
            this.Btn_SaveHero = new System.Windows.Forms.Button();
            this.Grp_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CharacterName
            // 
            this.Lbl_CharacterName.AutoSize = true;
            this.Lbl_CharacterName.Location = new System.Drawing.Point(12, 42);
            this.Lbl_CharacterName.Name = "Lbl_CharacterName";
            this.Lbl_CharacterName.Size = new System.Drawing.Size(90, 17);
            this.Lbl_CharacterName.TabIndex = 0;
            this.Lbl_CharacterName.Text = "Hero\'s Name";
            // 
            // Txt_CharacterName
            // 
            this.Txt_CharacterName.Location = new System.Drawing.Point(108, 42);
            this.Txt_CharacterName.Name = "Txt_CharacterName";
            this.Txt_CharacterName.Size = new System.Drawing.Size(217, 22);
            this.Txt_CharacterName.TabIndex = 1;
            // 
            // Grp_Gender
            // 
            this.Grp_Gender.Controls.Add(this.Rdo_GenderFemale);
            this.Grp_Gender.Controls.Add(this.Rdo_GenderMale);
            this.Grp_Gender.Location = new System.Drawing.Point(15, 89);
            this.Grp_Gender.Name = "Grp_Gender";
            this.Grp_Gender.Size = new System.Drawing.Size(310, 54);
            this.Grp_Gender.TabIndex = 2;
            this.Grp_Gender.TabStop = false;
            this.Grp_Gender.Text = "Gender";
            this.Grp_Gender.Enter += new System.EventHandler(this.Grp_Gender_Enter);
            // 
            // Rdo_GenderFemale
            // 
            this.Rdo_GenderFemale.AutoSize = true;
            this.Rdo_GenderFemale.Location = new System.Drawing.Point(111, 22);
            this.Rdo_GenderFemale.Name = "Rdo_GenderFemale";
            this.Rdo_GenderFemale.Size = new System.Drawing.Size(75, 21);
            this.Rdo_GenderFemale.TabIndex = 1;
            this.Rdo_GenderFemale.TabStop = true;
            this.Rdo_GenderFemale.Text = "Female";
            this.Rdo_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // Rdo_GenderMale
            // 
            this.Rdo_GenderMale.AutoSize = true;
            this.Rdo_GenderMale.Location = new System.Drawing.Point(7, 22);
            this.Rdo_GenderMale.Name = "Rdo_GenderMale";
            this.Rdo_GenderMale.Size = new System.Drawing.Size(59, 21);
            this.Rdo_GenderMale.TabIndex = 0;
            this.Rdo_GenderMale.TabStop = true;
            this.Rdo_GenderMale.Text = "Male";
            this.Rdo_GenderMale.UseVisualStyleBackColor = true;
            // 
            // Cmbo_CharacterRace
            // 
            this.Cmbo_CharacterRace.FormattingEnabled = true;
            this.Cmbo_CharacterRace.Items.AddRange(new object[] {
            "Warrior",
            "Elf",
            "Dwarf",
            "Hobbit",
            "Mage",
            "Thief"});
            this.Cmbo_CharacterRace.Location = new System.Drawing.Point(15, 192);
            this.Cmbo_CharacterRace.Name = "Cmbo_CharacterRace";
            this.Cmbo_CharacterRace.Size = new System.Drawing.Size(310, 24);
            this.Cmbo_CharacterRace.TabIndex = 3;
            // 
            // Lbl_CharacterRace
            // 
            this.Lbl_CharacterRace.AutoSize = true;
            this.Lbl_CharacterRace.Location = new System.Drawing.Point(15, 169);
            this.Lbl_CharacterRace.Name = "Lbl_CharacterRace";
            this.Lbl_CharacterRace.Size = new System.Drawing.Size(87, 17);
            this.Lbl_CharacterRace.TabIndex = 4;
            this.Lbl_CharacterRace.Text = "Hero\'s Class";
            // 
            // Btn_SaveHero
            // 
            this.Btn_SaveHero.Location = new System.Drawing.Point(15, 259);
            this.Btn_SaveHero.Name = "Btn_SaveHero";
            this.Btn_SaveHero.Size = new System.Drawing.Size(136, 62);
            this.Btn_SaveHero.TabIndex = 5;
            this.Btn_SaveHero.Text = "Save Hero";
            this.Btn_SaveHero.UseVisualStyleBackColor = true;
            this.Btn_SaveHero.Click += new System.EventHandler(this.Btn_SaveHero_Click);
            // 
            // Form_CharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 329);
            this.Controls.Add(this.Btn_SaveHero);
            this.Controls.Add(this.Lbl_CharacterRace);
            this.Controls.Add(this.Cmbo_CharacterRace);
            this.Controls.Add(this.Grp_Gender);
            this.Controls.Add(this.Txt_CharacterName);
            this.Controls.Add(this.Lbl_CharacterName);
            this.Name = "Form_CharacterCreator";
            this.ShowIcon = false;
            this.Text = "Create your Hero\'s World Character ";
            this.Load += new System.EventHandler(this.Form_CharacterCreator_Load);
            this.Grp_Gender.ResumeLayout(false);
            this.Grp_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CharacterName;
        private System.Windows.Forms.TextBox Txt_CharacterName;
        private System.Windows.Forms.GroupBox Grp_Gender;
        private System.Windows.Forms.RadioButton Rdo_GenderFemale;
        private System.Windows.Forms.RadioButton Rdo_GenderMale;
        private System.Windows.Forms.ComboBox Cmbo_CharacterRace;
        private System.Windows.Forms.Label Lbl_CharacterRace;
        private System.Windows.Forms.Button Btn_SaveHero;
    }
}