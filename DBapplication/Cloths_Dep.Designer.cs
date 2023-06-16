namespace DBapplication
{
    partial class Cloths_Dep
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
            this.addClothes = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.viewClothesDonations = new System.Windows.Forms.Button();
            this.pullStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addClothes
            // 
            this.addClothes.BackColor = System.Drawing.Color.SteelBlue;
            this.addClothes.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClothes.ForeColor = System.Drawing.Color.AliceBlue;
            this.addClothes.Location = new System.Drawing.Point(42, 88);
            this.addClothes.Name = "addClothes";
            this.addClothes.Size = new System.Drawing.Size(216, 73);
            this.addClothes.TabIndex = 0;
            this.addClothes.Text = "Add Clothes";
            this.addClothes.UseVisualStyleBackColor = false;
            this.addClothes.Click += new System.EventHandler(this.addClothes_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.SteelBlue;
            this.logout.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.AliceBlue;
            this.logout.Location = new System.Drawing.Point(423, 271);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(216, 73);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // viewClothesDonations
            // 
            this.viewClothesDonations.BackColor = System.Drawing.Color.SteelBlue;
            this.viewClothesDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewClothesDonations.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewClothesDonations.ForeColor = System.Drawing.Color.White;
            this.viewClothesDonations.Location = new System.Drawing.Point(423, 88);
            this.viewClothesDonations.Name = "viewClothesDonations";
            this.viewClothesDonations.Size = new System.Drawing.Size(216, 73);
            this.viewClothesDonations.TabIndex = 4;
            this.viewClothesDonations.Text = "View Donations";
            this.viewClothesDonations.UseVisualStyleBackColor = false;
            this.viewClothesDonations.Click += new System.EventHandler(this.viewClothesDonations_Click);
            // 
            // pullStock
            // 
            this.pullStock.BackColor = System.Drawing.Color.SteelBlue;
            this.pullStock.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pullStock.ForeColor = System.Drawing.Color.AliceBlue;
            this.pullStock.Location = new System.Drawing.Point(42, 271);
            this.pullStock.Name = "pullStock";
            this.pullStock.Size = new System.Drawing.Size(216, 73);
            this.pullStock.TabIndex = 5;
            this.pullStock.Text = "Pull From Stock";
            this.pullStock.UseVisualStyleBackColor = false;
            this.pullStock.Click += new System.EventHandler(this.pullStock_Click);
            // 
            // Cloths_Dep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.pullStock);
            this.Controls.Add(this.viewClothesDonations);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.addClothes);
            this.Name = "Cloths_Dep";
            this.Text = "Cloths_Dep";
            this.Load += new System.EventHandler(this.Cloths_Dep_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addClothes;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button viewClothesDonations;
        private System.Windows.Forms.Button pullStock;
    }
}