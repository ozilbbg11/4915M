namespace _4915M
{
    partial class Purchase_Order
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
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.PartsSearchTxtbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CommonTxtbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PartsDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchPartsBtn = new System.Windows.Forms.Button();
            this.qtyTxtbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TelTxtbox = new System.Windows.Forms.TextBox();
            this.AddressTxtbox = new System.Windows.Forms.TextBox();
            this.CusNoTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AddPartsBtn = new System.Windows.Forms.Button();
            this.orderData = new System.Windows.Forms.DataGridView();
            this.PartNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StreetTxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AreaTxtbox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.checkNoBtn = new System.Windows.Forms.Button();
            this.PartsNumTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CommonTxtbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderData)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenuBtn.Location = new System.Drawing.Point(551, 36);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(102, 30);
            this.MainMenuBtn.TabIndex = 113;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // PartsSearchTxtbox
            // 
            this.PartsSearchTxtbox.Location = new System.Drawing.Point(102, 22);
            this.PartsSearchTxtbox.Name = "PartsSearchTxtbox";
            this.PartsSearchTxtbox.Size = new System.Drawing.Size(150, 20);
            this.PartsSearchTxtbox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Parts Search :";
            // 
            // CommonTxtbox
            // 
            this.CommonTxtbox.Controls.Add(this.button1);
            this.CommonTxtbox.Controls.Add(this.PartsDataGridView);
            this.CommonTxtbox.Controls.Add(this.SearchPartsBtn);
            this.CommonTxtbox.Controls.Add(this.PartsSearchTxtbox);
            this.CommonTxtbox.Controls.Add(this.label12);
            this.CommonTxtbox.Location = new System.Drawing.Point(45, 222);
            this.CommonTxtbox.Name = "CommonTxtbox";
            this.CommonTxtbox.Size = new System.Drawing.Size(634, 261);
            this.CommonTxtbox.TabIndex = 110;
            this.CommonTxtbox.TabStop = false;
            this.CommonTxtbox.Text = "Order";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 116;
            this.button1.Text = "Display All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PartsDataGridView
            // 
            this.PartsDataGridView.AllowUserToAddRows = false;
            this.PartsDataGridView.AllowUserToDeleteRows = false;
            this.PartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGridView.Location = new System.Drawing.Point(31, 57);
            this.PartsDataGridView.Name = "PartsDataGridView";
            this.PartsDataGridView.ReadOnly = true;
            this.PartsDataGridView.RowTemplate.Height = 24;
            this.PartsDataGridView.Size = new System.Drawing.Size(577, 168);
            this.PartsDataGridView.TabIndex = 10;
            this.PartsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDataGridView_CellContentClick);
            // 
            // SearchPartsBtn
            // 
            this.SearchPartsBtn.Location = new System.Drawing.Point(449, 16);
            this.SearchPartsBtn.Name = "SearchPartsBtn";
            this.SearchPartsBtn.Size = new System.Drawing.Size(159, 30);
            this.SearchPartsBtn.TabIndex = 9;
            this.SearchPartsBtn.Text = "Search Parts";
            this.SearchPartsBtn.UseVisualStyleBackColor = true;
            this.SearchPartsBtn.Click += new System.EventHandler(this.SearchPartsBtn_Click);
            // 
            // qtyTxtbox
            // 
            this.qtyTxtbox.Location = new System.Drawing.Point(368, 500);
            this.qtyTxtbox.Name = "qtyTxtbox";
            this.qtyTxtbox.Size = new System.Drawing.Size(69, 20);
            this.qtyTxtbox.TabIndex = 91;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 503);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = " QTY :";
            // 
            // TelTxtbox
            // 
            this.TelTxtbox.Location = new System.Drawing.Point(159, 171);
            this.TelTxtbox.Name = "TelTxtbox";
            this.TelTxtbox.ReadOnly = true;
            this.TelTxtbox.Size = new System.Drawing.Size(173, 20);
            this.TelTxtbox.TabIndex = 108;
            // 
            // AddressTxtbox
            // 
            this.AddressTxtbox.Location = new System.Drawing.Point(159, 93);
            this.AddressTxtbox.Name = "AddressTxtbox";
            this.AddressTxtbox.ReadOnly = true;
            this.AddressTxtbox.Size = new System.Drawing.Size(173, 20);
            this.AddressTxtbox.TabIndex = 107;
            // 
            // CusNoTxtbox
            // 
            this.CusNoTxtbox.Location = new System.Drawing.Point(159, 67);
            this.CusNoTxtbox.Name = "CusNoTxtbox";
            this.CusNoTxtbox.Size = new System.Drawing.Size(173, 20);
            this.CusNoTxtbox.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "Telephone Number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 102;
            this.label9.Text = "Address :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Customer Number :";
            // 
            // AddPartsBtn
            // 
            this.AddPartsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddPartsBtn.Location = new System.Drawing.Point(494, 698);
            this.AddPartsBtn.Name = "AddPartsBtn";
            this.AddPartsBtn.Size = new System.Drawing.Size(159, 30);
            this.AddPartsBtn.TabIndex = 99;
            this.AddPartsBtn.Text = "Submit";
            this.AddPartsBtn.UseVisualStyleBackColor = true;
            this.AddPartsBtn.Click += new System.EventHandler(this.AddPartsBtn_Click);
            // 
            // orderData
            // 
            this.orderData.AllowUserToAddRows = false;
            this.orderData.AllowUserToDeleteRows = false;
            this.orderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartNum,
            this.PartName,
            this.quantity,
            this.UnitPrice});
            this.orderData.Location = new System.Drawing.Point(82, 539);
            this.orderData.Name = "orderData";
            this.orderData.ReadOnly = true;
            this.orderData.RowTemplate.Height = 24;
            this.orderData.Size = new System.Drawing.Size(571, 137);
            this.orderData.TabIndex = 98;
            // 
            // PartNum
            // 
            this.PartNum.HeaderText = "Part Number";
            this.PartNum.Name = "PartNum";
            this.PartNum.ReadOnly = true;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Part Name";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(463, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Smart & Luxury Motor Company (Spares)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 92;
            this.label1.Text = "Purchase Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Street :";
            // 
            // StreetTxtbox
            // 
            this.StreetTxtbox.Location = new System.Drawing.Point(159, 119);
            this.StreetTxtbox.Name = "StreetTxtbox";
            this.StreetTxtbox.ReadOnly = true;
            this.StreetTxtbox.Size = new System.Drawing.Size(173, 20);
            this.StreetTxtbox.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 102;
            this.label6.Text = "Area :";
            // 
            // AreaTxtbox
            // 
            this.AreaTxtbox.Location = new System.Drawing.Point(159, 145);
            this.AreaTxtbox.Name = "AreaTxtbox";
            this.AreaTxtbox.ReadOnly = true;
            this.AreaTxtbox.Size = new System.Drawing.Size(173, 20);
            this.AreaTxtbox.TabIndex = 107;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(504, 493);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(149, 32);
            this.AddBtn.TabIndex = 114;
            this.AddBtn.Text = "Add parts";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // checkNoBtn
            // 
            this.checkNoBtn.Location = new System.Drawing.Point(360, 65);
            this.checkNoBtn.Name = "checkNoBtn";
            this.checkNoBtn.Size = new System.Drawing.Size(122, 22);
            this.checkNoBtn.TabIndex = 115;
            this.checkNoBtn.Text = "Check Details";
            this.checkNoBtn.UseVisualStyleBackColor = true;
            this.checkNoBtn.Click += new System.EventHandler(this.checkNoBtn_Click);
            // 
            // PartsNumTxtbox
            // 
            this.PartsNumTxtbox.Location = new System.Drawing.Point(159, 500);
            this.PartsNumTxtbox.Name = "PartsNumTxtbox";
            this.PartsNumTxtbox.Size = new System.Drawing.Size(150, 20);
            this.PartsNumTxtbox.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Parts Number :";
            // 
            // Purchase_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::_4915M.Properties.Resources.images__2_;
            this.ClientSize = new System.Drawing.Size(705, 773);
            this.Controls.Add(this.PartsNumTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkNoBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.CommonTxtbox);
            this.Controls.Add(this.qtyTxtbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TelTxtbox);
            this.Controls.Add(this.AreaTxtbox);
            this.Controls.Add(this.StreetTxtbox);
            this.Controls.Add(this.AddressTxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CusNoTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AddPartsBtn);
            this.Controls.Add(this.orderData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Purchase_Order";
            this.Text = "Purchase_Order";
            this.Load += new System.EventHandler(this.Purchase_Order_Load);
            this.CommonTxtbox.ResumeLayout(false);
            this.CommonTxtbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.TextBox PartsSearchTxtbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox CommonTxtbox;
        private System.Windows.Forms.DataGridView PartsDataGridView;
        private System.Windows.Forms.Button SearchPartsBtn;
        private System.Windows.Forms.TextBox qtyTxtbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TelTxtbox;
        private System.Windows.Forms.TextBox AddressTxtbox;
        private System.Windows.Forms.TextBox CusNoTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddPartsBtn;
        private System.Windows.Forms.DataGridView orderData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StreetTxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AreaTxtbox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button checkNoBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PartsNumTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    }
}