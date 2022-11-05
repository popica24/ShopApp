using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class Product
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime ManufacturerDate { get; set; }
        public int TypeId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Ammount { get; set; } = 1;

        public override string ToString()
        {
            return $"Name : {Name}\nDescription : {Description}\nPrice : {Price}\n Manufacturer : {ManufacturerDate}\n Expires : {ExpirationDate}";
        }

        public override bool Equals(object? obj)
        {
          if(!(obj is Product)) return false;
          Product other = obj as Product;

            return other.Id == this.Id && other.Name == this.Name && other.Description == this.Description && other.Price == this.Price && this.ExpirationDate==other.ExpirationDate && this.ManufacturerDate==other.ManufacturerDate && this.TypeId==other.TypeId;
        }
    }
}
