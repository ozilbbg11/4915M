namespace _4915M
{
    partial class EditOrder
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
            this.PartsDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchPartsBtn = new System.Windows.Forms.Button();
            this.PartsNumTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PartsSearchTxtbox = new System.Windows.Forms.TextBox();
            this.AddPartsBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.CommonTxtbox = new System.Windows.Forms.GroupBox();
            this.qtyTxtbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.OrderNoTxtbox = new System.Windows.Forms.TextBox();
            this.orderData = new System.Windows.Forms.DataGridView();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.checkNoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).BeginInit();
            this.CommonTxtbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderData)).BeginInit();
            this.SuspendLayout();
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
            // PartsNumTxtbox
            // 
            this.PartsNumTxtbox.Location = new System.Drawing.Point(149, 399);
            this.PartsNumTxtbox.Name = "PartsNumTxtbox";
            this.PartsNumTxtbox.Size = new System.Drawing.Size(150, 20);
            this.PartsNumTxtbox.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 138;
            this.label3.Text = "Parts Number :";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(541, 392);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(102, 32);
            this.AddBtn.TabIndex = 136;
            this.AddBtn.Text = "Add parts";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenuBtn.Location = new System.Drawing.Point(541, 46);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(102, 30);
            this.MainMenuBtn.TabIndex = 135;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 124;
            this.label10.Text = "Order Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(453, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Smart & Luxury Motor Company (Spares)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 120;
            this.label1.Text = "Edit Order";
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
            // PartsSearchTxtbox
            // 
            this.PartsSearchTxtbox.Location = new System.Drawing.Point(102, 22);
            this.PartsSearchTxtbox.Name = "PartsSearchTxtbox";
            this.PartsSearchTxtbox.Size = new System.Drawing.Size(150, 20);
            this.PartsSearchTxtbox.TabIndex = 8;
            // 
            // AddPartsBtn
            // 
            this.AddPartsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddPartsBtn.Location = new System.Drawing.Point(484, 597);
            this.AddPartsBtn.Name = "AddPartsBtn";
            this.AddPartsBtn.Size = new System.Drawing.Size(159, 30);
            this.AddPartsBtn.TabIndex = 123;
            this.AddPartsBtn.Text = "Submit";
            this.AddPartsBtn.UseVisualStyleBackColor = true;
            this.AddPartsBtn.Click += new System.EventHandler(this.AddPartsBtn_Click);
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
            this.CommonTxtbox.Location = new System.Drawing.Point(35, 121);
            this.CommonTxtbox.Name = "CommonTxtbox";
            this.CommonTxtbox.Size = new System.Drawing.Size(634, 261);
            this.CommonTxtbox.TabIndex = 134;
            this.CommonTxtbox.TabStop = false;
            this.CommonTxtbox.Text = "Order";
            // 
            // qtyTxtbox
            // 
            this.qtyTxtbox.Location = new System.Drawing.Point(358, 399);
            this.qtyTxtbox.Name = "qtyTxtbox";
            this.qtyTxtbox.Size = new System.Drawing.Size(69, 20);
            this.qtyTxtbox.TabIndex = 119;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 118;
            this.label13.Text = " QTY :";
            // 
            // OrderNoTxtbox
            // 
            this.OrderNoTxtbox.Location = new System.Drawing.Point(149, 77);
            this.OrderNoTxtbox.Name = "OrderNoTxtbox";
            this.OrderNoTxtbox.Size = new System.Drawing.Size(173, 20);
            this.OrderNoTxtbox.TabIndex = 129;
            // 
            // orderData
            // 
            this.orderData.AllowUserToAddRows = false;
            this.orderData.AllowUserToDeleteRows = false;
            this.orderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderData.Location = new System.Drawing.Point(72, 438);
            this.orderData.Name = "orderData";
            this.orderData.ReadOnly = true;
            this.orderData.RowTemplate.Height = 24;
            this.orderData.Size = new System.Drawing.Size(571, 137);
            this.orderData.TabIndex = 122;
            this.orderData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderData_CellContentClick_1);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(433, 392);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(102, 32);
            this.RemoveBtn.TabIndex = 136;
            this.RemoveBtn.Text = "Remove parts";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // checkNoBtn
            // 
            this.checkNoBtn.Location = new System.Drawing.Point(350, 75);
            this.checkNoBtn.Name = "checkNoBtn";
            this.checkNoBtn.Size = new System.Drawing.Size(122, 22);
            this.checkNoBtn.TabIndex = 137;
            this.checkNoBtn.Text = "Check Details";
            this.checkNoBtn.UseVisualStyleBackColor = true;
            this.checkNoBtn.Click += new System.EventHandler(this.checkNoBtn_Click);
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::_4915M.Properties.Resources.istockphoto_862601036_612x612;
            this.ClientSize = new System.Drawing.Size(715, 648);
            this.Controls.Add(this.PartsNumTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkNoBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPartsBtn);
            this.Controls.Add(this.CommonTxtbox);
            this.Controls.Add(this.qtyTxtbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.OrderNoTxtbox);
            this.Controls.Add(this.orderData);
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.Load += new System.EventHandler(this.EditOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGridView)).EndInit();
            this.CommonTxtbox.ResumeLayout(false);
            this.CommonTxtbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PartsDataGridView;
        private System.Windows.Forms.Button SearchPartsBtn;
        private System.Windows.Forms.TextBox PartsNumTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PartsSearchTxtbox;
        private System.Windows.Forms.Button AddPartsBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox CommonTxtbox;
        private System.Windows.Forms.TextBox qtyTxtbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox OrderNoTxtbox;
        private System.Windows.Forms.DataGridView orderData;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button checkNoBtn;
    }
}