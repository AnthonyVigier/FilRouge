using LibraryForum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHMForum
{
    public partial class FenMessages : Form
    {
        public FenMessages()
        {
            InitializeComponent();
        }

        private void btnAjouterMessage_Click(object sender, EventArgs e)
        {
            using (FenAjouterMessage fenajoutmessage = new FenAjouterMessage())
            {
                fenajoutmessage.ShowDialog();
            }
            
        }

        private void btnModifierMessage_Click(object sender, EventArgs e)
        {
            using (FenModifierMessage fenmodifmessage = new FenModifierMessage())
            {
                fenmodifmessage.ShowDialog();
            }
            
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment supprimer ce message","Supprimer message",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);

        }

        private void FenMessages_Load(object sender, EventArgs e)
        {
           
        }
    }
}
