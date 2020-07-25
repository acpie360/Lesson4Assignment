namespace Lesson4Assignment
{
    partial class HamburgerStand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpOrderMenu = new System.Windows.Forms.GroupBox();
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.chkDrink = new System.Windows.Forms.CheckBox();
            this.lblHamburgerPrice = new System.Windows.Forms.Label();
            this.lblFriesPrice = new System.Windows.Forms.Label();
            this.lblDrinkPrice = new System.Windows.Forms.Label();
            this.grpDesert = new System.Windows.Forms.GroupBox();
            this.radCake = new System.Windows.Forms.RadioButton();
            this.radIceCream = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.grpOrderMenu.SuspendLayout();
            this.grpDesert.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrderMenu
            // 
            this.grpOrderMenu.Controls.Add(this.lblDrinkPrice);
            this.grpOrderMenu.Controls.Add(this.lblFriesPrice);
            this.grpOrderMenu.Controls.Add(this.lblHamburgerPrice);
            this.grpOrderMenu.Controls.Add(this.chkDrink);
            this.grpOrderMenu.Controls.Add(this.chkFries);
            this.grpOrderMenu.Controls.Add(this.chkHamburger);
            this.grpOrderMenu.Location = new System.Drawing.Point(34, 37);
            this.grpOrderMenu.Name = "grpOrderMenu";
            this.grpOrderMenu.Size = new System.Drawing.Size(722, 170);
            this.grpOrderMenu.TabIndex = 0;
            this.grpOrderMenu.TabStop = false;
            this.grpOrderMenu.Text = "Order Menu";
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Location = new System.Drawing.Point(20, 35);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(101, 21);
            this.chkHamburger.TabIndex = 0;
            this.chkHamburger.Text = "Hamburger";
            this.chkHamburger.UseVisualStyleBackColor = true;
            // 
            // chkFries
            // 
            this.chkFries.AutoSize = true;
            this.chkFries.Location = new System.Drawing.Point(20, 78);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(61, 21);
            this.chkFries.TabIndex = 1;
            this.chkFries.Text = "Fries";
            this.chkFries.UseVisualStyleBackColor = true;
            // 
            // chkDrink
            // 
            this.chkDrink.AutoSize = true;
            this.chkDrink.Location = new System.Drawing.Point(20, 121);
            this.chkDrink.Name = "chkDrink";
            this.chkDrink.Size = new System.Drawing.Size(63, 21);
            this.chkDrink.TabIndex = 2;
            this.chkDrink.Text = "Drink";
            this.chkDrink.UseVisualStyleBackColor = true;
            // 
            // lblHamburgerPrice
            // 
            this.lblHamburgerPrice.Location = new System.Drawing.Point(355, 35);
            this.lblHamburgerPrice.Name = "lblHamburgerPrice";
            this.lblHamburgerPrice.Size = new System.Drawing.Size(332, 23);
            this.lblHamburgerPrice.TabIndex = 3;
            this.lblHamburgerPrice.Text = ".....";
            this.lblHamburgerPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFriesPrice
            // 
            this.lblFriesPrice.Location = new System.Drawing.Point(355, 78);
            this.lblFriesPrice.Name = "lblFriesPrice";
            this.lblFriesPrice.Size = new System.Drawing.Size(332, 23);
            this.lblFriesPrice.TabIndex = 4;
            this.lblFriesPrice.Text = ".....";
            this.lblFriesPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDrinkPrice
            // 
            this.lblDrinkPrice.Location = new System.Drawing.Point(355, 121);
            this.lblDrinkPrice.Name = "lblDrinkPrice";
            this.lblDrinkPrice.Size = new System.Drawing.Size(332, 23);
            this.lblDrinkPrice.TabIndex = 5;
            this.lblDrinkPrice.Text = ".....";
            this.lblDrinkPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpDesert
            // 
            this.grpDesert.Controls.Add(this.radIceCream);
            this.grpDesert.Controls.Add(this.radCake);
            this.grpDesert.Location = new System.Drawing.Point(34, 233);
            this.grpDesert.Name = "grpDesert";
            this.grpDesert.Size = new System.Drawing.Size(722, 102);
            this.grpDesert.TabIndex = 1;
            this.grpDesert.TabStop = false;
            this.grpDesert.Text = "Free Desert";
            // 
            // radCake
            // 
            this.radCake.AutoSize = true;
            this.radCake.Location = new System.Drawing.Point(20, 40);
            this.radCake.Name = "radCake";
            this.radCake.Size = new System.Drawing.Size(61, 21);
            this.radCake.TabIndex = 0;
            this.radCake.TabStop = true;
            this.radCake.Text = "Cake";
            this.radCake.UseVisualStyleBackColor = true;
            // 
            // radIceCream
            // 
            this.radIceCream.AutoSize = true;
            this.radIceCream.Location = new System.Drawing.Point(361, 40);
            this.radIceCream.Name = "radIceCream";
            this.radIceCream.Size = new System.Drawing.Size(92, 21);
            this.radIceCream.TabIndex = 1;
            this.radIceCream.TabStop = true;
            this.radIceCream.Text = "Ice Cream";
            this.radIceCream.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(622, 366);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(134, 48);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblReceipt
            // 
            this.lblReceipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceipt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipt.Location = new System.Drawing.Point(34, 442);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(485, 236);
            this.lblReceipt.TabIndex = 3;
            this.lblReceipt.Text = "Receipt";
            // 
            // HamburgerStand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpDesert);
            this.Controls.Add(this.grpOrderMenu);
            this.Name = "HamburgerStand";
            this.Text = "Hamburger Stand";
            this.grpOrderMenu.ResumeLayout(false);
            this.grpOrderMenu.PerformLayout();
            this.grpDesert.ResumeLayout(false);
            this.grpDesert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderMenu;
        private System.Windows.Forms.Label lblDrinkPrice;
        private System.Windows.Forms.Label lblFriesPrice;
        private System.Windows.Forms.Label lblHamburgerPrice;
        private System.Windows.Forms.CheckBox chkDrink;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.CheckBox chkHamburger;
        private System.Windows.Forms.GroupBox grpDesert;
        private System.Windows.Forms.RadioButton radIceCream;
        private System.Windows.Forms.RadioButton radCake;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblReceipt;
    }
}

