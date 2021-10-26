using Catalog.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Produc>> GetProducts();
        Task<Produc> GetProduct(string id);
        Task<IEnumerable<Produc>> GetProductByName(string name);
        Task<IEnumerable<Produc>> GetProductByCategory(string categoryName);

        Task CreateProduct(Produc product);
        Task<bool> UpdateProduct(Produc product);
        Task<bool> DeleteProduct(string id);
    }
}