using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class Basket
    {
        public List<Product> Cart;
        public int Total;
    
        public Basket()
        {
            Cart = new List<Product>();
            Total = 0;
          
        }
          public string CartProds()
          {
             var res = string.Empty;
             foreach(var i in Cart)
              {
                  res += i.Name + " x" + i.Ammount + "\n";
              }
            return res;
          }
     
        public void IncrementThisProduct(Product item)
        {
            item.Ammount++;
        }
        public void Reset(Product item)
        {
            item.Ammount = 1;
            Cart.Clear();
        }
     
    }
}
