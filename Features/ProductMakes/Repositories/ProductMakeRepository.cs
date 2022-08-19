using System.Collections.Generic;
using System.Linq;
using WebAppAndApi.Entities;
using WebAppAndApi.Repositories.EfCore; 
using WebAppAndApi.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace WebAppAndApi.Features.ProductMakes.Repositories
{
    public class ProductMakesRepository : IProductMakesRepository
    {
        private readonly ApplicationContext db;

        public ProductMakesRepository(ApplicationContext db)
        {
            this.db = db;
        }
        public List<ProductMake> FindAll()
        {
            return db.ProductMake.ToList();
        }
        public void Add(ProductMake productmake)
        {
           
                db.ProductMake.Add(productmake);
                
            
            
            
            
        }
        public int Update(ProductMake productmake)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ProductMovieCode", SqlDbType.Int) { Value = productmake.ProductMovieCode },
                new SqlParameter("@ProductMovieDes", SqlDbType.VarChar) { Value = productmake.ProductMovieDes }
                
            };

            string sqlString = @"UPDATE Movie
                SET ProductMovieDes = @ProductMovieDes, 
                ProductMovieCode = @ProductMovieCode
                WHERE ProductMovieCode = @ProductMovieCode;";
            return db.Database.ExecuteSqlRaw(sqlString, parameters);
        }

        public int Delete(ProductMake productmake)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ProductMovieCode", SqlDbType.Int) { Value = productmake.ProductMovieCode },
            };
            string sqlString = @"DELETE FROM Movie
                WHERE ProductMovieCode = @ProductMovieCode;"; 
            return db.Database.ExecuteSqlRaw(sqlString, parameters);
        }
    }
}