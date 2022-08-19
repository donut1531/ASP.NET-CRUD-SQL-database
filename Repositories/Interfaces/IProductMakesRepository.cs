using System.Collections.Generic;
using WebAppAndApi.Entities;

namespace WebAppAndApi.Repositories.Interfaces
{
    public interface IProductMakesRepository
    {
        List<ProductMake> FindAll();
        void Add(ProductMake productmake);
        int Update(ProductMake productmake);
        int Delete(ProductMake productmake);
    }
}