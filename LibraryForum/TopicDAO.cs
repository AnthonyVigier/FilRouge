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
        private Topic topic { get; set; }

        private List<Topic> listeTopics = new List<Topic>();

        public List<Topic> FindTopicOne()
        {
            //Déclaration des objets que l'on a besoin
            DataTable objDataTable = new DataTable();

            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();


            //On se connecte à la base de données 
            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            //On écrit la requête SQL voulue
            objCommand.Connection = cn;
            objCommand.CommandText = "SELECT ID_TOPIC, ID_RUBRIC, DESC_TOPIC, TITLE_TOPIC, USER_LOGIN, DATE_CREATION FROM v_forum WHERE ID_RUBRIC = 1";

            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

            foreach (DataRow row in objDataTable.Rows)
            {
                listeTopics.Add(new Topic(Convert.ToInt32(row["ID_TOPIC"]),
                    Convert.ToInt32(row["ID_RUBRIC"]),
                    row["TITLE_TOPIC"].ToString(),
                    row["USER_LOGIN"].ToString(),
                    row["DESC_TOPIC"].ToString(),
                    Convert.ToDateTime(row["DATE_CREATION"])));
            }

            cn.Close();

            return listeTopics;
        }

        public List<Topic> FindTopicsByRubrics(string NameRubric)
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
            objCommand.CommandText = "SELECT ID_TOPIC, ID_RUBRIC, DESC_TOPIC, TITLE_TOPIC, USER_LOGIN, DATE_CREATION FROM V_UserRubricTopic where NAME_RUBRIC = '" + NameRubric + "'";

            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

            foreach (DataRow row in objDataTable.Rows)
            {
                listeTopics.Add(new Topic(Convert.ToInt32(row["ID_TOPIC"]),
                      Convert.ToInt32(row["ID_RUBRIC"]),
                      row["TITLE_TOPIC"].ToString(),
                      row["USER_LOGIN"].ToString(),
                      row["DESC_TOPIC"].ToString(),
                      Convert.ToDateTime(row["DATE_CREATION"])));
            }

            cn.Close();
            return listeTopics;
        }




        public List<Topic> GetIdTopic(int idtopic)
        {
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();

            List<Topic> listIdtopic = new List<Topic>();

            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            //On écrit la requête SQL voulue
            objCommand.Connection = cn;
            objCommand.CommandText = "SELECT ID_TOPIC FROM V_FORUM WHERE  ID_TOPIC = '" + idtopic + "'";
            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

            foreach (DataRow row in objDataTable.Rows)
            {
                listIdtopic.Add(new Topic(Convert.ToInt32(row["ID_TOPIC"])));
            }
            return listIdtopic;
        }


        public void UpdateTopic(Topic topic)
        {
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();
            objCommand.Connection = cn;

            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();
            objCommand.CommandText = "UPDATE TOPIC SET TITLE_TOPIC = '" + topic.Title + "', DESC_TOPIC = '" + topic.Description + "'" +
                "WHERE ID_TOPIC ='"+topic.IdTopic+"'";

            objCommand.ExecuteNonQuery();
        }


        public void AjouterTopic(Topic topic)
        {
            //On se connecte à la base de données 
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            SqlCommand objCommand = new SqlCommand();

            objCommand.Connection = cn;
            objCommand.CommandText = "INSERT INTO TOPIC (ID_RUBRIC, TITLE_TOPIC, DESC_TOPIC, ID_USER, DATE_CREATION) " +
                "VALUES('" + topic.IdRubric + "','" + topic.Title + "','" + topic.Description + "'," +
                "'" + topic.IdAuthor+ "','" + topic.DateCreation + "')";

            objCommand.ExecuteNonQuery();

        }

        public void DeleteTopic(int idtopic)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            SqlCommand objCommand = new SqlCommand();

            objCommand.Connection = cn;
            objCommand.CommandText = "DELETE FROM TOPIC WHERE ID_TOPIC = '" + idtopic + "'";
            objCommand.ExecuteNonQuery();
        }


        public DataTable GetIdTopicByTitleTopic(string nametopic)
        {
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();


            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            //On écrit la requête SQL voulue
            objCommand.Connection = cn;
            objCommand.CommandText = "SELECT ID_TOPIC, TITLE_TOPIC from TOPIC where TITLE_TOPIC ='"+ nametopic +"'";
            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

          
            return objDataTable;
        }


        public List<Topic> FindAllTopics()
        {
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();

            List<Topic> listtopic = new List<Topic>();

            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            //On écrit la requête SQL voulue
            objCommand.Connection = cn;
            objCommand.CommandText = "SELECT ID_TOPIC, ID_RUBRIC, TITLE_TOPIC, USER_LOGIN, DESC_TOPIC, DATE_CREATION FROM V_FORUM";
            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

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
