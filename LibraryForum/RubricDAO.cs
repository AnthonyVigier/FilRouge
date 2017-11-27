using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForum
{
    public class RubricDAO

    {

        public List<Rubric> listeRubrics = new List<Rubric>();

        public List<Rubric> FindAllRubrics()
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
            objCommand.CommandText = "SELECT ID_RUBRIC, NAME_RUBRIC, DESC_RUBRIC FROM RUBRIC";

            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

            foreach (DataRow row in objDataTable.Rows)
            {
                listeRubrics.Add(new Rubric(Convert.ToInt32(row["ID_RUBRIC"]),row["NAME_RUBRIC"].ToString(), row["DESC_RUBRIC"].ToString()));
            }

            return listeRubrics;
        }


        public List<Rubric> GetIdRubric(string namerubric)
        {

            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand();
            SqlConnection cn = new SqlConnection();

            List<Rubric> listIdrubric = new List<Rubric>();

            //On se connecte à la base de données 
            cn.ConnectionString = ("Data Source = 176.31.248.137; Initial Catalog = user07; Persist Security Info=True;User ID = user07; Password=753user07");
            cn.Open();

            //On écrit la requête SQL voulue
            objCommand.Connection = cn;
            objCommand.CommandText = "SELECT ID_RUBRIC FROM V_FORUM WHERE  NAME_RUBRIC = '" + namerubric + "'";
            objDataAdapter.SelectCommand = objCommand;
            objDataAdapter.Fill(objDataTable);

            foreach (DataRow row in objDataTable.Rows)
            {
                listIdrubric.Add(new Rubric(Convert.ToInt32(row["ID_RUBRIC"])));
            }

            return listIdrubric;
        }










    }
}
