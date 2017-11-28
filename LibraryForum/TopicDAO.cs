using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForum
{
    public class TopicDAO
    {
        private static TopicDAO _Instance;

        private SQLDataBaseConnection _Database;

        //TODO à mettre private c'est un Singleton et son constructeur doit être private 
        //Ajouter une classe controleur qui encapsulera toutes les méthodes DAO

        public TopicDAO()
        {
            _Database = SQLDataBaseConnection.GetInstance();
        }

        public static TopicDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new TopicDAO();
            return _Instance;
        }

        //private Topic topic { get; set; }

       
        //Permet d'afficher le premier topic dans le datagridview des topics à l'ouverture de l'application
        public List<Topic> FindTopicOne()
        {
            List<Topic> listeTopics = new List<Topic>();
           
            string requete = "SELECT ID_TOPIC, ID_RUBRIC, DESC_TOPIC, TITLE_TOPIC, USER_LOGIN, DATE_CREATION FROM v_forum WHERE ID_RUBRIC = 1";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            foreach (DataRow row in objDataTable.Rows)
            {
                listeTopics.Add(new Topic(Convert.ToInt32(row["ID_TOPIC"]),
                    Convert.ToInt32(row["ID_RUBRIC"]),
                    row["TITLE_TOPIC"].ToString(),
                    row["USER_LOGIN"].ToString(),
                    row["DESC_TOPIC"].ToString(),
                    Convert.ToDateTime(row["DATE_CREATION"])));
            }
            return listeTopics;
        }

        //Permet d'afficher tous les topics de la rubrique choisie
        public List<Topic> FindTopicsByRubrics(string NameRubric)
        {
            List<Topic> listeTopics = new List<Topic>();

            string requete = "SELECT ID_TOPIC, ID_RUBRIC, DESC_TOPIC, TITLE_TOPIC, USER_LOGIN, DATE_CREATION FROM V_UserRubricTopic where NAME_RUBRIC = '" + NameRubric + "'";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            foreach (DataRow row in objDataTable.Rows)
            {
                listeTopics.Add(new Topic(Convert.ToInt32(row["ID_TOPIC"]),
                      Convert.ToInt32(row["ID_RUBRIC"]),
                      row["TITLE_TOPIC"].ToString(),
                      row["USER_LOGIN"].ToString(),
                      row["DESC_TOPIC"].ToString(),
                      Convert.ToDateTime(row["DATE_CREATION"])));
            }

            return listeTopics;
        }


        //Retourne l'identifiant du topic selectionné
        public List<Topic> GetIdTopic(int idtopic)
        {
           
            List<Topic> listIdtopic = new List<Topic>();

            string requete = "SELECT ID_TOPIC FROM V_FORUM WHERE  ID_TOPIC = '" + idtopic + "'";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);
           
            foreach (DataRow row in objDataTable.Rows)
            {
                listIdtopic.Add(new Topic(Convert.ToInt32(row["ID_TOPIC"])));
            }

            return listIdtopic;
        }


        public void UpdateTopic(Topic topic)
        {
           string requete = "UPDATE TOPIC SET TITLE_TOPIC = '" + topic.Title + "', DESC_TOPIC = '" + topic.Description + "'" +
                "WHERE ID_TOPIC ='"+topic.IdTopic+"'";

            _Database.ExecuteTransactionRequest(requete);
        }

        //Permet d'ajouter un Topic 
        public void AjouterTopic(Topic topic)
        {
            string requete = "INSERT INTO TOPIC (ID_RUBRIC, TITLE_TOPIC, DESC_TOPIC, ID_USER, DATE_CREATION) " +
                "VALUES('" + topic.IdRubric + "','" + topic.Title + "','" + topic.Description + "'," +
                "'" + topic.IdAuthor+ "','" + topic.DateCreation + "')";

            _Database.ExecuteTransactionRequest(requete);
        }

        //Permet de supprimer le topic sélectionné
        public void DeleteTopic(int idtopic)
        {
         string requete = "DELETE FROM TOPIC WHERE ID_TOPIC = '" + idtopic + "'";

            _Database.ExecuteTransactionRequest(requete);
        }


        //TODO à revoir si besoin
        //Donne l'id d'un topic en fonction de son titre 
        public DataTable GetIdTopicByTitleTopic(string nametopic)
        {
            string requete = "SELECT ID_TOPIC, TITLE_TOPIC from TOPIC where TITLE_TOPIC ='"+ nametopic +"'";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            return objDataTable;
        }


        //Permet d'avoir les topics sans les messages pour éviter les doublons : utilisation d'une vue adaptée au besoin
        public List<Topic> FindAllTopics()
        {
            List<Topic> listtopic = new List<Topic>();

            string requete = "SELECT ID_TOPIC, ID_RUBRIC, TITLE_TOPIC, USER_LOGIN, DESC_TOPIC, DATE_CREATION FROM V_FORUM";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            foreach (DataRow row in objDataTable.Rows)
            {
                listtopic.Add(new Topic(Convert.ToInt32(row["ID_TOPIC"]),
                      Convert.ToInt32(row["ID_RUBRIC"]),
                      row["TITLE_TOPIC"].ToString(),
                      row["USER_LOGIN"].ToString(),
                      row["DESC_TOPIC"].ToString(),
                      Convert.ToDateTime(row["DATE_CREATION"])));
            }
            return listtopic;
        }

    }

}
