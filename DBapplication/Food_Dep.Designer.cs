namespace DBapplication
{
    partial class Food_Dep
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
            this.logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.viewFoodDonations = new System.Windows.Forms.Button();
            this.pullStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.SteelBlue;
            this.logout.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.AliceBlue;
            this.logout.Location = new System.Drawing.Point(496, 265);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(247, 73);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(64, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Food";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewFoodDonations
            // 
            this.viewFoodDonations.BackColor = System.Drawing.Color.SteelBlue;
            this.viewFoodDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewFoodDonations.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFoodDonations.ForeColor = System.Drawing.Color.White;
            this.viewFoodDonations.Location = new System.Drawing.Point(496, 95);
            this.viewFoodDonations.Name = "viewFoodDonations";
            this.viewFoodDonations.Size = new System.Drawing.Size(247, 73);
            this.viewFoodDonations.TabIndex = 5;
            this.viewFoodDonations.Text = "View Donations";
            this.viewFoodDonations.UseVisualStyleBackColor = false;
            this.viewFoodDonations.Click += new System.EventHandler(this.viewFoodDonations_Click);
            // 
            // pullStock
            // 
            this.pullStock.BackColor = System.Drawing.Color.SteelBlue;
            this.pullStock.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pullStock.ForeColor = System.Drawing.Color.AliceBlue;
            this.pullStock.Location = new System.Drawing.Point(64, 265);
            this.pullStock.Name = "pullStock";
            this.pullStock.Size = new System.Drawing.Size(247, 73);
            this.pullStock.TabIndex = 6;
            this.pullStock.Text = "Pull From Stock";
            this.pullStock.UseVisualStyleBackColor = false;
            this.pullStock.Click += new System.EventHandler(this.pullStock_Click);
            // 
            // Food_Dep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pullStock);
            this.Controls.Add(this.viewFoodDonations);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logout);
            this.Name = "Food_Dep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food_Dep";
            this.Load += new System.EventHandler(this.Food_Dep_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewFoodDonations;
        private System.Windows.Forms.Button pullStock;
    }
}