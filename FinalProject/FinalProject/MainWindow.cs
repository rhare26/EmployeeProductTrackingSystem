using System.ComponentModel;

namespace FinalProject {
    public partial class MainWindow : Form {
        static BindingList<AbsEmployee> employees = new();
        static BindingList<AbsProduct> inventory = new();
        static ProductFactory productFactory = new();
        static EmployeeFactory employeeFactory = new();
        static BindingList<string> supervisors = new();
        static BindingList<string> productDepartments = new() {"Meat & Dairy", "Produce", "Grocery", "Bakery", "Misc", "Combo Deal"}; //do not edit, used for reflection (linked to class names)
        static BindingList<string> employeePositions = new() {"Worker", "Shift Supervisor", "Assistant Manager", "Store Manager" }; //do not edit, used for reflection (linked to class names)

        /***View Employee***/
        private void ButtonViewOneEmp_Click(object sender, EventArgs e) {
            listViewEmp.Clear();

            //basic info
            AbsEmployee emp = (AbsEmployee)comboBoxEmpNames.SelectedItem;
            listViewEmp.Items.Add("Name: " + emp.Name);
            listViewEmp.Items.Add("Wage: " + emp.Wage.ToString("C"));

            if(emp.Parent!= null) {
                listViewEmp.Items.Add("Supervisor: " + emp.Parent.Name);
            }

            //uses chain of command to get supervisor, supervisor's supervisor, and so on
            listViewEmp.Items.Add("");
            listViewEmp.Items.Add("Everyone in direct line above employee:");
            List<string> lh = emp.GetAllHigher();
            foreach (string s in lh) {
                listViewEmp.Items.Add(s);
            }

            //uses chain of command to get subordinates, subordinates' subordinates, and so on
            listViewEmp.Items.Add("");
            listViewEmp.Items.Add("Everyone in direct line below employee:");
            List<string> ll = emp.GetAllLower();
            foreach (string s in ll) {
                listViewEmp.Items.Add(s);
            }
        }

