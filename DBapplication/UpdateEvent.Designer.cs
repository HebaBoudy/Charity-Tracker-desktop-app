
namespace DBapplication
{
    partial class UpdateEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEvent));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.duration = new System.Windows.Forms.NumericUpDown();
            this.newStatus = new System.Windows.Forms.ComboBox();
            this.newPhoneNum = new System.Windows.Forms.TextBox();
            this.eventCost = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventDate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.eventName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Update Event";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(883, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(950, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(266, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 1);
            this.panel1.TabIndex = 40;
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(229, 441);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(106, 24);
            this.duration.TabIndex = 38;
            // 
            // newStatus
            // 
            this.newStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newStatus.FormattingEnabled = true;
            this.newStatus.Items.AddRange(new object[] {
            "Upcoming",
            "In Progress",
            "Done"});
            this.newStatus.Location = new System.Drawing.Point(229, 396);
            this.newStatus.Name = "newStatus";
            this.newStatus.Size = new System.Drawing.Size(106, 24);
            this.newStatus.TabIndex = 37;
            // 
            // newPhoneNum
            // 
            this.newPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPhoneNum.Location = new System.Drawing.Point(266, 336);
            this.newPhoneNum.Name = "newPhoneNum";
            this.newPhoneNum.Size = new System.Drawing.Size(106, 17);
            this.newPhoneNum.TabIndex = 36;
            // 
            // eventCost
            // 
            this.eventCost.Location = new System.Drawing.Point(229, 279);
            this.eventCost.Name = "eventCost";
            this.eventCost.Size = new System.Drawing.Size(106, 24);
            this.eventCost.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(10, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Change Duration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Change Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(10, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "New Supervisor\'s Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(10, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "New Cost :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(939, 82);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(791, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 57);
            this.button1.TabIndex = 28;
            this.button1.Text = "Delete Event";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(791, 336);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(182, 57);
            this.UpdateButton.TabIndex = 27;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(989, 96);
            this.dataGridView1.TabIndex = 24;
            // 
            // eventDate
            // 
            this.eventDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventDate.Enabled = false;
            this.eventDate.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDate.FormattingEnabled = true;
            this.eventDate.Location = new System.Drawing.Point(492, 103);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(170, 31);
            this.eventDate.TabIndex = 45;
            this.eventDate.SelectedIndexChanged += new System.EventHandler(this.eventDate_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Event Name";
            // 
            // eventName
            // 
            this.eventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventName.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName.FormattingEnabled = true;
            this.eventName.Location = new System.Drawing.Point(129, 103);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(156, 31);
            this.eventName.TabIndex = 42;
            this.eventName.SelectedIndexChanged += new System.EventHandler(this.eventName_SelectedIndexChanged);
            // 
            // UpdateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 526);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.newStatus);
            this.Controls.Add(this.newPhoneNum);
            this.Controls.Add(this.eventCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateEvent";
            this.Text = "UpdateEvent";
            this.Load += new System.EventHandler(this.UpdateEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown duration;
        private System.Windows.Forms.ComboBox newStatus;
        private System.Windows.Forms.TextBox newPhoneNum;
        private System.Windows.Forms.NumericUpDown eventCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox eventDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox eventName;
    }
}