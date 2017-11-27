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

        public bool UserConnection(string pseudo, string userpass)
        {
            //Déclaration des objets que l'on a besoin
            DataTable objDataTable = new DataTable();

            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();


            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            //On écrit la requête SQL voulue
            objCommand.Connection = cn;
            objCommand.CommandText = "SELECT ID_USER, USER_LOGIN, USER_PASSWORD, USER_MAIL, USER_FUNCTION FROM RTFFUSER WHERE USER_LOGIN = '" + pseudo + "' AND USER_PASSWORD ='" + userpass + "'";

            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }




        public bool UserIsModerator(string pseudo, string userpass)
        {
            //Déclaration des objets que l'on a besoin
            DataTable objDataTable = new DataTable();

            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();



            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            //On écrit la requête SQL voulue
            objCommand.Connection = cn;
            objCommand.CommandText = "SELECT ID_USER, USER_LOGIN, USER_PASSWORD, USER_MAIL, USER_FUNCTION FROM RTFFUSER WHERE  USER_LOGIN = '" + pseudo + "' AND USER_PASSWORD ='" + userpass + "' AND USER_FUNCTION ='M'";

            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

            if (objDataTable.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }


        public List<UserForum> GetIdUser(string pseudo)
        {

            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();

            List<UserForum> listeuser = new List<UserForum>();

            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            //On écrit la requête SQL voulue
            objCommand.Connection = cn;
            objCommand.CommandText = "SELECT ID_USER, USER_LOGIN, USER_PASSWORD, USER_MAIL, USER_FUNCTION FROM RTFFUSER WHERE USER_LOGIN = '" + pseudo + "'";
            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

            foreach (DataRow row in objDataTable.Rows)
            {
                listeuser.Add(new UserForum(Convert.ToInt32(row["ID_USER"])));
            }

            return listeuser;
        }

            public void UpdatePassword(UserForum userForum)
            {
                SqlCommand objCommand = new SqlCommand();
                SqlConnection cn = new SqlConnection();

                //On se connecte à la base de données 
                cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
                cn.Open();

                //On écrit la requête SQL voulue
                objCommand.Connection = cn;

                objCommand.CommandText = "UPDATE RTFFUSER SET USER_PASSWORD = '" + userForum.UserPass + "'" +
                "WHERE USER_LOGIN = '" + userForum.Pseudo + "'";

                objCommand.ExecuteNonQuery();

            }



        public List<UserForum> GetAllUser()
        {

            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();

            List<UserForum> listeuser = new List<UserForum>();

            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            //On écrit la requête SQL voulue
            objCommand.Connection = cn;
            objCommand.CommandText = "SELECT ID_USER, USER_LOGIN, USER_PASSWORD, USER_MAIL, USER_FUNCTION FROM RTFFUSER";
            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

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
