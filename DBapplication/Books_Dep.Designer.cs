namespace DBapplication
{
    partial class Books_Dep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books_Dep));
            this.label1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.viewBookDonations = new System.Windows.Forms.Button();
            this.pullStock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(257, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Department";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.SteelBlue;
            this.logout.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.AliceBlue;
            this.logout.Location = new System.Drawing.Point(437, 327);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(247, 73);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // viewBookDonations
            // 
            this.viewBookDonations.BackColor = System.Drawing.Color.SteelBlue;
            this.viewBookDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBookDonations.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookDonations.ForeColor = System.Drawing.Color.White;
            this.viewBookDonations.Location = new System.Drawing.Point(437, 215);
            this.viewBookDonations.Name = "viewBookDonations";
            this.viewBookDonations.Size = new System.Drawing.Size(247, 73);
            this.viewBookDonations.TabIndex = 4;
            this.viewBookDonations.Text = "View Donations";
            this.viewBookDonations.UseVisualStyleBackColor = false;
            this.viewBookDonations.Click += new System.EventHandler(this.viewBookDonations_Click);
            // 
            // pullStock
            // 
            this.pullStock.BackColor = System.Drawing.Color.SteelBlue;
            this.pullStock.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pullStock.ForeColor = System.Drawing.Color.AliceBlue;
            this.pullStock.Location = new System.Drawing.Point(55, 327);
            this.pullStock.Name = "pullStock";
            this.pullStock.Size = new System.Drawing.Size(247, 73);
            this.pullStock.TabIndex = 6;
            this.pullStock.Text = "Pull From Stock";
            this.pullStock.UseVisualStyleBackColor = false;
            this.pullStock.Click += new System.EventHandler(this.pullStock_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(55, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 73);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(747, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Books_Dep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pullStock);
            this.Controls.Add(this.viewBookDonations);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books_Dep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books_Dep";
            this.Load += new System.EventHandler(this.Books_Dep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button viewBookDonations;
        private System.Windows.Forms.Button pullStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}