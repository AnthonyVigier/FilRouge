using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForum
{
    public class UserDAO
    {
        private static UserDAO _Instance;

        private SQLDataBaseConnection _Database;

        private UserDAO()
        {
            _Database = SQLDataBaseConnection.GetInstance();
        }

        public static UserDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new UserDAO();
            return _Instance;
        }


        //Vérifie les informations de connection d'un utilisateur
        public bool UserConnection(string pseudo, string userpass)
        {
            string requete = "SELECT ID_USER, USER_LOGIN, USER_PASSWORD, USER_MAIL, USER_FUNCTION FROM RTFFUSER " +
                "WHERE USER_LOGIN = '" + pseudo + "' AND USER_PASSWORD ='" + userpass + "'";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            if (objDataTable.Rows.Count == 0)
            {
                return false;
            }

            return true;
        }


        //Vérifie si l'utilisateur est modérateur
        public bool UserIsModerator(string pseudo, string userpass)
        {
            string requete = "SELECT ID_USER, USER_LOGIN, USER_PASSWORD, USER_MAIL, USER_FUNCTION FROM RTFFUSER WHERE  USER_LOGIN = '" + pseudo + "' AND USER_PASSWORD ='" + userpass + "' AND USER_FUNCTION ='M'";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            if (objDataTable.Rows.Count == 0)
            {
                return false;
            }

            return true;
        }

        //Retourne l'identifiant de l'utilisateur en fonction du pseudo inscrit
        public List<UserForum> GetIdUser(string pseudo)
        {
            List<UserForum> listeuser = new List<UserForum>();

            string requete = "SELECT ID_USER, USER_LOGIN, USER_PASSWORD, USER_MAIL, USER_FUNCTION FROM RTFFUSER WHERE USER_LOGIN = '" + pseudo + "'";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            foreach (DataRow row in objDataTable.Rows)
            {
                listeuser.Add(new UserForum(Convert.ToInt32(row["ID_USER"])));
            }

            return listeuser;
        }


        //Permet à l'utilasateur de modifier son mot de passe
        public void UpdatePassword(UserForum userForum)
        {
            string requete  = "UPDATE RTFFUSER SET USER_PASSWORD = '" + userForum.UserPass + "'" +
                "WHERE USER_LOGIN = '" + userForum.Pseudo + "'";

            _Database.ExecuteTransactionRequest(requete);
        }


        //Retourne la liste des utilisateurs et leurs informations
        public List<UserForum> GetAllUser()
        {
            List<UserForum> listeuser = new List<UserForum>();

            string requete = "SELECT ID_USER, USER_LOGIN, USER_PASSWORD, USER_MAIL, USER_FUNCTION FROM RTFFUSER";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            foreach (DataRow row in objDataTable.Rows)
            {
                listeuser.Add(new UserForum(Convert.ToInt32(row["ID_USER"]),
                    row["USER_LOGIN"].ToString(),
                    row["USER_PASSWORD"].ToString(),
                    row["USER_MAIL"].ToString(),
                    row["USER_FUNCTION"].ToString()));
            }

            return listeuser;
        }

    }
}
