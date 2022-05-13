namespace _4915M
{
    partial class SearchDealer
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
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.partsNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stockInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "Display All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenuBtn.Location = new System.Drawing.Point(679, 46);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(102, 30);
            this.MainMenuBtn.TabIndex = 33;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(622, 448);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(159, 30);
            this.SearchBtn.TabIndex = 32;
            this.SearchBtn.Text = "Search Dealer";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // partsNum
            // 
            this.partsNum.Location = new System.Drawing.Point(124, 60);
            this.partsNum.Name = "partsNum";
            this.partsNum.Size = new System.Drawing.Size(150, 20);
            this.partsNum.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Dealer Number :";
            // 
            // stockInfoDataGridView
            // 
            this.stockInfoDataGridView.AllowUserToAddRows = false;
            this.stockInfoDataGridView.AllowUserToDeleteRows = false;
            this.stockInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockInfoDataGridView.Location = new System.Drawing.Point(31, 102);
            this.stockInfoDataGridView.Name = "stockInfoDataGridView";
            this.stockInfoDataGridView.ReadOnly = true;
            this.stockInfoDataGridView.RowTemplate.Height = 24;
            this.stockInfoDataGridView.Size = new System.Drawing.Size(749, 339);
            this.stockInfoDataGridView.TabIndex = 29;
            this.stockInfoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockInfoDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Smart & Luxury Motor Company (Spares)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Search Dealer";
            // 
            // SearchDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::_4915M.Properties.Resources.istockphoto_862601036_612x612;
            this.ClientSize = new System.Drawing.Size(816, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.partsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stockInfoDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchDealer";
            this.Text = "SearchDealer";
            this.Load += new System.EventHandler(this.SearchDealer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox partsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView stockInfoDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}