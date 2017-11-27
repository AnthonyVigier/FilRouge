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
    public partial class FenAjouterTopic : Form
    {
        public FenAjouterTopic()
        {
            InitializeComponent();
        }

        private void btnCancelTopic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValiderTopic_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
          
        }
    }
}
