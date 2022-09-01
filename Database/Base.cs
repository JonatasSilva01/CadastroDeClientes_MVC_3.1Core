using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Base
    {
        public IConfiguration DbBase { get; }

        public Base(IConfiguration configuration) 
        {
            DbBase = configuration;
        }

        //public string SqlConn()
        //{
        //   return DbBase.GetConnectionString("DbSqlServerFirst");
        //}

        //public DataTable Lista()
        //{
        //    using (SqlConnection connection = new SqlConnection(SqlConn()))
        //    {
        //        string queryString = "select * from pagina";
        //        SqlCommand command = new SqlCommand(queryString, connection);
        //        command.Connection.Open();

        //        SqlDataAdapter adapter = new SqlDataAdapter(command);
        //        adapter.SelectCommand = command;

        //        DataTable table = new DataTable();
        //        adapter.Fill(table);
        //        return table;
        //    }   
        //}

    }
}