        /***Add New Employee***/
        private void ButtonAddEmp_Click(object sender, EventArgs e) {
            string name = textBoxEmpName.Text;
            try {
                //basic info
                double wage = Double.Parse(textBoxEmpWage.Text);
                string position = comboBoxEmpPos.GetItemText(this.comboBoxEmpPos.SelectedItem);
                string supervisorStr = comboBoxEmpSup.GetItemText(this.comboBoxEmpSup.SelectedItem);

                //find supervisor object from string
                supervisorStr = supervisorStr[(supervisorStr.IndexOf(":") + 2)..];
                AbsEmployee supervisorObj = new NullEmployee();
                foreach (AbsEmployee s in employees) {
                    if (s.Name == supervisorStr) {
                        supervisorObj = s;
                    }
                }

                //uses factory to create new AbsEmployee object
                AbsEmployee emp = employeeFactory.Create(name, wage, position, supervisorObj);
                if (emp != null) {
                    employees.Add(emp);
                    supervisors.Add(position + ": " + name);
                    ResetBindings();
                }
                else {
                    //Factory returns null if supervisoir is invalid
                    //Enforced by composite pattern
                    MessageBox.Show("Supervisors must be a higher position than the employee. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.FormatException) {
                MessageBox.Show("Wage must be in number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show("Unable to add employee: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /***View Product Type***/
        private void ButtonViewProd_Click(object sender, EventArgs e) {
            listViewInv.Clear();

            AbsProduct prod = (AbsProduct)comboBoxProductNames.SelectedItem;
            listViewInv.Items.Add("Name: " + prod.Name);
            listViewInv.Items.Add("Department: " + prod.Department);
            listViewInv.Items.Add("Unit Price: " + prod.UnitPrice.ToString("C"));
            listViewInv.Items.Add("Quantity: " + prod.Quantity);

            listViewInv.Items.Add("");
            if (prod is ComboDealProduct comboDealProduct) {
                listViewInv.Items.Add("Items in Combo Deal: ");
                foreach(AbsProduct item in (comboDealProduct).Items){
                    listViewInv.Items.Add(item.Name);
                }
            }
        }

        /***Add New Product Type***/
        private void ButtonAddProduct_Click(object sender, EventArgs e) {
            string dept = comboBoxProdDept.GetItemText(this.comboBoxProdDept.SelectedItem);
            double price = Double.Parse(textBoxProdPrice.Text);
            string name = textBoxProdName.Text;

            AbsProduct p = productFactory.Create(name, dept, price);

            if (p is ComboDealProduct cdp) {
                ComboDealWindow cdw = new(inventory, cdp);
                cdw.ShowDialog();

                //if you were able to add items
                if (cdp.Items.Count != 0) {
                    inventory.Add(p);
                }
                else {
                    MessageBox.Show("Not enough items in stock to fulfill combo deal");
                }
            }
            else {
                inventory.Add(p);
            }
        }

        private void ButtonSell_Click(object sender, EventArgs e) {
            try {
                AbsProduct prod = (AbsProduct)comboBoxProductNames.SelectedItem;
                int amt = Int32.Parse(textBoxSellAmount.Text);

                //to sell, we are adding a negative amount
                if (!prod.AddQuantity(-amt)) {
                    MessageBox.Show("Not enough in stock.");
                }
                //refresh view
                ButtonViewProd_Click(sender, e);
            }
            catch (FormatException) {
                MessageBox.Show("Amount must be in number format.");
            }
        }

        private void ButtonBuy_Click(object sender, EventArgs e) {
            try {
                AbsProduct prod = (AbsProduct)comboBoxProductNames.SelectedItem;
                int amt = Int32.Parse(textBoxBuyAmount.Text);
                prod.AddQuantity(amt);

                //refresh view
                ButtonViewProd_Click(sender, e);
            }
            catch (FormatException) {
                MessageBox.Show("Amount must be in number format.");
            }
        }

        /***Add Example Employees & Products at Startup***/
        private void AddExampleData() {
            //add employees
            employees.Add(new StoreManager("Mike McDonald", 26));
            supervisors.Add("Store Manager: Mike McDonald");

            employees.Add(new AssistantManager("Ashley Aarons", 18));
            employees[1].SetHeadPerson(employees[0]);
            supervisors.Add("Assistant Manager: Ashley Aarons");

            employees.Add(new ShiftSupervisor("Sally Smith", 26));
            employees[2].SetHeadPerson(employees[1]);
            supervisors.Add("Shift Supervisor: Sally Smith");

            employees.Add(new ShiftSupervisor("Susan Simons", 26));
            employees[3].SetHeadPerson(employees[1]);
            supervisors.Add("Shift Supervisor: Susan Simons");

            employees.Add(new Worker("Walter White", 26));
            employees[4].SetHeadPerson(employees[2]);
            supervisors.Add("Worker: Walter White");

            employees.Add(new Worker("Walt Whitman", 26));
            employees[5].SetHeadPerson(employees[2]);
            supervisors.Add("Worker: Walt Whitman");

            //add products
            inventory.Add(productFactory.Create("Shredded Cheddar (8 oz)", "Meat & Dairy", 3.57));
            inventory[0].AddQuantity(4);
            inventory.Add(productFactory.Create("Pepperoni Log (8 oz)", "Meat & Dairy", 4.57));
            inventory[1].AddQuantity(7);
            inventory.Add(productFactory.Create("Donuts (dz)", "Bakery", 5.49));
            inventory[2].AddQuantity(14);
            inventory.Add(productFactory.Create("Apple (ea)", "Produce", 0.89));
            inventory[3].AddQuantity(32);
            inventory.Add(productFactory.Create("Banana (lb)", "Produce", 1.21));
            inventory[4].AddQuantity(11);
            inventory.Add(productFactory.Create("Canned soup (ea)", "Grocery", 3.57));
            inventory[5].AddQuantity(22);
            inventory.Add(productFactory.Create("BBQ Chips (bag)", "Grocery", 1.78));
            inventory[6].AddQuantity(7);
            inventory.Add(productFactory.Create("Rootbeer Soda (2L)", "Grocery", 2.22));
            inventory[7].AddQuantity(4);
            inventory.Add(productFactory.Create("Ketchup (8oz)", "Grocery", 2.21));
            inventory[8].AddQuantity(3);
            inventory.Add(productFactory.Create("Paper Towel (ea)", "Misc", 2.21));
            inventory[9].AddQuantity(10);
            inventory.Add(productFactory.Create("Hand sanitizer (3oz)", "Misc", 2.21));
            inventory[10].AddQuantity(15);
            inventory.Add(productFactory.Create("Two Rootbeers & Chips Combo", "Combo Deal", 1.99));
            inventory[11].AddQuantity(0);
            ((ComboDealProduct)inventory[11]).AddToComboDeal(inventory[7], inventory[7], inventory[6]);
        }

        public MainWindow() {
            InitializeComponent();

            //filler data for demo
            AddExampleData();

            //bind list to combo boxes
            comboBoxProductNames.DataSource = inventory;
            comboBoxProductNames.DisplayMember = "Name";
            comboBoxEmpNames.DataSource = employees;
            comboBoxEmpNames.DisplayMember = "Name";
            comboBoxEmpSup.DataSource = supervisors;
            comboBoxProdDept.DataSource = productDepartments;
            comboBoxEmpPos.DataSource = employeePositions;
        }
    }
}