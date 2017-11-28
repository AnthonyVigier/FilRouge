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
           // cn.Open(); 
            return cn;
        }

        public DataTable ExecuteDataTable(string selectCommand)
        {
            DataTable objDataTable = new DataTable();
            SqlCommand objCommand = new SqlCommand(selectCommand, GetConnection());
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);
            objDataAdapter.Fill(objDataTable);
            return objDataTable;
        }

        public void ExecuteTransactionRequest(string insertCommand)
        {
            cn.Open();
            SqlCommand objCommand = new SqlCommand(insertCommand, GetConnection());
            objCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}

