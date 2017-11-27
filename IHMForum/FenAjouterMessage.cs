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
    public partial class FenAjouterMessage : Form
    {
        public FenAjouterMessage()
        {
            InitializeComponent();
        }

        private void btnCancelMessage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValiderMessage_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
           
        }
    }
}
