using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class ShopForm : Form
    {
        Basket B = new Basket();
        ProductList P;
        
        public ShopForm()
        {
            InitializeComponent();
            P = new ProductList();
            P.Products = P.GetData();
         
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order O = new Order(DateTime.Now,B.Cart,B.Cart.Count);
            O.OrderOrder(O);
            TheList.Text = "Empty Cart";
            Price.Text = "0";
            foreach(var item in P.Products)
            {
                B.Reset(item);
            }
        }

        private void groupBox3_Move(object sender, EventArgs e)
        {

        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
           
            
            if (P.Products == null) return;
            else
            foreach (var item in P.Products)
            {
                flowLayoutPanel1.Controls.Add(GetGroupBox(item, 494, 136));
            }
        
        }
       
        public void AddToCart(object sender, EventArgs e,Product item)
        {
            if (!B.Cart.Any(i => i.Equals(item)))
                {
                B.Cart.Add(item);
               
                TheList.Text = B.CartProds();
                var _x = B.Cart.Where(i=>i.Equals(item));
                var _y = Convert.ToInt32(Price.Text);
                Price.Text =(_y+_x.Sum(i => i.Price*item.Ammount)).ToString();
                return;
                }
              
                if (TheList.Text == "Empty Cart")
                {
                    
                    TheList.Text = B.CartProds();
                    Price.Text = B.Cart.Sum(Prod => Prod.Price).ToString();
                    return;
                }
            B.IncrementThisProduct(item);
            TheList.Text = B.CartProds();
            Price.Text = B.Cart.Sum(i => i.Price * i.Ammount).ToString();//Nu inteleg cum am reparat asta
            return;

        }

        private GroupBox GetGroupBox(Product item, int v1, int v2)
        {
            GroupBox g = new GroupBox();
            g.Size = new Size(v1, v2);
            g.Text = item.Name;
            g.Click += (sender2, e2) => AddToCart(sender2, e2, item);
          
           
            foreach(var product in P.Products)
            {
                Label Desc = new Label();
               
                Desc.Text = item.ToString();
                Desc.AutoSize = true;
               
                Desc.Location = new Point(v1/15, v2/4);
               
                g.Controls.Add(Desc);
               

            }
            return g;
            
        }
    }
}
