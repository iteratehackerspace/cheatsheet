using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System.Configuration;

namespace UserTable.Models
{
    public class UserModelBase
    {
        //Uses for SP that doesn't return any data (e.g. Update, Delete) and returns the count of updated rows
        public int Execute<BaseEntity>(string sp_name, DynamicParameters sp_args = null)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServerConnString"].ConnectionString))
            {
                connection.Open();
                return connection.Execute(sp_name, sp_args, commandType: CommandType.StoredProcedure);
            }
        }

        // Uses for SP thar returns data (e.g. Select)
        public IEnumerable<BaseEntity> Query<BaseEntity>(string sp_name, DynamicParameters sp_args = null)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServerConnString"].ConnectionString))
            {
                connection.Open();
                return connection.Query<BaseEntity>(sp_name, sp_args, commandType: CommandType.StoredProcedure);
            }

        }
    }
}