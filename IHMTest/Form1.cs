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

namespace IHMTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TopicDAO  r = new TopicDAO();
            dgvRubric.DataSource = r.FindTopicOne();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TopicDAO t = new TopicDAO();
            
            dgvRubric.DataSource = t.FindTopicsByRubrics(cbxRubric.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RubricDAO r = new RubricDAO();
            cbxRubric.DisplayMember = "NAME_RUBRIC";
            cbxRubric.ValueMember = "Name_rubric";
            bindingSourceRubric.DataSource = r.FindAllRubrics();
            cbxRubric.DataSource = bindingSourceRubric;
        }

        private void dgvRubric_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            UserDAO user1 = new UserDAO();

            bool c = user1.UserConnection(txtLogin.Text, txtPass.Text);

                if (c == true)
                {
                lblconnect.Text = "Connecté ! ";

                bool m = user1.UserIsModerator();

                if (m == true)
                {
                    lblModo.Text = "Âccès au panneau de modération";
                }
                else
                {
                    lblModo.Text = "Accès au panneau d'utilisation standard";
                }

            }

            else
             {
                lblconnect.Text = "Veuillez saisir des identifiants valides";
                    
             }

           


        }
    }
}
