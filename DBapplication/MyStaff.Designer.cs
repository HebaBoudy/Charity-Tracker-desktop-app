namespace DBapplication
{
    partial class MyStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyStaff));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add_Employee_Button = new System.Windows.Forms.Button();
            this.View_Employee_Button = new System.Windows.Forms.Button();
            this.Update_Employee_Button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Add_Employee_Button
            // 
            this.Add_Employee_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.Add_Employee_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add_Employee_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Employee_Button.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Employee_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Employee_Button.Location = new System.Drawing.Point(142, 143);
            this.Add_Employee_Button.Name = "Add_Employee_Button";
            this.Add_Employee_Button.Size = new System.Drawing.Size(246, 68);
            this.Add_Employee_Button.TabIndex = 1;
            this.Add_Employee_Button.Text = "Add Employee";
            this.Add_Employee_Button.UseVisualStyleBackColor = false;
            this.Add_Employee_Button.Click += new System.EventHandler(this.Add_Employee_Button_Click);
            // 
            // View_Employee_Button
            // 
            this.View_Employee_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.View_Employee_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Employee_Button.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Employee_Button.ForeColor = System.Drawing.Color.White;
            this.View_Employee_Button.Location = new System.Drawing.Point(142, 248);
            this.View_Employee_Button.Name = "View_Employee_Button";
            this.View_Employee_Button.Size = new System.Drawing.Size(246, 68);
            this.View_Employee_Button.TabIndex = 2;
            this.View_Employee_Button.Text = "View Employee";
            this.View_Employee_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.View_Employee_Button.UseVisualStyleBackColor = false;
            this.View_Employee_Button.Click += new System.EventHandler(this.View_Employee_Button_Click);
            // 
            // Update_Employee_Button
            // 
            this.Update_Employee_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.Update_Employee_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Employee_Button.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Employee_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Employee_Button.Location = new System.Drawing.Point(142, 350);
            this.Update_Employee_Button.Name = "Update_Employee_Button";
            this.Update_Employee_Button.Size = new System.Drawing.Size(246, 68);
            this.Update_Employee_Button.TabIndex = 3;
            this.Update_Employee_Button.Text = "Update Employee";
            this.Update_Employee_Button.UseVisualStyleBackColor = false;
            this.Update_Employee_Button.Click += new System.EventHandler(this.Update_Employee_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(415, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "My Staff";
            // 
            // MyStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Update_Employee_Button);
            this.Controls.Add(this.View_Employee_Button);
            this.Controls.Add(this.Add_Employee_Button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyStaff";
            this.Load += new System.EventHandler(this.MyStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Add_Employee_Button;
        private System.Windows.Forms.Button View_Employee_Button;
        private System.Windows.Forms.Button Update_Employee_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}