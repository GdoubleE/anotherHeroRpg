using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerosWorld
{
    public partial class EntryScreen : Form
    {
        public EntryScreen()
        {
            InitializeComponent();
        }

        private void Btn_CreateCharacter_Click(object sender, EventArgs e)
        {
            Form_CharacterCreator charCreator = new Form_CharacterCreator();
            charCreator.Show();
        }
    }
}
