using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ShopApp
{
    public class Order
    {
       
        private int OrderID { get; set; }
        public int Count { get; set; }
        public DateTime DateOrdered { get; set; }
        public List<Product> Basket { get; set; }
        private string Root { get; set; }
      
        private int GetNextOrderID()
        {
            int nextId = 0;
            var RootPath = ConfigurationManager.AppSettings["Orders"];
            if (string.IsNullOrEmpty(RootPath))
            {
                RootPath = "Orders";
            }
            string[] files = Directory.GetFiles(RootPath, "*.json");

            foreach(string s in files)
            {
                nextId = Convert.ToInt32(Regex.Match(s, @"\d+").Value);
            }
            nextId += 1;
            return nextId;
            
        }
     
        public Order(DateTime _DateOrdered, List<Product> _Basket, int _Count)
        {
            var RootPath = ConfigurationManager.AppSettings["Orders"];
            if (string.IsNullOrEmpty(RootPath))
            {
                RootPath = "Orders";
            }
            if (!Directory.Exists(RootPath)) Directory.CreateDirectory(RootPath);
            OrderID = GetNextOrderID();
            DateOrdered = _DateOrdered;
            Count = _Count;
            Basket = _Basket;
           
 
        }
        public void OrderOrder(Order o)
        {
            
            var RootPath = ConfigurationManager.AppSettings["Orders"];
            string FileName = $"Orders{o.OrderID}.json";
            if (string.IsNullOrEmpty(RootPath))
            {
                RootPath = "Orders";
            }
            if (!Directory.Exists(RootPath)) Directory.CreateDirectory(RootPath);
            if (!File.Exists(Path.Combine(RootPath, FileName))) File.Create(Path.Combine(RootPath, FileName)).Close();
            Root = Path.Combine(RootPath, FileName);
            string json = JsonConvert.SerializeObject(o);
            File.WriteAllText(Root, json);
        }
    }
}
