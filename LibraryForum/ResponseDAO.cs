using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForum
{
    public class ResponseDAO
    {
        private static ResponseDAO _Instance;

        private SQLDataBaseConnection _Database;

        private ResponseDAO()
        {
            _Database = SQLDataBaseConnection.GetInstance();
        }

        public static ResponseDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new ResponseDAO();
            return _Instance;
        }

      
        //Renvoie toutes les reponses en fonction d'un topic sélectionné
        public List<Response> FindResponsesByTopic(int idtopic)
        {
            List<Response> listResponses = new List<Response>();

            string requete  = "SELECT ID_TOPIC, ID_MESSAGE, RESPONSE, USER_LOGIN, DATE_MESSAGE FROM V_FORUM where ID_TOPIC = '" + idtopic + "'" +
               "ORDER BY DATE_MESSAGE DESC";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            foreach (DataRow row in objDataTable.Rows)
            {
                listResponses.Add(new Response(Convert.ToInt32(row["ID_MESSAGE"]), 
                    Convert.ToInt32(row["ID_TOPIC"]),
                    row["RESPONSE"].ToString(),
                    row["USER_LOGIN"].ToString(),
                    Convert.ToDateTime(row["DATE_MESSAGE"])));
            }

            return listResponses;
        }

        //Ajouter une réponse
        public void AddResponse(Response resp)
        {   
            string requete = "INSERT INTO MESSAGE (ID_TOPIC, RESPONSE, ID_USER, DATE_MESSAGE)" +
                "VALUES('"+resp.IdTopic+ "','" + resp.ResponseTxt + "'," +
                "'" + resp.IdAuthor + "','" + resp.DateCreation + "')";

            _Database.ExecuteTransactionRequest(requete);
        }

        //Supprimer une réponse
        public void DeleteResponse(int idResponse)
        {
           string requete = "DELETE FROM MESSAGE WHERE ID_MESSAGE = '"+idResponse+"'";

           _Database.ExecuteTransactionRequest(requete);
        }

        //Suprime toutes les réponse d'un topic à supprimé, qui est sélectionné
        public void DeleteResponseByIdTopic(int idtopic)
        {
            string requete = "DELETE FROM MESSAGE WHERE ID_TOPIC = '" + idtopic + "'";

            _Database.ExecuteTransactionRequest(requete);
        }

        //Modifier une réponse
        public void UpdateResponse(Response resp)
        {
            string requete = "UPDATE MESSAGE SET RESPONSE = '" + resp.ResponseTxt + "'" +
            "WHERE ID_MESSAGE = '" +resp.IdResponse+ "'";

            _Database.ExecuteTransactionRequest(requete);
        }

        //Revoie toutes les réponses. A revoir si besoin
        public List<Response> FindAllResponses()
        {
            List<Response> listResponses = new List<Response>();

            string requete = "SELECT ID_MESSAGE, ID_TOPIC, RESPONSE, USER_LOGIN, DATE_MESSAGE FROM V_FORUM";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            foreach (DataRow row in objDataTable.Rows)
            {
                listResponses.Add(new Response(Convert.ToInt32(row["ID_MESSAGE"]),
                    Convert.ToInt32(row["ID_TOPIC"]),
                    row["RESPONSE"].ToString(),
                    row["USER_LOGIN"].ToString(),
                    Convert.ToDateTime(row["DATE_MESSAGE"])));
            }

            return listResponses;
        }

    }
}
