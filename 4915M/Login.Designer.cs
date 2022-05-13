namespace _4915M
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.PwTxtbox = new System.Windows.Forms.TextBox();
            this.UserTxtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.slmcDataSet = new _4915M.slmcDataSet();
            this.slmcDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slmcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slmcDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PwTxtbox
            // 
            this.PwTxtbox.Location = new System.Drawing.Point(139, 107);
            this.PwTxtbox.Name = "PwTxtbox";
            this.PwTxtbox.PasswordChar = '*';
            this.PwTxtbox.Size = new System.Drawing.Size(173, 20);
            this.PwTxtbox.TabIndex = 63;
            // 
            // UserTxtbox
            // 
            this.UserTxtbox.Location = new System.Drawing.Point(139, 74);
            this.UserTxtbox.Name = "UserTxtbox";
            this.UserTxtbox.Size = new System.Drawing.Size(173, 20);
            this.UserTxtbox.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(21, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Password :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(22, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Staff Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Smart & Luxury Motor Company (Spares)";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.LoginBtn.Location = new System.Drawing.Point(85, 160);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(159, 30);
            this.LoginBtn.TabIndex = 70;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // slmcDataSet
            // 
            this.slmcDataSet.DataSetName = "slmcDataSet";
            this.slmcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slmcDataSetBindingSource
            // 
            this.slmcDataSetBindingSource.DataSource = this.slmcDataSet;
            this.slmcDataSetBindingSource.Position = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4915M.Properties.Resources._2a6d3eb31bc730c75eac34d77ff0d40d;
            this.pictureBox1.Location = new System.Drawing.Point(368, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 160);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(794, 248);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PwTxtbox);
            this.Controls.Add(this.UserTxtbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slmcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slmcDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PwTxtbox;
        private System.Windows.Forms.TextBox UserTxtbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.BindingSource slmcDataSetBindingSource;
        private slmcDataSet slmcDataSet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}