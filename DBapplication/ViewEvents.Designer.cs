
namespace DBapplication
{
    partial class ViewEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEvents));
            this.label1 = new System.Windows.Forms.Label();
            this.eventName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventDate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numP = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.addVolunteer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.remainingPlaces = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Event Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eventName
            // 
            this.eventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventName.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName.FormattingEnabled = true;
            this.eventName.Location = new System.Drawing.Point(147, 99);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(156, 31);
            this.eventName.TabIndex = 1;
            this.eventName.SelectedIndexChanged += new System.EventHandler(this.eventName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Name";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // eventDate
            // 
            this.eventDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventDate.Enabled = false;
            this.eventDate.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDate.FormattingEnabled = true;
            this.eventDate.Location = new System.Drawing.Point(510, 99);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(170, 31);
            this.eventDate.TabIndex = 4;
            this.eventDate.SelectedIndexChanged += new System.EventHandler(this.eventDate_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number Of Participants";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status";
            // 
            // numP
            // 
            this.numP.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numP.Location = new System.Drawing.Point(275, 203);
            this.numP.Name = "numP";
            this.numP.ReadOnly = true;
            this.numP.Size = new System.Drawing.Size(100, 37);
            this.numP.TabIndex = 7;
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.Location = new System.Drawing.Point(538, 203);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(125, 37);
            this.statusBox.TabIndex = 8;
            this.statusBox.TextChanged += new System.EventHandler(this.statusBox_TextChanged);
            // 
            // addVolunteer
            // 
            this.addVolunteer.BackColor = System.Drawing.Color.SteelBlue;
            this.addVolunteer.Enabled = false;
            this.addVolunteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVolunteer.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVolunteer.ForeColor = System.Drawing.Color.White;
            this.addVolunteer.Location = new System.Drawing.Point(500, 283);
            this.addVolunteer.Name = "addVolunteer";
            this.addVolunteer.Size = new System.Drawing.Size(256, 71);
            this.addVolunteer.TabIndex = 22;
            this.addVolunteer.Text = "Add Volunteer To Event";
            this.addVolunteer.UseVisualStyleBackColor = false;
            this.addVolunteer.Click += new System.EventHandler(this.addVolunteer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Remaining Places";
            // 
            // remainingPlaces
            // 
            this.remainingPlaces.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingPlaces.Location = new System.Drawing.Point(275, 269);
            this.remainingPlaces.Name = "remainingPlaces";
            this.remainingPlaces.ReadOnly = true;
            this.remainingPlaces.Size = new System.Drawing.Size(100, 37);
            this.remainingPlaces.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(680, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(726, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 458);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.remainingPlaces);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addVolunteer);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.numP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ViewEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEvents";
            this.Load += new System.EventHandler(this.ViewEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox eventDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numP;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Button addVolunteer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox remainingPlaces;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}