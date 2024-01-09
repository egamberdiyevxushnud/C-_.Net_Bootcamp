using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace c__20_dars_Json.Servies
{
    public class ProductServise : IProductRUDS
    {
        string path = $"D:\\Json\\Users.json";
        public void AddProduct(Product product)
        {
            var products = ReadAllProduct();

           var ids = products.Select(x => x.Id);

            if (ids.Contains(product.Id))
            {
                return;
            }   

            products.Add(product);
            WriteAllOroduct(products);

        }

        private void WriteAllOroduct(List<Product> product)
        {
            var jsonData = JsonSerializer.Serialize(product);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(jsonData);
            }
        }

        public void DeleteProduct( int id)
        {
            var products = ReadAllProduct();

            var product =  products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return;
            }
            products.Remove(product);
            WriteAllOroduct(products);
        }

        private List<Product> ReadAllProduct()
        {
            string jsondata;
            using (StreamReader reader = new StreamReader(path))
            {
                 jsondata =  reader.ReadToEnd();
            }
            List<Product> productList;
            try
            {
                 productList = JsonSerializer.Deserialize<List<Product>>(jsondata);
            }
            catch
            {
                return new List<Product>();
            }
            return productList;
        }

    }
}
