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
        internal bool cnModo;
        internal List<UserForum> idrecup;

        public FenConnexion()
        {
            InitializeComponent();
        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {
            UserDAO authentificationUser = new UserDAO();
           
            bool connectionUser = authentificationUser.UserConnection(txtLogin.Text, txtPass.Text);
            cnModo = authentificationUser.UserIsModerator(txtLogin.Text, txtPass.Text);
            idrecup = authentificationUser.GetIdUser(txtLogin.Text);
         

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
