using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public class UserIDStore : IUserIDStore
    {
        private readonly Database _config;

        public UserIDStore(AHBCFinalProjectConfiguration config)
        {
            _config = config.Database;
        }

        public int getUserId(string email)
        {
            var sql = @"select Id from IdentityUser where Email = '@email'";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.QueryFirstOrDefault<int>(sql, new { Email = email });
                return (result);
            }
        }

 
    }
}
