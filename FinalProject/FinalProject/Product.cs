using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProject {
    /***Creates a new AbsProduct from input. Uses reflection from department string to get child type***/
    internal class ProductFactory {
        public AbsProduct Create(string name, string department, double unitPrice) {
            try{
                //strip chars and add "Product" to end
                department = Regex.Replace(department, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
                department += "Product";
                department = "FinalProject." + department;

                //Reflection to create product
                Type t = Type.GetType(department);
                AbsProduct p = (AbsProduct)Activator.CreateInstance(t);

                //Set attributes
                p.Name = name;
                p.UnitPrice = unitPrice;

                return p;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }

    /***AbsProduct***/
    internal abstract class AbsProduct {
        internal string name = "";
        internal string department ="";
        internal double unitPrice = 0;
        internal int quantity = 0;

        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        /***Checks if product is available and updates amount if so***/
        /*Combo deal overrides this method*/
        public virtual bool AddQuantity(int amt) {
            if (Quantity + amt >= 0) {
                Quantity += amt;
                return true;
            }
            else
                return false;
        }
    }

    /* Note: All children of AbsProduct can be created through ProductFactory with reflection
     * Do not change class names*/
    internal class MeatDairyProduct : AbsProduct {
        public MeatDairyProduct() {
            Department = "Meat & Dairy";
        }
    }

    internal class ProduceProduct : AbsProduct {
        public ProduceProduct() {
            Department = "Produce";
        }
    }

    internal class GroceryProduct : AbsProduct {
        public GroceryProduct() {
            Department = "Grocery";
        }
    }

    internal class BakeryProduct : AbsProduct {
        public BakeryProduct() {
            Department = "Bakery";
        }
    }

    internal class MiscProduct : AbsProduct {
        public MiscProduct() {
            Department = "Misc";
        }
    }

    internal class ComboDealProduct : AbsProduct {
        List<AbsProduct> items = new List<AbsProduct>();
        public  List<AbsProduct> Items { get => items; set => items = value; }
        public ComboDealProduct() {
            Department = "Combo Deal";
        }
        public void AddToComboDeal(params AbsProduct[] items) {
            this.items.AddRange(items);
        }

        public override bool AddQuantity(int amt) {

            //before editing, make sure every item is available
            foreach (AbsProduct item in items) {
                //if you don't have enough of one item
                if(item.Quantity + amt <= 0) {
                    return false;
                }
            }

            //change quantity of the combo deal
            base.AddQuantity(amt);

            //change quantity of each of the itesm in it
            foreach (AbsProduct item in items) {
                item.AddQuantity(amt);
            }
            return true;
        }
    }
}
