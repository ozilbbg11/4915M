namespace _4915M
{
    partial class StockInformationFrom
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
            this.stockInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.partsNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Smart & Luxury Motor Company (Spares)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Stock Information System";
            // 
            // stockInfoDataGridView
            // 
            this.stockInfoDataGridView.AllowUserToAddRows = false;
            this.stockInfoDataGridView.AllowUserToDeleteRows = false;
            this.stockInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockInfoDataGridView.Location = new System.Drawing.Point(23, 103);
            this.stockInfoDataGridView.Name = "stockInfoDataGridView";
            this.stockInfoDataGridView.ReadOnly = true;
            this.stockInfoDataGridView.RowTemplate.Height = 24;
            this.stockInfoDataGridView.Size = new System.Drawing.Size(749, 339);
            this.stockInfoDataGridView.TabIndex = 21;
            this.stockInfoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockInfoDataGridView_CellContentClick_1);
            // 
            // partsNum
            // 
            this.partsNum.Location = new System.Drawing.Point(116, 61);
            this.partsNum.Name = "partsNum";
            this.partsNum.Size = new System.Drawing.Size(150, 20);
            this.partsNum.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Parts Number :";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(614, 449);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(159, 30);
            this.SearchBtn.TabIndex = 24;
            this.SearchBtn.Text = "Search Pats";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenuBtn.Location = new System.Drawing.Point(671, 47);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(102, 30);
            this.MainMenuBtn.TabIndex = 25;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Display All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.all_Click);
            // 
            // StockInformationFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4915M.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.partsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stockInfoDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockInformationFrom";
            this.Text = "StockInformation";
            this.Load += new System.EventHandler(this.StockInformationFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stockInfoDataGridView;
        private System.Windows.Forms.TextBox partsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Button button1;
    }
}