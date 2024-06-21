
using Web3.Models;

namespace Web3.AppModels
{
    public class App
    {
        public IEnumerable<Product> Products { get; set; }
        public Product NewProduct { get; set; }
    }
}