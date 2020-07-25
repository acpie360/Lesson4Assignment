using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4Assignment
{
    public partial class HamburgerStand : Form
    {
        private const int maxItems = 3;
        private const double priceHamburger = 2.0;
        private const double priceFries = 1.5;
        private const double priceDrink = 1.0;
        private const double priceDesert = 0;

        public enum MENU_ITEM {NONE, HAMBURGER, FRIES, DRINK};
        public enum DESERT_ITEM {NONE, CAKE, ICE_CREAM};

        class Order
        {
            public MENU_ITEM[] menu_item;
            public DESERT_ITEM desert;
            public double price;

            private readonly string[] food_name = 
            {
                "Hamburger",
                "Fries    ",
                "Drink    ",
                "Cake     ",
                "Ice Cream"
            };

            public Order()
            {
                menu_item = new MENU_ITEM[maxItems];

                for (int i = 0; i < menu_item.Length; i++)
                {
                    menu_item[i] = MENU_ITEM.NONE;
                }

                desert = DESERT_ITEM.NONE;
                price = 0;
            }

            public string ShowOrder()
            {
                int i;
                string order_msg = String.Format("{0,25}", "Your Order\n");

                for (i = 0; i < menu_item.Length; i++)
                {
                    switch (menu_item[i])
                    {
                        case MENU_ITEM.NONE:
                            continue;

                        case MENU_ITEM.HAMBURGER:
                            order_msg += String.Format("{0,-12}{1,25:C}\n", food_name[0], priceHamburger);
                            break;

                        case MENU_ITEM.FRIES:
                            order_msg += String.Format("{0,-12}{1,25:C}\n", food_name[1], priceFries);
                            break;

                        case MENU_ITEM.DRINK:
                            order_msg += String.Format("{0,-12}{1,25:C}\n", food_name[2], priceDrink);// + Environment.NewLine;
                            break;
                    }
                }

                switch (desert)
                {
                    case DESERT_ITEM.NONE:
                        break;

                    case DESERT_ITEM.CAKE:
                        order_msg += String.Format("{0,-12}{1,25:C}\n", food_name[3], priceDesert);
                        break;
                    case DESERT_ITEM.ICE_CREAM:
                        order_msg += String.Format("{0,-12}{1,25:C}\n", food_name[4], priceDesert);
                        break;
                }

                order_msg += String.Format("\n\n{0,20}{1,16:C}\n", "Total", price);// + Environment.NewLine;

                return order_msg;
            }
        }

        public HamburgerStand()
        {
            InitializeComponent();

            lblHamburgerPrice.Text = String.Format("{0, 10:C}", priceHamburger);
            lblFriesPrice.Text = String.Format("{0,10:C}", priceFries);
            lblDrinkPrice.Text = String.Format("{0,10:C}", priceDrink);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order myOrder = new Order();

            if (chkHamburger.Checked == false && chkFries.Checked == false && chkDrink.Checked == false)
            {
                MessageBox.Show("Please select one item from the menu", "Missing Item");
                return;
            }

            if (chkHamburger.Checked == true)
            {
                myOrder.menu_item[0] = MENU_ITEM.HAMBURGER;
                myOrder.price += priceHamburger;
            }

            if (chkFries.Checked == true)
            {
                myOrder.menu_item[1] = MENU_ITEM.FRIES;
                myOrder.price += priceFries;
            }

            if (chkDrink.Checked == true)
            {
                myOrder.menu_item[2] = MENU_ITEM.DRINK;
                myOrder.price += priceDrink;
            }

            if (radCake.Checked == true)
            {
                myOrder.desert = DESERT_ITEM.CAKE;
            }

            if (radIceCream.Checked == true)
            {
                myOrder.desert = DESERT_ITEM.ICE_CREAM;
            }

            lblReceipt.Text = myOrder.ShowOrder();
        }
    }
}
