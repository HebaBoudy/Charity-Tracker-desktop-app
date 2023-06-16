namespace DBapplication
{
    partial class Blood_Dep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blood_Dep));
            this.addBloodDon = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewBloodDonations = new System.Windows.Forms.Button();
            this.pullStock = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // addBloodDon
            // 
            this.addBloodDon.BackColor = System.Drawing.Color.SteelBlue;
            this.addBloodDon.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBloodDon.ForeColor = System.Drawing.Color.AliceBlue;
            this.addBloodDon.Location = new System.Drawing.Point(13, 164);
            this.addBloodDon.Name = "addBloodDon";
            this.addBloodDon.Size = new System.Drawing.Size(247, 73);
            this.addBloodDon.TabIndex = 0;
            this.addBloodDon.Text = "Add Blood Donation";
            this.addBloodDon.UseVisualStyleBackColor = false;
            this.addBloodDon.Click += new System.EventHandler(this.addBloodDon_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.SteelBlue;
            this.logout.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.AliceBlue;
            this.logout.Location = new System.Drawing.Point(326, 311);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(247, 73);
            this.logout.TabIndex = 1;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blood Donations Department";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewBloodDonations
            // 
            this.viewBloodDonations.BackColor = System.Drawing.Color.SteelBlue;
            this.viewBloodDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBloodDonations.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBloodDonations.ForeColor = System.Drawing.Color.White;
            this.viewBloodDonations.Location = new System.Drawing.Point(326, 164);
            this.viewBloodDonations.Name = "viewBloodDonations";
            this.viewBloodDonations.Size = new System.Drawing.Size(247, 73);
            this.viewBloodDonations.TabIndex = 3;
            this.viewBloodDonations.Text = "View Donations";
            this.viewBloodDonations.UseVisualStyleBackColor = false;
            this.viewBloodDonations.Click += new System.EventHandler(this.button1_Click);
            // 
            // pullStock
            // 
            this.pullStock.BackColor = System.Drawing.Color.SteelBlue;
            this.pullStock.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pullStock.ForeColor = System.Drawing.Color.AliceBlue;
            this.pullStock.Location = new System.Drawing.Point(14, 311);
            this.pullStock.Name = "pullStock";
            this.pullStock.Size = new System.Drawing.Size(247, 73);
            this.pullStock.TabIndex = 4;
            this.pullStock.Text = "Pull From Stock";
            this.pullStock.UseVisualStyleBackColor = false;
            this.pullStock.Click += new System.EventHandler(this.pullStock_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(513, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Blood_Dep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 479);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pullStock);
            this.Controls.Add(this.viewBloodDonations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.addBloodDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Blood_Dep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood_Dep";
            this.Load += new System.EventHandler(this.Blood_Dep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBloodDon;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewBloodDonations;
        private System.Windows.Forms.Button pullStock;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}