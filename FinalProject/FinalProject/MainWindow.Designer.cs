namespace FinalProject {
    partial class MainWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControlHR = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEmpSup = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpPos = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpNames = new System.Windows.Forms.ComboBox();
            this.buttonViewOneEmp = new System.Windows.Forms.Button();
            this.buttonAddEmp = new System.Windows.Forms.Button();
            this.listViewEmp = new System.Windows.Forms.ListView();
            this.textBoxEmpWage = new System.Windows.Forms.TextBox();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxProductNames = new System.Windows.Forms.ComboBox();
            this.buttonViewProd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBuyAmount = new System.Windows.Forms.TextBox();
            this.textBoxSellAmount = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxProdDept = new System.Windows.Forms.ComboBox();
            this.textBoxProdPrice = new System.Windows.Forms.TextBox();
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewInv = new System.Windows.Forms.ListView();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.tabControlHR.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHR
            // 
            this.tabControlHR.Controls.Add(this.tabPage1);
            this.tabControlHR.Controls.Add(this.tabPage2);
            this.tabControlHR.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControlHR.Location = new System.Drawing.Point(0, 12);
            this.tabControlHR.Name = "tabControlHR";
            this.tabControlHR.SelectedIndex = 0;
            this.tabControlHR.Size = new System.Drawing.Size(802, 440);
            this.tabControlHR.TabIndex = 0;
            this.tabControlHR.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBoxEmpSup);
            this.tabPage1.Controls.Add(this.comboBoxEmpPos);
            this.tabPage1.Controls.Add(this.comboBoxEmpNames);
            this.tabPage1.Controls.Add(this.buttonViewOneEmp);
            this.tabPage1.Controls.Add(this.buttonAddEmp);
            this.tabPage1.Controls.Add(this.listViewEmp);
            this.tabPage1.Controls.Add(this.textBoxEmpWage);
            this.tabPage1.Controls.Add(this.textBoxEmpName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Human Resources";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(32, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "View Employee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(33, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Add New Employee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Supervisor";
            // 
            // comboBoxEmpSup
            // 
            this.comboBoxEmpSup.FormattingEnabled = true;
            this.comboBoxEmpSup.Location = new System.Drawing.Point(118, 256);
            this.comboBoxEmpSup.Name = "comboBoxEmpSup";
            this.comboBoxEmpSup.Size = new System.Drawing.Size(303, 28);
            this.comboBoxEmpSup.TabIndex = 12;
            // 
            // comboBoxEmpPos
            // 
            this.comboBoxEmpPos.FormattingEnabled = true;
            this.comboBoxEmpPos.Location = new System.Drawing.Point(118, 222);
            this.comboBoxEmpPos.Name = "comboBoxEmpPos";
            this.comboBoxEmpPos.Size = new System.Drawing.Size(303, 28);
            this.comboBoxEmpPos.TabIndex = 11;
            // 
            // comboBoxEmpNames
            // 
            this.comboBoxEmpNames.FormattingEnabled = true;
            this.comboBoxEmpNames.Location = new System.Drawing.Point(32, 44);
            this.comboBoxEmpNames.Name = "comboBoxEmpNames";
            this.comboBoxEmpNames.Size = new System.Drawing.Size(289, 28);
            this.comboBoxEmpNames.TabIndex = 10;
            // 
            // buttonViewOneEmp
            // 
            this.buttonViewOneEmp.Location = new System.Drawing.Point(327, 44);
            this.buttonViewOneEmp.Name = "buttonViewOneEmp";
            this.buttonViewOneEmp.Size = new System.Drawing.Size(94, 29);
            this.buttonViewOneEmp.TabIndex = 9;
            this.buttonViewOneEmp.Text = "View";
            this.buttonViewOneEmp.UseVisualStyleBackColor = true;
            this.buttonViewOneEmp.Click += new System.EventHandler(this.ButtonViewOneEmp_Click);
            // 
            // buttonAddEmp
            // 
            this.buttonAddEmp.Location = new System.Drawing.Point(327, 290);
            this.buttonAddEmp.Name = "buttonAddEmp";
            this.buttonAddEmp.Size = new System.Drawing.Size(94, 29);
            this.buttonAddEmp.TabIndex = 7;
            this.buttonAddEmp.Text = "Add New";
            this.buttonAddEmp.UseVisualStyleBackColor = true;
            this.buttonAddEmp.Click += new System.EventHandler(this.ButtonAddEmp_Click);
            // 
            // listViewEmp
            // 
            this.listViewEmp.Location = new System.Drawing.Point(460, 16);
            this.listViewEmp.Name = "listViewEmp";
            this.listViewEmp.Size = new System.Drawing.Size(324, 385);
            this.listViewEmp.TabIndex = 6;
            this.listViewEmp.UseCompatibleStateImageBehavior = false;
            this.listViewEmp.View = System.Windows.Forms.View.List;
            // 
            // textBoxEmpWage
            // 
            this.textBoxEmpWage.Location = new System.Drawing.Point(235, 189);
            this.textBoxEmpWage.Name = "textBoxEmpWage";
            this.textBoxEmpWage.Size = new System.Drawing.Size(186, 27);
            this.textBoxEmpWage.TabIndex = 4;
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(118, 156);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(303, 27);
            this.textBoxEmpName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxProductNames);
            this.tabPage2.Controls.Add(this.buttonViewProd);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxBuyAmount);
            this.tabPage2.Controls.Add(this.textBoxSellAmount);
            this.tabPage2.Controls.Add(this.Product);
            this.tabPage2.Controls.Add(this.buttonBuy);
            this.tabPage2.Controls.Add(this.buttonSell);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBoxProdDept);
            this.tabPage2.Controls.Add(this.textBoxProdPrice);
            this.tabPage2.Controls.Add(this.textBoxProdName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listViewInv);
            this.tabPage2.Controls.Add(this.buttonAddProduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxProductNames
            // 
            this.comboBoxProductNames.FormattingEnabled = true;
            this.comboBoxProductNames.Location = new System.Drawing.Point(39, 46);
            this.comboBoxProductNames.Name = "comboBoxProductNames";
            this.comboBoxProductNames.Size = new System.Drawing.Size(341, 28);
            this.comboBoxProductNames.TabIndex = 19;
            // 
            // buttonViewProd
            // 
            this.buttonViewProd.Location = new System.Drawing.Point(386, 46);
            this.buttonViewProd.Name = "buttonViewProd";
            this.buttonViewProd.Size = new System.Drawing.Size(63, 29);
            this.buttonViewProd.TabIndex = 18;
            this.buttonViewProd.Text = "View";
            this.buttonViewProd.UseVisualStyleBackColor = true;
            this.buttonViewProd.Click += new System.EventHandler(this.ButtonViewProd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(39, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Add New Product Type";
            // 
            // textBoxBuyAmount
            // 
            this.textBoxBuyAmount.Location = new System.Drawing.Point(276, 117);
            this.textBoxBuyAmount.Name = "textBoxBuyAmount";
            this.textBoxBuyAmount.Size = new System.Drawing.Size(58, 27);
            this.textBoxBuyAmount.TabIndex = 16;
            // 
            // textBoxSellAmount
            // 
            this.textBoxSellAmount.Location = new System.Drawing.Point(276, 82);
            this.textBoxSellAmount.Name = "textBoxSellAmount";
            this.textBoxSellAmount.Size = new System.Drawing.Size(58, 27);
            this.textBoxSellAmount.TabIndex = 15;
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Product.Location = new System.Drawing.Point(39, 23);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(83, 20);
            this.Product.TabIndex = 14;
            this.Product.Text = "Buy or Sell";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(340, 115);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(109, 29);
            this.buttonBuy.TabIndex = 13;
            this.buttonBuy.Text = "Buy Amount";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(340, 82);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(109, 29);
            this.buttonSell.TabIndex = 12;
            this.buttonSell.Text = "Sell Amount";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.ButtonSell_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Unit Price";
            // 
            // comboBoxProdDept
            // 
            this.comboBoxProdDept.FormattingEnabled = true;
            this.comboBoxProdDept.Location = new System.Drawing.Point(119, 278);
            this.comboBoxProdDept.Name = "comboBoxProdDept";
            this.comboBoxProdDept.Size = new System.Drawing.Size(330, 28);
            this.comboBoxProdDept.TabIndex = 8;
            // 
            // textBoxProdPrice
            // 
            this.textBoxProdPrice.Location = new System.Drawing.Point(231, 245);
            this.textBoxProdPrice.Name = "textBoxProdPrice";
            this.textBoxProdPrice.Size = new System.Drawing.Size(218, 27);
            this.textBoxProdPrice.TabIndex = 6;
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(119, 212);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(330, 27);
            this.textBoxProdName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dept";
            // 
            // listViewInv
            // 
            this.listViewInv.Location = new System.Drawing.Point(491, 6);
            this.listViewInv.Name = "listViewInv";
            this.listViewInv.Size = new System.Drawing.Size(297, 391);
            this.listViewInv.TabIndex = 1;
            this.listViewInv.UseCompatibleStateImageBehavior = false;
            this.listViewInv.View = System.Windows.Forms.View.List;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(355, 312);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(94, 29);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Add New Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlHR);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.tabControlHR.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private TabControl tabControlHR;
        private TabPage tabPage1;
        private Button buttonAddEmp;
        private ListView listViewEmp;
        private TextBox textBoxEmpWage;
        private TextBox textBoxEmpName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Label label7;
        private ComboBox comboBoxProdDept;
        private TextBox textBoxProdPrice;
        private TextBox textBoxProdName;
        private Label label6;
        private Label label4;
        private ListView listViewInv;
        private Button buttonAddProduct;
        private Button buttonBuy;
        private Button buttonSell;
        private Label label8;
        private TextBox textBoxBuyAmount;
        private TextBox textBoxSellAmount;
        private Label Product;
        private Label label5;
        private ComboBox comboBoxEmpSup;
        private ComboBox comboBoxEmpPos;
        private ComboBox comboBoxEmpNames;
        private Button buttonViewOneEmp;
        private Label label10;
        private Label label9;
        private Button buttonViewProd;
        private ComboBox comboBoxProductNames;
    }
}