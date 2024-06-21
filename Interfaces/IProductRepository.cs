using System.Collections.Generic;
using System.Threading.Tasks;
using Web3.Models;

namespace Web3.Interfaces
{
    public interface IProductRepository
    {
        // this is an interface to get all products
        Task<IEnumerable<Product>> GetAllProducts();

        Task AddProduct(Product product);

        Task DeleteProduct(int id);
    }
}