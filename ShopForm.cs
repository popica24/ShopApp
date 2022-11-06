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
            if (P.Products == null) return;
            else
                foreach (var item in P.Products)
                {
                    flowLayoutPanel1.Controls.Add(GetGroupBox(item, 550, 130));
                }

        }
      

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            Order O = new Order(DateTime.Now, B.Cart, B.Cart.Count);
            O.OrderOrder(O);
            TheList.Text = "Empty Cart";
            Price.Text = "0";
            foreach (var item in P.Products)
            {
                B.Reset(item);
            }
            /*
             P.Add(new Product (1, "Laptop ASUS X515EA", "Intel® Core™ i3-1115G4 pana la 4.1 GHz, 15.6\", Full HD, IPS, 8GB, 256GB SSD, Intel® UHD Graphics, No OS, Transparent Silver", 1279, DateTime.Now, 1));
             P.Add(new Product (2, "ASUS TUF F15 FX506HC","Intel® Core™ i5-11400H pana la 4.50 GHz, 15.6\", Full HD, IPS, 144Hz, 8GB, 1TB SSD, NVIDIA® GeForce RTX™ 3050 4GB",3199,   DateTime.Now,  2 ));
             P.Add(new Product (3, "Lenovo IdeaPad 3 15ITL6","Intel® Core™ i3-1115G4 pana la 4.10 GHz, 15.6\", Full HD, 4GB, 256GB SSD, Intel UHD Graphics",  1349, DateTime.Now, 3 ));
             P.Add(new Product (4, "ASUS E210MA", "Intel® Celeron® N4020 pana la 2.80 GHz, 11.6\", 4GB, 128GB eMMC, Intel® UHD Graphics 600", 999,  DateTime.Now,  4 ));
             P.Add(new Product (5, "Lenovo 15.6' IdeaPad 3", "Intel® Celeron® N4120 (quad core, 4M Cache, pana la 2.60 GHz), 4GB DDR4, 256GB SSD, GMA UHD 600", 849,  DateTime.Now,  5 ));
             P.Add(new Product (6, "ASUS E210MA", "Intel® Celeron® N4020 pana la 2.80 GHz, 11.6\", 4GB, 128GB eMMC, Intel® UHD Graphics 600", 999,  DateTime.Now,  6 ));
             P.Add(new Product (7, "HP 15-dw3034nq", "Intel® Core™ i5-1135G7 pana la 4.20 GHz, 15.6\", Full HD, 8GB, 512GB SSD, Intel® Iris® Xe Graphics", 2249,  DateTime.Now, 7 ));
             P.Add(new Product (8, "Apple 13-inch MacBook Pro", "Apple M2 chip with 8-core CPU and 10-core GPU, 256GB SSD", 6899,  DateTime.Now,  8 ));
            */
        }


        private void ShopForm_Load(object sender, EventArgs e)
        {

         
        }

        public void AddToCart(object sender, EventArgs e, Product item)
        {
            if (!B.Cart.Any(i => i.Equals(item)))
            {
                B.Cart.Add(item);

                TheList.Text = B.CartProds();
                var _x = B.Cart.Where(i => i.Equals(item));
                var _y = Convert.ToInt32(Price.Text);
                Price.Text = (_y + _x.Sum(i => i.Price * item.Ammount)).ToString();
                return;
            }

            if (TheList.Text == "Empty Cart")
            {

                TheList.Text = B.CartProds();
                Price.Text = B.Cart.Sum(Prod => Prod.Price).ToString();
                return;
            }
            item.Ammount++;
            TheList.Text = B.CartProds();
            Price.Text = B.Cart.Sum(i => i.Price * i.Ammount).ToString(); //Nu inteleg cum am reparat asta
            return;

        }

        private GroupBox GetGroupBox(Product item, int v1, int v2)
        {
            GroupBox g = new GroupBox();
            g.Size = new Size(v1, v2);
            g.Text = item.Name;
            g.Name = item.Name;
            g.Click += (sender2, e2) => AddToCart(sender2, e2, item);

            foreach (var product in P.Products)
            {
                Label Desc = new Label();
                Desc.Text = item.ToString();
                Desc.AutoSize = true;
                Desc.Location = new Point(v1 / 15, v2 / 4);
                g.Controls.Add(Desc);
            }
            return g;

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                    flowLayoutPanel1.Controls[i].Show();
                return;

            }
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (!flowLayoutPanel1.Controls[i].Name.ToLower().Contains(SearchBox.Text.ToLower()))
                {
                    flowLayoutPanel1.Controls[i].Hide();
                }
                else
                {
                    flowLayoutPanel1.Controls[i].Show(); //?
                }
            }
        }
    }
}