namespace DemoDatabaseApp
    {
    partial class SaleForm
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
            this.lblPosSystem = new System.Windows.Forms.Label();
            this.lblSaleMaster = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.cmbOrderDate = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblSeller = new System.Windows.Forms.Label();
            this.cmbSeller = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.lblProductList = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCart = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colCartProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPosSystem
            // 
            this.lblPosSystem.AutoSize = true;
            this.lblPosSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosSystem.Location = new System.Drawing.Point(16, 11);
            this.lblPosSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosSystem.Name = "lblPosSystem";
            this.lblPosSystem.Size = new System.Drawing.Size(136, 25);
            this.lblPosSystem.TabIndex = 0;
            this.lblPosSystem.Text = "POS System";
            // 
            // lblSaleMaster
            // 
            this.lblSaleMaster.AutoSize = true;
            this.lblSaleMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleMaster.Location = new System.Drawing.Point(17, 49);
            this.lblSaleMaster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaleMaster.Name = "lblSaleMaster";
            this.lblSaleMaster.Size = new System.Drawing.Size(110, 20);
            this.lblSaleMaster.TabIndex = 1;
            this.lblSaleMaster.Text = "Sale Master";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(27, 95);
            this.lblInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(74, 16);
            this.lblInvoiceNo.TabIndex = 2;
            this.lblInvoiceNo.Text = "Invoice No.";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(31, 114);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(159, 22);
            this.txtInvoiceNo.TabIndex = 3;
            this.txtInvoiceNo.Text = "20250608000025";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(208, 95);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(73, 16);
            this.lblOrderDate.TabIndex = 4;
            this.lblOrderDate.Text = "Order Date";
            // 
            // cmbOrderDate
            // 
            this.cmbOrderDate.FormattingEnabled = true;
            this.cmbOrderDate.Location = new System.Drawing.Point(212, 113);
            this.cmbOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrderDate.Name = "cmbOrderDate";
            this.cmbOrderDate.Size = new System.Drawing.Size(159, 24);
            this.cmbOrderDate.TabIndex = 5;
            this.cmbOrderDate.Text = "2025-06-08 14:2";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(389, 95);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(64, 16);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "Customer";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(393, 113);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(159, 24);
            this.cmbCustomer.TabIndex = 7;
            this.cmbCustomer.Text = "Walk-in";
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Location = new System.Drawing.Point(571, 95);
            this.lblSeller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(42, 16);
            this.lblSeller.TabIndex = 8;
            this.lblSeller.Text = "Seller";
            // 
            // cmbSeller
            // 
            this.cmbSeller.FormattingEnabled = true;
            this.cmbSeller.Location = new System.Drawing.Point(575, 113);
            this.cmbSeller.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSeller.Name = "cmbSeller";
            this.cmbSeller.Size = new System.Drawing.Size(159, 24);
            this.cmbSeller.TabIndex = 9;
            this.cmbSeller.Text = "aPhik.seng";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.LightBlue;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(905, 111);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 31);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCoral;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1013, 111);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 31);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(4, 6);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 18);
            this.lblCategory.TabIndex = 12;
            this.lblCategory.Text = "Category";
            // 
            // lstCategory
            // 
            this.lstCategory.BackColor = System.Drawing.Color.LightGray;
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.ItemHeight = 16;
            this.lstCategory.Items.AddRange(new object[] {
            "testing3Beer",
            "testing2Wine",
            "testing3333testing3"});
            this.lstCategory.Location = new System.Drawing.Point(8, 28);
            this.lstCategory.Margin = new System.Windows.Forms.Padding(4);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(225, 388);
            this.lstCategory.TabIndex = 13;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.Location = new System.Drawing.Point(4, 6);
            this.lblProductList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(99, 18);
            this.lblProductList.TabIndex = 14;
            this.lblProductList.Text = "Product List";
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductId,
            this.colProductName});
            this.dgvProductList.Location = new System.Drawing.Point(8, 28);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(353, 389);
            this.dgvProductList.TabIndex = 15;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // colProductId
            // 
            this.colProductId.HeaderText = "Product ID";
            this.colProductId.MinimumWidth = 6;
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Width = 80;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 160;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(4, 6);
            this.lblCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(40, 18);
            this.lblCart.TabIndex = 16;
            this.lblCart.Text = "Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCartProductName,
            this.colCartQty,
            this.colCartPrice,
            this.colCartAmount});
            this.dgvCart.Location = new System.Drawing.Point(8, 28);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(564, 308);
            this.dgvCart.TabIndex = 17;
            this.dgvCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellValueChanged);
            this.dgvCart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCart_KeyDown);
            // 
            // colCartProductName
            // 
            this.colCartProductName.HeaderText = "Product Name";
            this.colCartProductName.MinimumWidth = 6;
            this.colCartProductName.Name = "colCartProductName";
            this.colCartProductName.ReadOnly = true;
            this.colCartProductName.Width = 150;
            // 
            // colCartQty
            // 
            this.colCartQty.HeaderText = "Qty";
            this.colCartQty.MinimumWidth = 6;
            this.colCartQty.Name = "colCartQty";
            this.colCartQty.Width = 60;
            // 
            // colCartPrice
            // 
            this.colCartPrice.HeaderText = "Price";
            this.colCartPrice.MinimumWidth = 6;
            this.colCartPrice.Name = "colCartPrice";
            this.colCartPrice.Width = 80;
            // 
            // colCartAmount
            // 
            this.colCartAmount.HeaderText = "Amount";
            this.colCartAmount.MinimumWidth = 6;
            this.colCartAmount.Name = "colCartAmount";
            this.colCartAmount.ReadOnly = true;
            this.colCartAmount.Width = 90;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(8, 351);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Location = new System.Drawing.Point(208, 379);
            this.lblTotalQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(27, 16);
            this.lblTotalQty.TabIndex = 19;
            this.lblTotalQty.Text = "Qty";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(315, 379);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(38, 16);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.Text = "Price";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(452, 379);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(52, 16);
            this.lblTotalAmount.TabIndex = 21;
            this.lblTotalAmount.Text = "Amount";
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.BackColor = System.Drawing.Color.LightYellow;
            this.txtTotalQty.Location = new System.Drawing.Point(208, 399);
            this.txtTotalQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.ReadOnly = true;
            this.txtTotalQty.Size = new System.Drawing.Size(79, 22);
            this.txtTotalQty.TabIndex = 22;
            this.txtTotalQty.Text = "0";
            this.txtTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.LightYellow;
            this.txtTotalPrice.Location = new System.Drawing.Point(315, 399);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(105, 22);
            this.txtTotalPrice.TabIndex = 23;
            this.txtTotalPrice.Text = "0.00";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.LightYellow;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(452, 399);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(119, 24);
            this.txtTotalAmount.TabIndex = 24;
            this.txtTotalAmount.Text = "0.00";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lstCategory);
            this.panel1.Location = new System.Drawing.Point(21, 217);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 430);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblProductList);
            this.panel2.Controls.Add(this.dgvProductList);
            this.panel2.Location = new System.Drawing.Point(272, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 430);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCart);
            this.panel3.Controls.Add(this.dgvCart);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.txtTotalAmount);
            this.panel3.Controls.Add(this.lblTotalQty);
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.lblTotalPrice);
            this.panel3.Controls.Add(this.txtTotalQty);
            this.panel3.Controls.Add(this.lblTotalAmount);
            this.panel3.Location = new System.Drawing.Point(653, 217);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(586, 430);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblSaleMaster);
            this.panel4.Controls.Add(this.lblInvoiceNo);
            this.panel4.Controls.Add(this.txtInvoiceNo);
            this.panel4.Controls.Add(this.lblOrderDate);
            this.panel4.Controls.Add(this.cmbOrderDate);
            this.panel4.Controls.Add(this.lblCustomer);
            this.panel4.Controls.Add(this.cmbCustomer);
            this.panel4.Controls.Add(this.lblSeller);
            this.panel4.Controls.Add(this.cmbSeller);
            this.panel4.Controls.Add(this.btnOrder);
            this.panel4.Controls.Add(this.btnReset);
            this.panel4.Location = new System.Drawing.Point(21, 40);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1218, 162);
            this.panel4.TabIndex = 28;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1259, 694);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPosSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label lblPosSystem;
        private System.Windows.Forms.Label lblSaleMaster;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.ComboBox cmbOrderDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.ComboBox cmbSeller;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        }
    }