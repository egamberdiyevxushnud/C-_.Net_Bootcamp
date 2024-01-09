using c__20_dars_Json.Servies;
using System.Text.Json;

namespace c__20_dars_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = $"D:\\Json\\Users.json";
            

            Product product = new Product();
            product.Name = "Telefon";
            product.Id = 1;
            product.Description = "128GB";

            IProductRUDS servise = new ProductServise();

            servise.AddProduct(product);

        }
    }
}
 