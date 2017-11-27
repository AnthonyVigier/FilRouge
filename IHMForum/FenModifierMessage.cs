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
    public partial class FenModifierMessage : Form
    {
        public FenModifierMessage()
        {
            InitializeComponent();
        }

        private void btnCancelModifMessage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValiderModifMessage_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
