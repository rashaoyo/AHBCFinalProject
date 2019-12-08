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
            var sql = @"select Id from IdentityLogin where Email = @email";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.QueryFirstOrDefault<string>(sql, new { Email = email });
                return int.Parse(result);
            }
        }
    }
}
