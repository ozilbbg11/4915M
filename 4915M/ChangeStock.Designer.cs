namespace _4915M
{
    partial class ChangeStock
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PartsNumTxtbox = new System.Windows.Forms.TextBox();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductNameTxtbox = new System.Windows.Forms.TextBox();
            this.qtyTxt = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtReduce = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnConAdd = new System.Windows.Forms.Button();
            this.btnConRed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Smart & Luxury Motor Company (Spares)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change stock";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product ID :";
            // 
            // PartsNumTxtbox
            // 
            this.PartsNumTxtbox.Location = new System.Drawing.Point(115, 58);
            this.PartsNumTxtbox.Name = "PartsNumTxtbox";
            this.PartsNumTxtbox.Size = new System.Drawing.Size(150, 20);
            this.PartsNumTxtbox.TabIndex = 6;
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenuBtn.Location = new System.Drawing.Point(410, 44);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(102, 30);
            this.MainMenuBtn.TabIndex = 23;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Product Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Qty On Hand :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Qty to add :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Qty to reduce :";
            // 
            // ProductNameTxtbox
            // 
            this.ProductNameTxtbox.Location = new System.Drawing.Point(115, 106);
            this.ProductNameTxtbox.Name = "ProductNameTxtbox";
            this.ProductNameTxtbox.ReadOnly = true;
            this.ProductNameTxtbox.Size = new System.Drawing.Size(150, 20);
            this.ProductNameTxtbox.TabIndex = 28;
            // 
            // qtyTxt
            // 
            this.qtyTxt.Location = new System.Drawing.Point(115, 152);
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.ReadOnly = true;
            this.qtyTxt.Size = new System.Drawing.Size(150, 20);
            this.qtyTxt.TabIndex = 29;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(115, 251);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.ReadOnly = true;
            this.txtAdd.Size = new System.Drawing.Size(150, 20);
            this.txtAdd.TabIndex = 30;
            // 
            // txtReduce
            // 
            this.txtReduce.Location = new System.Drawing.Point(115, 286);
            this.txtReduce.Name = "txtReduce";
            this.txtReduce.ReadOnly = true;
            this.txtReduce.Size = new System.Drawing.Size(150, 20);
            this.txtReduce.TabIndex = 31;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(25, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnReduce
            // 
            this.btnReduce.Enabled = false;
            this.btnReduce.Location = new System.Drawing.Point(204, 201);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(75, 23);
            this.btnReduce.TabIndex = 33;
            this.btnReduce.Text = "Reduce";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.BtnReduce_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(288, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnConAdd
            // 
            this.btnConAdd.Enabled = false;
            this.btnConAdd.Location = new System.Drawing.Point(287, 318);
            this.btnConAdd.Name = "btnConAdd";
            this.btnConAdd.Size = new System.Drawing.Size(92, 39);
            this.btnConAdd.TabIndex = 35;
            this.btnConAdd.Text = "Confirm add";
            this.btnConAdd.UseVisualStyleBackColor = true;
            this.btnConAdd.Click += new System.EventHandler(this.BtnConAdd_Click);
            // 
            // btnConRed
            // 
            this.btnConRed.Enabled = false;
            this.btnConRed.Location = new System.Drawing.Point(410, 318);
            this.btnConRed.Name = "btnConRed";
            this.btnConRed.Size = new System.Drawing.Size(92, 39);
            this.btnConRed.TabIndex = 36;
            this.btnConRed.Text = "Confirm reduce";
            this.btnConRed.UseVisualStyleBackColor = true;
            this.btnConRed.Click += new System.EventHandler(this.BtnConRed_Click);
            // 
            // ChangeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4915M.Properties.Resources.istockphoto_862601036_612x6121;
            this.ClientSize = new System.Drawing.Size(580, 369);
            this.Controls.Add(this.btnConRed);
            this.Controls.Add(this.btnConAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtReduce);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.qtyTxt);
            this.Controls.Add(this.ProductNameTxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.PartsNumTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ChangeStock";
            this.Text = "ChangeStock";
            this.Load += new System.EventHandler(this.ChangeStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PartsNumTxtbox;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProductNameTxtbox;
        private System.Windows.Forms.TextBox qtyTxt;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtReduce;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnConAdd;
        private System.Windows.Forms.Button btnConRed;
    }
}