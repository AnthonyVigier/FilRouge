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
    public partial class FenAccueil : Form
    {
   
        public FenAccueil()
        {
            InitializeComponent();
        }

        #region FormLoad

        private void FenAccueil_Load(object sender, EventArgs e)
        {
            RubricDAO r = new RubricDAO();

            bindingSourceRubric.DataSource = r.FindAllRubrics();
            cbxRubric.DataSource = bindingSourceRubric;

            TopicDAO t = new TopicDAO();
            bindingSourceTopics.DataSource = t.FindTopicOne();
            dgvTopics.DataSource = bindingSourceTopics;

            pModerateur.Visible = false;
            PUser.Visible = false;
            pAjoutMessage.Visible = false;
            pSuppMessage.Visible = false;
        }

        #endregion


        #region Se Connecter
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            using (FenConnexion fenconnexion = new FenConnexion())
            {
                DialogResult res = fenconnexion.ShowDialog();

                if(res == DialogResult.OK)
                {
                    if (fenconnexion.cnModo)
                    {
                        pModerateur.Visible = true;
                        pSuppMessage.Visible = true; 
                    }

                    btnConnexion.Visible = false; 
                    lblDeconnection.Visible = true;
                    lblUser.Visible = true;
                    PUser.Visible = true;
                    lblUser.Text = fenconnexion.txtLogin.Text;
                    pAjoutMessage.Visible = true;

                    //affiche l'id _user connecté pour le moment
                    cbxid.DataSource = fenconnexion.idrecup;
                    lblID.Text = cbxid.Text;
                }
            }   
        }

        #endregion


        #region Ajouter Un Topic
        private void btnAjouterTopic_Click(object sender, EventArgs e)
        {
            using (FenAjouterTopic fenajouttopic = new FenAjouterTopic())
            {
                DialogResult res = fenajouttopic.ShowDialog();

                if (res == DialogResult.OK)
                {
                    DataGridViewRow row = dgvTopics.CurrentRow;

                    Topic topic = new Topic();
                    UserDAO userDao = new UserDAO();
                    List<UserForum> recup = userDao.GetIdUser(lblUser.Text);

                    topic.IdRubric = Convert.ToInt32(row.Cells[5].Value.ToString());
                    topic.Title = fenajouttopic.txtTitreTopic.Text;
                    topic.Description = fenajouttopic.txtDescTopic.Text;
                    topic.IdAuthor = Convert.ToInt32(lblID.Text);
                    topic.DateCreation = DateTime.Now;

                    TopicDAO tDao = new TopicDAO();
                    tDao.AjouterTopic(topic);
                    DataTable dataTableTopic = tDao.GetIdTopicByTitleTopic(fenajouttopic.txtTitreTopic.Text);
                    int recupId = Convert.ToInt32(dataTableTopic.Rows[0][0].ToString());

                    Response response = new Response();
                    response.IdTopic = recupId;
                    response.ResponseTxt = fenajouttopic.txtAjoutMessage.Text;
                    response.IdAuthor = Convert.ToInt32(lblID.Text);
                    response.DateCreation = DateTime.Now;


                    ResponseDAO responseDAO = new ResponseDAO();
                    responseDAO.AddResponse(response);

                    MessageBox.Show("Topic ajouté avec succès : '" + fenajouttopic.txtTitreTopic.Text + "'",
                     "Topic ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fenajouttopic.Close();
                }
            }

        }

        #endregion


        #region Supprimer un Topic

        private void btnSuppTopic_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous supprimer ce topic ? Cette opération supprimera tous les messages associés à ce topic ", 
            "Supprimer Topic", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(res == DialogResult.Yes)
            {
                DataGridViewRow row = dgvTopics.CurrentRow;
                int recupIdTopic = Convert.ToInt32(row.Cells[0].Value);
 

                Response response = new Response();
                response.IdTopic = recupIdTopic;

                ResponseDAO responseDAO = new ResponseDAO();
                responseDAO.DeleteResponseByIdTopic(response.IdTopic);

                Topic topic = new Topic();
                topic.IdTopic = recupIdTopic;

                TopicDAO topicDAO = new TopicDAO();
                topicDAO.DeleteTopic(topic.IdTopic);

                MessageBox.Show("Topic supprimé", "Suppression effectuée avec succès !");
            }
        }

        #endregion


        #region Topic à afficher en fonction de la rubrique choisie

        private void cbxRubric_SelectedIndexChanged(object sender, EventArgs e)
        {
            TopicDAO t = new TopicDAO();
            bindingSourceTopics.DataSource = t.FindTopicsByRubrics(cbxRubric.Text);
            dgvTopics.DataSource = bindingSourceTopics;
            
        }

        #endregion


        #region Modifier un topic
        private void btnModifTopic_Click(object sender, EventArgs e)
        {
            using (FenModifTopic fenModifTopic = new FenModifTopic())
            {
                DataGridViewRow row = dgvTopics.CurrentRow;
                fenModifTopic.txtTitreTopic.Text = row.Cells[1].Value.ToString();
                fenModifTopic.txtDescTopic.Text = row.Cells[2].Value.ToString();

                DialogResult res = fenModifTopic.ShowDialog();

                if(res == DialogResult.OK)
                {
                    Topic topic = new Topic();

                    topic.IdTopic = Convert.ToInt32(row.Cells[0].Value.ToString());
                    topic.Title = fenModifTopic.txtTitreTopic.Text;
                    topic.Description = fenModifTopic.txtDescTopic.Text;

                    TopicDAO topicDao = new TopicDAO();
                    topicDao.UpdateTopic(topic);

                    MessageBox.Show("Topic modifié avec succès : '"+fenModifTopic.txtTitreTopic.Text+"'",
                        "Topic modifié", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        #endregion


        #region Se déconnecter
        private void lblDeconnection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnConnexion.Visible = true;
            lblUser.Visible = false;
            lblDeconnection.Visible = false;
            PUser.Visible = false;
            pModerateur.Visible = false;
            pSuppMessage.Visible = false;
            pAjoutMessage.Visible = false;
        }

        #endregion


        #region Ajouter un message
        private void btnAjouterMessage_Click(object sender, EventArgs e)
        {
            using (FenAjouterMessage fenajoutMessage = new FenAjouterMessage())
            {

                DataGridViewRow row = dgvTopics.CurrentRow;
                int idTopicRecup = Convert.ToInt32(row.Cells[0].Value);
               
                DialogResult res = fenajoutMessage.ShowDialog();

                if (res == DialogResult.OK)
                {
                    Response response = new Response();
                    response.IdTopic = idTopicRecup;
                    response.ResponseTxt = fenajoutMessage.txtResponse.Text;
                    response.IdAuthor = Convert.ToInt32(lblID.Text);
                    response.DateCreation = DateTime.Now;

                    ResponseDAO responseDAO = new ResponseDAO();
                    responseDAO.AddResponse(response);

                    fenajoutMessage.Close();
                }
            }
        }

        #endregion


        #region Gestion de l'affichege des message en fonction d'un topic sélectionné

        private void dgvTopics_Click(object sender, EventArgs e)
        {
            ResponseDAO res = new ResponseDAO();
            DataGridViewRow row = dgvTopics.CurrentRow;

            bindingSourceMessage.DataSource = res.FindResponsesByTopic(Convert.ToInt32(row.Cells[0].Value.ToString()));
            dgvMessage.DataSource = bindingSourceMessage;
        }

        #endregion 


        #region Supprimer un message
        private void btnDeleteResponse_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous supprimer ce message ?", "Supprimer le message courant",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(res == DialogResult.OK)
            {
                DataGridViewRow currentRow = dgvMessage.CurrentRow;
                int recupIdResponse = Convert.ToInt32(currentRow.Cells[0].Value);

                Response response = new Response();
                response.IdResponse = recupIdResponse;

                ResponseDAO responseDAO = new ResponseDAO();
                responseDAO.DeleteResponse(response.IdResponse);
            }

        }

        #endregion


        #region Modifier un message
        private void btnModifierMessage_Click(object sender, EventArgs e)
        {
            using (FenModifierMessage fenModifMessage = new FenModifierMessage())
            {
                DataGridViewRow row = dgvMessage.CurrentRow;
                fenModifMessage.txtModifMessage.Text = row.Cells[2].Value.ToString();

                DialogResult res = fenModifMessage.ShowDialog();

                if(res == DialogResult.OK)
                {
                    Response response = new Response();

                    response.IdResponse = Convert.ToInt32(row.Cells[0].Value.ToString());
                    response.ResponseTxt = fenModifMessage.txtModifMessage.Text;

                    ResponseDAO respDAO = new ResponseDAO();
                    respDAO.UpdateResponse(response);

                    MessageBox.Show("Message modifié avec succès : '" + fenModifMessage.txtModifMessage.Text + "'",
                      "Message modifié", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        #endregion


        #region Contrôle de modification d'un message
        //Contrôle de modification d'un message
        private void dgvMessage_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMessage.CurrentRow;
            string nomAuteur = row.Cells[3].Value.ToString();

            if (nomAuteur == lblUser.Text)
            {
                btnModifierMessage.Enabled = true;
            }
            else
            {
                btnModifierMessage.Enabled = false;
            }
        }

        #endregion 
    }
}

