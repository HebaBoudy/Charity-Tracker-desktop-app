namespace DBapplication
{
    partial class Money_Donations_Dep
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
            this.viewBloodDonations = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.addMoneyDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewBloodDonations
            // 
            this.viewBloodDonations.BackColor = System.Drawing.Color.SteelBlue;
            this.viewBloodDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBloodDonations.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBloodDonations.ForeColor = System.Drawing.Color.White;
            this.viewBloodDonations.Location = new System.Drawing.Point(234, 216);
            this.viewBloodDonations.Name = "viewBloodDonations";
            this.viewBloodDonations.Size = new System.Drawing.Size(216, 73);
            this.viewBloodDonations.TabIndex = 7;
            this.viewBloodDonations.Text = "View Donations";
            this.viewBloodDonations.UseVisualStyleBackColor = false;
            this.viewBloodDonations.Click += new System.EventHandler(this.viewBloodDonations_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(95, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Money Donations Department";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.SteelBlue;
            this.logout.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.AliceBlue;
            this.logout.Location = new System.Drawing.Point(234, 314);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(216, 73);
            this.logout.TabIndex = 5;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // addMoneyDon
            // 
            this.addMoneyDon.BackColor = System.Drawing.Color.SteelBlue;
            this.addMoneyDon.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMoneyDon.ForeColor = System.Drawing.Color.AliceBlue;
            this.addMoneyDon.Location = new System.Drawing.Point(234, 126);
            this.addMoneyDon.Name = "addMoneyDon";
            this.addMoneyDon.Size = new System.Drawing.Size(216, 73);
            this.addMoneyDon.TabIndex = 4;
            this.addMoneyDon.Text = "Add Money Donation";
            this.addMoneyDon.UseVisualStyleBackColor = false;
            this.addMoneyDon.Click += new System.EventHandler(this.addMoneyDon_Click);
            // 
            // Money_Donations_Dep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.viewBloodDonations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.addMoneyDon);
            this.Name = "Money_Donations_Dep";
            this.Text = "Money_Donations_Dep";
            this.Load += new System.EventHandler(this.Money_Donations_Dep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewBloodDonations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button addMoneyDon;
    }
}