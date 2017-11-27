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
    public partial class FenModifPass : Form
    {
        public FenModifPass()
        {
            InitializeComponent();
        }

        private void stnValiderPass_Click(object sender, EventArgs e)
        {

            UserForum uForum = new UserForum();
            uForum.Pseudo = txtSaisieLogin.Text;
            uForum.UserPass = txtSaisiePass.Text;

            UserDAO uDAO = new UserDAO();
            uDAO.UpdatePassword(uForum);

            MessageBox.Show ("Votre mot de passe à bien été modifié! Veillez le noter : '" + txtSaisiePass.Text + "'",
                             "Modification du mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
 