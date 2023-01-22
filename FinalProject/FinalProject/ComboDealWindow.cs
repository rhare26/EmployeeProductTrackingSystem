using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject {
    public partial class ComboDealWindow : Form {
        ComboDealProduct cdp;
        internal ComboDealWindow(BindingList<AbsProduct> inventory, ComboDealProduct cdp) {
            InitializeComponent();
            comboBox1.DataSource = inventory;
            comboBox1.DisplayMember = "Name";

            this.cdp = cdp;
        }

        /**User selects Done***/
        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        /***User selects Add***/
        private void button3_Click(object sender, EventArgs e) {
            AbsProduct p = (AbsProduct)comboBox1.SelectedItem;
            cdp.AddToComboDeal(p);
        }
    }
}
