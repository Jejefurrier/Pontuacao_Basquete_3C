using Microsoft.Extensions.Configuration;
using Pontuacao_Basquete_DataAcess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Pontuacao_Basquete_DataAcess.Connection
{
    public class DefaultSqlConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public DefaultSqlConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection Connection()
        {
            var connectionString = GetConnection();

            return new SqlConnection(connectionString);
        }

        private string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("JogoBasqueteConnection").Value;

            return connection;
        }
    }
}
