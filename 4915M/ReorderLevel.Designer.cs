namespace _4915M
{
    partial class ReorderLevel
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataRnD = new System.Windows.Forms.DataGridView();
            this.btnCon = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DangerLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabDispatchBatch = new System.Windows.Forms.TabPage();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDispatchOrder = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataRnD)).BeginInit();
            this.tabDispatchBatch.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDispatchOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(447, 698);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gen All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataRnD
            // 
            this.dataRnD.AllowUserToAddRows = false;
            this.dataRnD.AllowUserToDeleteRows = false;
            this.dataRnD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRnD.Location = new System.Drawing.Point(19, 6);
            this.dataRnD.Name = "dataRnD";
            this.dataRnD.ReadOnly = true;
            this.dataRnD.Size = new System.Drawing.Size(456, 673);
            this.dataRnD.TabIndex = 0;
            // 
            // btnCon
            // 
            this.btnCon.Enabled = false;
            this.btnCon.Location = new System.Drawing.Point(619, 678);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(128, 41);
            this.btnCon.TabIndex = 128;
            this.btnCon.Text = "Confirm";
            this.btnCon.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.ProductName,
            this.Qty,
            this.DangerLevel});
            this.listView1.Location = new System.Drawing.Point(12, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(541, 621);
            this.listView1.TabIndex = 127;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ProductID
            // 
            this.ProductID.Text = "Product ID";
            this.ProductID.Width = 160;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 205;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 177;
            // 
            // DangerLevel
            // 
            this.DangerLevel.Text = "Action";
            this.DangerLevel.Width = 117;
            // 
            // tabDispatchBatch
            // 
            this.tabDispatchBatch.Controls.Add(this.button1);
            this.tabDispatchBatch.Controls.Add(this.dataRnD);
            this.tabDispatchBatch.Location = new System.Drawing.Point(4, 22);
            this.tabDispatchBatch.Name = "tabDispatchBatch";
            this.tabDispatchBatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabDispatchBatch.Size = new System.Drawing.Size(585, 725);
            this.tabDispatchBatch.TabIndex = 1;
            this.tabDispatchBatch.Text = "Generate Dispatch Notes in batch";
            this.tabDispatchBatch.UseVisualStyleBackColor = true;
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenuBtn.Location = new System.Drawing.Point(699, 81);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(102, 30);
            this.MainMenuBtn.TabIndex = 43;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(606, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Smart & Luxury Motor Company (Spares)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "Show Re-order/Danger Level ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDispatchBatch);
            this.tabControl1.Controls.Add(this.tabDispatchOrder);
            this.tabControl1.Location = new System.Drawing.Point(45, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 751);
            this.tabControl1.TabIndex = 44;
            // 
            // tabDispatchOrder
            // 
            this.tabDispatchOrder.Controls.Add(this.btnCon);
            this.tabDispatchOrder.Controls.Add(this.listView1);
            this.tabDispatchOrder.Location = new System.Drawing.Point(4, 22);
            this.tabDispatchOrder.Name = "tabDispatchOrder";
            this.tabDispatchOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabDispatchOrder.Size = new System.Drawing.Size(585, 725);
            this.tabDispatchOrder.TabIndex = 0;
            this.tabDispatchOrder.Text = "Generate Dispatch ( for each order )";
            this.tabDispatchOrder.UseVisualStyleBackColor = true;
            // 
            // ReorderLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4915M.Properties.Resources.istockphoto_862601036_612x612;
            this.ClientSize = new System.Drawing.Size(872, 908);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReorderLevel";
            this.Text = "ReorderLevel";
            this.Load += new System.EventHandler(this.ReorderLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRnD)).EndInit();
            this.tabDispatchBatch.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabDispatchOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataRnD;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader DangerLevel;
        private System.Windows.Forms.TabPage tabDispatchBatch;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDispatchOrder;
    }
}