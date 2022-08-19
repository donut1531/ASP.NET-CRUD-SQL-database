using System;
using System.Data;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using WebAppAndApi.Repositories.Interfaces;

namespace WebAppAndApi.Repositories.Dapper
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IConfiguration configuration;

        public UnitOfWork(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IDbContextTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public IDbConnection Open()
        {
            var conn = new MySqlConnection(configuration.GetConnectionString("ApplicationConnection"));
            conn.Open();
            return conn;
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
