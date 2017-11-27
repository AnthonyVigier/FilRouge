using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibraryForum
{
    class SQLDataBaseConnection
    {
        //Properties
        private static SQLDataBaseConnection _Instance;
        private SqlConnection cn;

        //ctor
        private SQLDataBaseConnection()
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=176.31.248.137;Initial Catalog=user07;Persist Security Info=True;User ID=user07;Password=753user07";
            cn.Open();
        }


        //Methods
        public static SQLDataBaseConnection GetInstance()
        {
            if (_Instance == null)
                _Instance = new SQLDataBaseConnection();
            return _Instance;
        }

        private SqlConnection GetConnection()
        {
            //Pour lire la chaine de connexion dans le fichier App.config, le projet a besoin d'une référence sur System.Configuration

            //cn.Open(); //En mode déconnecté, le système ouvre la connexion, si elle n'est pas ouverte 
            return cn;
        }





    }
}
;
