namespace _4915M
{
    partial class SerachOrder
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
            this.orderNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.stockInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.custNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SearchDateBtn = new System.Windows.Forms.Button();
            this.SearchCustNoBtn = new System.Windows.Forms.Button();
            this.confirmOrderBtn = new System.Windows.Forms.Button();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenuBtn.Location = new System.Drawing.Point(1145, 46);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(102, 30);
            this.MainMenuBtn.TabIndex = 35;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // orderNum
            // 
            this.orderNum.Location = new System.Drawing.Point(110, 55);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(150, 20);
            this.orderNum.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Order Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "Manage Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1052, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Smart & Luxury Motor Company (Spares)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1150, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "Display All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(655, 456);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(159, 30);
            this.SearchBtn.TabIndex = 37;
            this.SearchBtn.Text = "Search By Order Number";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // stockInfoDataGridView
            // 
            this.stockInfoDataGridView.AllowUserToAddRows = false;
            this.stockInfoDataGridView.AllowUserToDeleteRows = false;
            this.stockInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockInfoDataGridView.Location = new System.Drawing.Point(30, 82);
            this.stockInfoDataGridView.Name = "stockInfoDataGridView";
            this.stockInfoDataGridView.ReadOnly = true;
            this.stockInfoDataGridView.RowTemplate.Height = 24;
            this.stockInfoDataGridView.Size = new System.Drawing.Size(1212, 339);
            this.stockInfoDataGridView.TabIndex = 36;
            this.stockInfoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockInfoDataGridView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Customer Number :";
            // 
            // custNum
            // 
            this.custNum.Location = new System.Drawing.Point(368, 55);
            this.custNum.Name = "custNum";
            this.custNum.Size = new System.Drawing.Size(150, 20);
            this.custNum.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Order Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(590, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.Value = new System.DateTime(2019, 7, 14, 0, 0, 0, 0);
            // 
            // SearchDateBtn
            // 
            this.SearchDateBtn.Location = new System.Drawing.Point(985, 456);
            this.SearchDateBtn.Name = "SearchDateBtn";
            this.SearchDateBtn.Size = new System.Drawing.Size(159, 30);
            this.SearchDateBtn.TabIndex = 37;
            this.SearchDateBtn.Text = "Search By Order Date";
            this.SearchDateBtn.UseVisualStyleBackColor = true;
            this.SearchDateBtn.Click += new System.EventHandler(this.SearchDateBtn_Click);
            // 
            // SearchCustNoBtn
            // 
            this.SearchCustNoBtn.Location = new System.Drawing.Point(820, 456);
            this.SearchCustNoBtn.Name = "SearchCustNoBtn";
            this.SearchCustNoBtn.Size = new System.Drawing.Size(159, 30);
            this.SearchCustNoBtn.TabIndex = 37;
            this.SearchCustNoBtn.Text = "Search By Customer Number";
            this.SearchCustNoBtn.UseVisualStyleBackColor = true;
            this.SearchCustNoBtn.Click += new System.EventHandler(this.SearchCustNoBtn_Click);
            // 
            // confirmOrderBtn
            // 
            this.confirmOrderBtn.Enabled = false;
            this.confirmOrderBtn.Location = new System.Drawing.Point(30, 456);
            this.confirmOrderBtn.Name = "confirmOrderBtn";
            this.confirmOrderBtn.Size = new System.Drawing.Size(92, 30);
            this.confirmOrderBtn.TabIndex = 38;
            this.confirmOrderBtn.Text = "Confirm Order";
            this.confirmOrderBtn.UseVisualStyleBackColor = true;
            this.confirmOrderBtn.Click += new System.EventHandler(this.confirmOrderBtn_Click);
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.Enabled = false;
            this.cancelOrderBtn.Location = new System.Drawing.Point(128, 456);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(92, 30);
            this.cancelOrderBtn.TabIndex = 38;
            this.cancelOrderBtn.Text = "Cancel Order";
            this.cancelOrderBtn.UseVisualStyleBackColor = true;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderBtn_Click);
            // 
            // SerachOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::_4915M.Properties.Resources.istockphoto_862601036_612x612;
            this.ClientSize = new System.Drawing.Size(1254, 498);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cancelOrderBtn);
            this.Controls.Add(this.confirmOrderBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchCustNoBtn);
            this.Controls.Add(this.SearchDateBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.stockInfoDataGridView);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.custNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "SerachOrder";
            this.Text = "SerachOrder";
            this.Load += new System.EventHandler(this.SerachOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.TextBox orderNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView stockInfoDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SearchDateBtn;
        private System.Windows.Forms.Button SearchCustNoBtn;
        private System.Windows.Forms.Button confirmOrderBtn;
        private System.Windows.Forms.Button cancelOrderBtn;
    }
}