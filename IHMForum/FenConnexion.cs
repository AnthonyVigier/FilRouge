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
    public partial class FenConnexion : Form
    {
        private Controler objControler;
        internal bool cnModo;
        internal List<UserForum> idrecup;

        public FenConnexion()
        {
            InitializeComponent();
            objControler = new Controler();
        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {
            bool connectionUser = objControler.UserConnection(txtLogin.Text, txtPass.Text);
            cnModo = objControler.UserIsModerator(txtLogin.Text, txtPass.Text);
            idrecup = objControler.GetIdUser(txtLogin.Text);
         
            if (connectionUser)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblConnect.Text = "Identifiants incorrects !";
                txtLogin.Clear();
                txtPass.Clear();
                txtLogin.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FenModifPass modifpass = new FenModifPass())
            {
                modifpass.ShowDialog();
            }
        }
    }
}
