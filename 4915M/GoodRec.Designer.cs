namespace _4915M
{
    partial class GoodRec
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
            this.btnCan = new System.Windows.Forms.Button();
            this.staffTxtbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dDateTxtbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.oDateTxtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dNoTxtbox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brnCon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TelTxtbox = new System.Windows.Forms.TextBox();
            this.AreaTxtbox = new System.Windows.Forms.TextBox();
            this.StreetTxtbox = new System.Windows.Forms.TextBox();
            this.AddressTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenList = new System.Windows.Forms.Button();
            this.soNumTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(705, 816);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(100, 34);
            this.btnCan.TabIndex = 171;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.BtnCan_Click);
            // 
            // staffTxtbox
            // 
            this.staffTxtbox.Location = new System.Drawing.Point(629, 154);
            this.staffTxtbox.Name = "staffTxtbox";
            this.staffTxtbox.ReadOnly = true;
            this.staffTxtbox.Size = new System.Drawing.Size(173, 20);
            this.staffTxtbox.TabIndex = 168;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(527, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 167;
            this.label12.Text = "Staff number : ";
            // 
            // dDateTxtbox
            // 
            this.dDateTxtbox.Location = new System.Drawing.Point(165, 338);
            this.dDateTxtbox.Name = "dDateTxtbox";
            this.dDateTxtbox.ReadOnly = true;
            this.dDateTxtbox.Size = new System.Drawing.Size(173, 20);
            this.dDateTxtbox.TabIndex = 166;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 165;
            this.label11.Text = "Delivery Date :";
            // 
            // oDateTxtbox
            // 
            this.oDateTxtbox.Location = new System.Drawing.Point(165, 309);
            this.oDateTxtbox.Name = "oDateTxtbox";
            this.oDateTxtbox.ReadOnly = true;
            this.oDateTxtbox.Size = new System.Drawing.Size(173, 20);
            this.oDateTxtbox.TabIndex = 164;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 163;
            this.label10.Text = "Order Date :";
            // 
            // dNoTxtbox
            // 
            this.dNoTxtbox.Location = new System.Drawing.Point(168, 153);
            this.dNoTxtbox.Name = "dNoTxtbox";
            this.dNoTxtbox.ReadOnly = true;
            this.dNoTxtbox.Size = new System.Drawing.Size(173, 20);
            this.dNoTxtbox.TabIndex = 162;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Qty,
            this.ProductID,
            this.ProductName,
            this.UnitPrice});
            this.listView1.Location = new System.Drawing.Point(59, 379);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(748, 414);
            this.listView1.TabIndex = 169;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 141;
            // 
            // ProductID
            // 
            this.ProductID.Text = "Product ID";
            this.ProductID.Width = 114;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 188;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Unit Price";
            this.UnitPrice.Width = 138;
            // 
            // brnCon
            // 
            this.brnCon.Enabled = false;
            this.brnCon.Location = new System.Drawing.Point(569, 816);
            this.brnCon.Name = "brnCon";
            this.brnCon.Size = new System.Drawing.Size(100, 34);
            this.brnCon.TabIndex = 170;
            this.brnCon.Text = "Confirm";
            this.brnCon.UseVisualStyleBackColor = true;
            this.brnCon.Click += new System.EventHandler(this.BrnCon_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 161;
            this.label8.Text = "Dealer number : ";
            // 
            // TelTxtbox
            // 
            this.TelTxtbox.Location = new System.Drawing.Point(168, 261);
            this.TelTxtbox.Name = "TelTxtbox";
            this.TelTxtbox.ReadOnly = true;
            this.TelTxtbox.Size = new System.Drawing.Size(173, 20);
            this.TelTxtbox.TabIndex = 160;
            // 
            // AreaTxtbox
            // 
            this.AreaTxtbox.Location = new System.Drawing.Point(168, 235);
            this.AreaTxtbox.Name = "AreaTxtbox";
            this.AreaTxtbox.ReadOnly = true;
            this.AreaTxtbox.Size = new System.Drawing.Size(173, 20);
            this.AreaTxtbox.TabIndex = 157;
            // 
            // StreetTxtbox
            // 
            this.StreetTxtbox.Location = new System.Drawing.Point(168, 209);
            this.StreetTxtbox.Name = "StreetTxtbox";
            this.StreetTxtbox.ReadOnly = true;
            this.StreetTxtbox.Size = new System.Drawing.Size(173, 20);
            this.StreetTxtbox.TabIndex = 158;
            // 
            // AddressTxtbox
            // 
            this.AddressTxtbox.Location = new System.Drawing.Point(168, 183);
            this.AddressTxtbox.Name = "AddressTxtbox";
            this.AddressTxtbox.ReadOnly = true;
            this.AddressTxtbox.Size = new System.Drawing.Size(173, 20);
            this.AddressTxtbox.TabIndex = 159;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 154;
            this.label4.Text = "Street :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 156;
            this.label5.Text = "Telephone Number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 155;
            this.label9.Text = "Address :";
            // 
            // btnGenList
            // 
            this.btnGenList.Location = new System.Drawing.Point(362, 67);
            this.btnGenList.Name = "btnGenList";
            this.btnGenList.Size = new System.Drawing.Size(75, 23);
            this.btnGenList.TabIndex = 153;
            this.btnGenList.Text = "Gen List";
            this.btnGenList.UseVisualStyleBackColor = true;
            this.btnGenList.Click += new System.EventHandler(this.BtnGenList_Click);
            // 
            // soNumTxtbox
            // 
            this.soNumTxtbox.Location = new System.Drawing.Point(168, 70);
            this.soNumTxtbox.Name = "soNumTxtbox";
            this.soNumTxtbox.Size = new System.Drawing.Size(176, 20);
            this.soNumTxtbox.TabIndex = 152;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 151;
            this.label3.Text = "Sales Order Number : ";
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenuBtn.Location = new System.Drawing.Point(705, 57);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(102, 30);
            this.MainMenuBtn.TabIndex = 150;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 27);
            this.label1.TabIndex = 148;
            this.label1.Text = "Goods Received  List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(612, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 149;
            this.label2.Text = "Smart & Luxury Motor Company (Spares)";
            // 
            // GoodRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4915M.Properties.Resources.images__2_;
            this.ClientSize = new System.Drawing.Size(852, 863);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.staffTxtbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dDateTxtbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.oDateTxtbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dNoTxtbox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.brnCon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TelTxtbox);
            this.Controls.Add(this.AreaTxtbox);
            this.Controls.Add(this.StreetTxtbox);
            this.Controls.Add(this.AddressTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGenList);
            this.Controls.Add(this.soNumTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "GoodRec";
            this.Text = "GoodRec";
            this.Load += new System.EventHandler(this.GoodRec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.TextBox staffTxtbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dDateTxtbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox oDateTxtbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dNoTxtbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.Button brnCon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TelTxtbox;
        private System.Windows.Forms.TextBox AreaTxtbox;
        private System.Windows.Forms.TextBox StreetTxtbox;
        private System.Windows.Forms.TextBox AddressTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGenList;
        private System.Windows.Forms.TextBox soNumTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}