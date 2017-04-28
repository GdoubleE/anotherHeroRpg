using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerosWorld.CharacterClasses;

namespace HerosWorld
{
    public partial class Form_CharacterCreator : Form
    {
        public Form_CharacterCreator()
        {
            InitializeComponent();
        }

        private void Form_CharacterCreator_Load(object sender, EventArgs e)
        {

        }
        private void Grp_Gender_Enter(object sender, EventArgs e)
        {

        }
        private void Btn_SaveHero_Click(object sender, EventArgs e)
        { 
            if (String.IsNullOrEmpty(Txt_CharacterName.Text) || Txt_CharacterName.Text[0] == ' ')
            {
                MessageBox.Show("You Must Give Your Hero A Name");
                return;
            }
            if (!this.Rdo_GenderMale.Checked && !this.Rdo_GenderFemale.Checked)
            {
                MessageBox.Show("Choose a Gender for your Hero");
                return;
            }

            EntityGender eGender;
            if (this.Rdo_GenderMale.Checked)
                eGender = EntityGender.Male;
            else
                eGender = EntityGender.Female;

            string name = this.Txt_CharacterName.Text;

            EntityClass eClass;
            if (this.Cmbo_CharacterRace.Text == "Mage")
                eClass = EntityClass.Mage;
            else if (this.Cmbo_CharacterRace.Text == "Warrior")
                eClass = EntityClass.Warrior;
            else if (this.Cmbo_CharacterRace.Text == "Dwarf")
                eClass = EntityClass.Dwarf;
            else if (this.Cmbo_CharacterRace.Text == "Elf")
                eClass = EntityClass.Elf;
            else
            {
                MessageBox.Show("Choose a Race");
                return;
            }
            //create the hero
            Player player1 = new Player(name, eGender, eClass);


            //string EClass()
            //{
            //    var eClass = Enum.GetNames(typeof(EntityClass));
            //    for (int i = 0; i <= eClass.Length; i++)
            //    {
            //        eClass[i] = this.Cmbo_CharacterRace.Text;
            //    }
            //}









        }


    }
}
