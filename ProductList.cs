using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShopApp
{
    public class ProductList : IBaseOperations<Product>
    {
        public List<Product> Products
        { 
            get;
            set; 
        }
        private string Root
        {
            get;
            set;
        }
        public List<Product> GetData() {
            string Json = File.ReadAllText(Root);
            return JsonConvert.DeserializeObject<List<Product>>(Json);
        }
        public ProductList()
        {
            Products = new List<Product>();
            var RootPath = ConfigurationManager.AppSettings["Products"];
            string FileName = "Products.json";
            if (string.IsNullOrEmpty(RootPath))
            {
                RootPath = "Products";
            }
            if (!Directory.Exists(RootPath)) Directory.CreateDirectory(RootPath);
            if (!File.Exists(Path.Combine(RootPath, FileName))) File.Create(Path.Combine(RootPath, FileName)).Close();
            Root = Path.Combine(RootPath, FileName);

        }

        public void Add(Product U)
        {
            string Json = File.ReadAllText(Root);
            if (String.IsNullOrEmpty(Json))
            {
                Products.Add(U);
                File.WriteAllText(Root, JsonConvert.SerializeObject(Products));
                return;
            }
            Products = JsonConvert.DeserializeObject<List<Product>>(Json);
            if (CheckDuplicate(U)) return;
            Products.Add(U);
            File.WriteAllText(Root, JsonConvert.SerializeObject(Products));
        }
        public bool CheckDuplicate(Product U)
        {
            string Json = File.ReadAllText(Root);
            if (String.IsNullOrEmpty(Json)) return false;
            var _Products = JsonConvert.DeserializeObject<List<Product>>(Json);
            return _Products.Any(o => o.Equals(U));
        }
        public void Remove(Product U)
        {
            string Json = File.ReadAllText(Root);
            if (String.IsNullOrEmpty(Json)) return;
            var _Products = JsonConvert.DeserializeObject<List<Product>>(Json);
            if (_Products.Any(o => o.Equals(U))) _Products.Remove(U);
        }

        public Product Search(Product U)
        {
            string Json = File.ReadAllText(Root);
            if (String.IsNullOrEmpty(Json)) return null;
            var _Products = JsonConvert.DeserializeObject<List<Product>>(Json);
            if (_Products.Any(o => o.Equals(U))) return U;
            return null;
        }
    }
}
