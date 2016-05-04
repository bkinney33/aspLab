using SportsStore.Abstract;
using SportsStore.Entities;
using System.Collections.Generic;
namespace SportsStore.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
    }
}