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
        private static RubricDAO _Instance;

        private SQLDataBaseConnection _Database;

        private RubricDAO()
        {
            _Database = SQLDataBaseConnection.GetInstance();
        }

        public static RubricDAO GetInstance()
        {
            if (_Instance == null)
                _Instance = new RubricDAO();
            return _Instance;
        }

      
        // Revoie une liste de toutes les rubriques
        public List<Rubric> FindAllRubrics()
        {
            List<Rubric> listeRubrics = new List<Rubric>();
         
            string requete = "SELECT ID_RUBRIC, NAME_RUBRIC, DESC_RUBRIC FROM RUBRIC";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            foreach (DataRow row in objDataTable.Rows)
            {
                listeRubrics.Add(new Rubric(Convert.ToInt32(row["ID_RUBRIC"]),row["NAME_RUBRIC"].ToString(), row["DESC_RUBRIC"].ToString()));
            }

            return listeRubrics;
        }

        // Renvoie l'identifiant d'une rubrique en fonction de son nom
        public List<Rubric> GetIdRubric(string namerubric)
        {
            List<Rubric> listIdrubric = new List<Rubric>();

            string requete  = "SELECT ID_RUBRIC FROM V_FORUM WHERE  NAME_RUBRIC = '" + namerubric + "'";

            DataTable objDataTable = _Database.ExecuteDataTable(requete);

            foreach (DataRow row in objDataTable.Rows)
            {
                listIdrubric.Add(new Rubric(Convert.ToInt32(row["ID_RUBRIC"])));
            }

            return listIdrubric;
        }










    }
}
