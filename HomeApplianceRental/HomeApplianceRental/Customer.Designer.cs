namespace HomeApplianceRental
{
    partial class Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guideLabel = new System.Windows.Forms.LinkLabel();
            this.sortBtn = new System.Windows.Forms.Button();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.sortCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buyBtn = new System.Windows.Forms.Button();
            this.cartGrid = new System.Windows.Forms.DataGridView();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.costLbl = new System.Windows.Forms.Label();
            this.counterLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.Add_to_Cart = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Months_to_rent = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 98);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Appliance Rental";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.guideLabel);
            this.panel2.Controls.Add(this.sortBtn);
            this.panel2.Controls.Add(this.searchCombo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.sortCombo);
            this.panel2.Location = new System.Drawing.Point(384, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 98);
            this.panel2.TabIndex = 1;
            // 
            // guideLabel
            // 
            this.guideLabel.AutoSize = true;
            this.guideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guideLabel.LinkColor = System.Drawing.Color.Aqua;
            this.guideLabel.Location = new System.Drawing.Point(638, 49);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(239, 20);
            this.guideLabel.TabIndex = 7;
            this.guideLabel.TabStop = true;
            this.guideLabel.Text = "Don\'t know houw to use?_Guide";
            this.guideLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.guideLabel_LinkClicked);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(187, 35);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 6;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // searchCombo
            // 
            this.searchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Items.AddRange(new object[] {
            "TV",
            "fridge",
            "kettle",
            "washing machine",
            "microwave",
            "All"});
            this.searchCombo.Location = new System.Drawing.Point(284, 34);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(152, 24);
            this.searchCombo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(281, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sort By";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(453, 36);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortCombo
            // 
            this.sortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortCombo.FormattingEnabled = true;
            this.sortCombo.Items.AddRange(new object[] {
            "EnergyConsumption_WattPerHour",
            "MonthlyFee"});
            this.sortCombo.Location = new System.Drawing.Point(20, 34);
            this.sortCombo.Name = "sortCombo";
            this.sortCombo.Size = new System.Drawing.Size(152, 24);
            this.sortCombo.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add_to_Cart,
            this.Months_to_rent});
            this.dataGridView1.Location = new System.Drawing.Point(1, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1289, 345);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.buyBtn);
            this.panel3.Controls.Add(this.cartGrid);
            this.panel3.Controls.Add(this.cleanBtn);
            this.panel3.Controls.Add(this.costLbl);
            this.panel3.Controls.Add(this.counterLbl);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.addBtn);
            this.panel3.Location = new System.Drawing.Point(2, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1289, 375);
            this.panel3.TabIndex = 3;
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(1122, 312);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(119, 41);
            this.buyBtn.TabIndex = 5;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // cartGrid
            // 
            this.cartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGrid.Location = new System.Drawing.Point(10, 59);
            this.cartGrid.Name = "cartGrid";
            this.cartGrid.Size = new System.Drawing.Size(1078, 305);
            this.cartGrid.TabIndex = 4;
            // 
            // cleanBtn
            // 
            this.cleanBtn.Location = new System.Drawing.Point(1122, 266);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(119, 40);
            this.cleanBtn.TabIndex = 3;
            this.cleanBtn.Text = "Clean Cart";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.costLbl.Location = new System.Drawing.Point(1118, 182);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(14, 20);
            this.costLbl.TabIndex = 2;
            this.costLbl.Text = "-";
            // 
            // counterLbl
            // 
            this.counterLbl.AutoSize = true;
            this.counterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.counterLbl.Location = new System.Drawing.Point(1118, 118);
            this.counterLbl.Name = "counterLbl";
            this.counterLbl.Size = new System.Drawing.Size(14, 20);
            this.counterLbl.TabIndex = 2;
            this.counterLbl.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(1117, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(21, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1117, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Items in Cart: ";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1122, 220);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(119, 40);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add to Cart";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Add_to_Cart
            // 
            this.Add_to_Cart.DataPropertyName = "addToCart";
            this.Add_to_Cart.HeaderText = "Add_to_Cart";
            this.Add_to_Cart.Name = "Add_to_Cart";
            this.Add_to_Cart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Add_to_Cart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Months_to_rent
            // 
            this.Months_to_rent.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Months_to_rent.HeaderText = "Months_to_rent";
            this.Months_to_rent.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Months_to_rent.Name = "Months_to_rent";
            this.Months_to_rent.Width = 120;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 818);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox sortCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.DataGridView cartGrid;
        private System.Windows.Forms.Label counterLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel guideLabel;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add_to_Cart;
        private System.Windows.Forms.DataGridViewComboBoxColumn Months_to_rent;
    }
}