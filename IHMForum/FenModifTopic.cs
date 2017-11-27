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
    public partial class FenModifTopic : Form
    {
        public FenModifTopic()
        {
            InitializeComponent();
        }

        private void btnValiderTopic_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
