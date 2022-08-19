using System.Data;
using WebAppAndApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace WebAppAndApi.Repositories.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext db;
        public UnitOfWork(ApplicationContext db)
        {
            this.db = db;
        }
        public IDbConnection Open()
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return db.Database.BeginTransaction();
        }
    }
}
