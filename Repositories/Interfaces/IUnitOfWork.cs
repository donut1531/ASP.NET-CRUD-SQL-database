using System.Data;
using Microsoft.EntityFrameworkCore.Storage;

namespace WebAppAndApi.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        IDbContextTransaction BeginTransaction();
    }
}
