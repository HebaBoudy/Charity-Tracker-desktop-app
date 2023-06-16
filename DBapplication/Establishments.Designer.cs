
namespace DBapplication
{
    partial class Establishments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Establishments));
            this.AddEstablishments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewEstablishments = new System.Windows.Forms.Button();
            this.DeleteEstablishment = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEstablishments
            // 
            this.AddEstablishments.BackColor = System.Drawing.Color.SteelBlue;
            this.AddEstablishments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEstablishments.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEstablishments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddEstablishments.Location = new System.Drawing.Point(171, 75);
            this.AddEstablishments.Name = "AddEstablishments";
            this.AddEstablishments.Size = new System.Drawing.Size(138, 61);
            this.AddEstablishments.TabIndex = 0;
            this.AddEstablishments.Text = "Add Establishment";
            this.AddEstablishments.UseVisualStyleBackColor = false;
            this.AddEstablishments.Click += new System.EventHandler(this.AddEstablishments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Establishments";
            // 
            // ViewEstablishments
            // 
            this.ViewEstablishments.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewEstablishments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewEstablishments.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEstablishments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewEstablishments.Location = new System.Drawing.Point(171, 154);
            this.ViewEstablishments.Name = "ViewEstablishments";
            this.ViewEstablishments.Size = new System.Drawing.Size(138, 56);
            this.ViewEstablishments.TabIndex = 2;
            this.ViewEstablishments.Text = "View Establishments";
            this.ViewEstablishments.UseVisualStyleBackColor = false;
            this.ViewEstablishments.Click += new System.EventHandler(this.ViewEstablishments_Click);
            // 
            // DeleteEstablishment
            // 
            this.DeleteEstablishment.BackColor = System.Drawing.Color.SteelBlue;
            this.DeleteEstablishment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEstablishment.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEstablishment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteEstablishment.Location = new System.Drawing.Point(171, 239);
            this.DeleteEstablishment.Name = "DeleteEstablishment";
            this.DeleteEstablishment.Size = new System.Drawing.Size(138, 50);
            this.DeleteEstablishment.TabIndex = 3;
            this.DeleteEstablishment.Text = "Delete Establishment";
            this.DeleteEstablishment.UseVisualStyleBackColor = false;
            this.DeleteEstablishment.Click += new System.EventHandler(this.DeleteEstablishment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(439, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Establishments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(509, 337);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteEstablishment);
            this.Controls.Add(this.ViewEstablishments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddEstablishments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Establishments";
            this.Text = "Establishments";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEstablishments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewEstablishments;
        private System.Windows.Forms.Button DeleteEstablishment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}