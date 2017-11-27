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
        public List<Response> listResponses = new List<Response>();

        public List<Response> FindResponsesByTopic(int idtopic)
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
            objCommand.CommandText = "SELECT ID_TOPIC, ID_MESSAGE, RESPONSE, USER_LOGIN, DATE_MESSAGE FROM V_FORUM where ID_TOPIC = '" + idtopic + "'" +
                "ORDER BY DATE_MESSAGE DESC";

            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

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


        public void AddResponse(Response resp)
        {
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();

            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            objCommand.Connection = cn;

            objCommand.CommandText = "INSERT INTO MESSAGE (ID_TOPIC, RESPONSE, ID_USER, DATE_MESSAGE)" +
                "VALUES('"+resp.IdTopic+ "','" + resp.ResponseTxt + "'," +
                "'" + resp.IdAuthor + "','" + resp.DateCreation + "')";

            objCommand.ExecuteNonQuery();
        }


        public void DeleteResponse(int idResponse)
        {
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();

            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            objCommand.Connection = cn;

            objCommand.CommandText = "DELETE FROM MESSAGE WHERE ID_MESSAGE = '"+idResponse+"'";

            objCommand.ExecuteNonQuery();
        }


        public void DeleteResponseByIdTopic(int idtopic)
        {
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();

            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            objCommand.Connection = cn;

            objCommand.CommandText = "DELETE FROM MESSAGE WHERE ID_TOPIC = '" + idtopic + "'";

            objCommand.ExecuteNonQuery();
        }


        public void UpdateResponse(Response resp)
        {
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();

            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            //On écrit la requête SQL voulue
            objCommand.Connection = cn;

            objCommand.CommandText = "UPDATE MESSAGE SET RESPONSE = '" + resp.ResponseTxt + "'" +
            "WHERE ID_MESSAGE = '" +resp.IdResponse+ "'";

            objCommand.ExecuteNonQuery();
        }


        public List<Response> FindAllResponses()
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
            objCommand.CommandText = "SELECT ID_MESSAGE, ID_TOPIC, RESPONSE, USER_LOGIN, DATE_MESSAGE FROM V_FORUM";
                

            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

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
