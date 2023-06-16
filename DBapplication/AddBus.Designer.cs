
namespace DBapplication
{
    partial class AddBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBus));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventDate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numP = new System.Windows.Forms.TextBox();
            this.busID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.driverPhoneNum = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addbustoevent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(786, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(839, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Assign Bus To Event";
            // 
            // eventName
            // 
            this.eventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventName.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName.ForeColor = System.Drawing.Color.Black;
            this.eventName.FormattingEnabled = true;
            this.eventName.Location = new System.Drawing.Point(205, 121);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(178, 31);
            this.eventName.TabIndex = 28;
            this.eventName.SelectedIndexChanged += new System.EventHandler(this.eventName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(38, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Event Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(495, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Date";
            // 
            // eventDate
            // 
            this.eventDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventDate.Enabled = false;
            this.eventDate.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDate.FormattingEnabled = true;
            this.eventDate.Location = new System.Drawing.Point(592, 121);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(194, 31);
            this.eventDate.TabIndex = 31;
            this.eventDate.SelectedIndexChanged += new System.EventHandler(this.eventDate_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(38, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Number Of Participants";
            // 
            // numP
            // 
            this.numP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numP.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numP.Location = new System.Drawing.Point(314, 293);
            this.numP.Name = "numP";
            this.numP.ReadOnly = true;
            this.numP.Size = new System.Drawing.Size(114, 30);
            this.numP.TabIndex = 35;
            this.numP.TextChanged += new System.EventHandler(this.numP_TextChanged);
            // 
            // busID
            // 
            this.busID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.busID.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busID.ForeColor = System.Drawing.Color.Black;
            this.busID.FormattingEnabled = true;
            this.busID.Location = new System.Drawing.Point(205, 205);
            this.busID.Name = "busID";
            this.busID.Size = new System.Drawing.Size(178, 31);
            this.busID.TabIndex = 37;
            this.busID.SelectedIndexChanged += new System.EventHandler(this.busID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(38, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Bus ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(38, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Driver Phone Number";
            // 
            // driverPhoneNum
            // 
            this.driverPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driverPhoneNum.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverPhoneNum.Location = new System.Drawing.Point(296, 379);
            this.driverPhoneNum.Name = "driverPhoneNum";
            this.driverPhoneNum.Size = new System.Drawing.Size(248, 28);
            this.driverPhoneNum.TabIndex = 42;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Location = new System.Drawing.Point(314, 419);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 1);
            this.panel6.TabIndex = 44;
            // 
            // addbustoevent
            // 
            this.addbustoevent.BackColor = System.Drawing.Color.SteelBlue;
            this.addbustoevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbustoevent.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbustoevent.ForeColor = System.Drawing.Color.White;
            this.addbustoevent.Location = new System.Drawing.Point(581, 452);
            this.addbustoevent.Name = "addbustoevent";
            this.addbustoevent.Size = new System.Drawing.Size(293, 71);
            this.addbustoevent.TabIndex = 45;
            this.addbustoevent.Text = "Add Bus To Event";
            this.addbustoevent.UseVisualStyleBackColor = false;
            this.addbustoevent.Click += new System.EventHandler(this.addbustoevent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(495, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Capacity";
            // 
            // capacity
            // 
            this.capacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.capacity.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.Location = new System.Drawing.Point(647, 206);
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            this.capacity.Size = new System.Drawing.Size(114, 30);
            this.capacity.TabIndex = 46;
            // 
            // AddBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 552);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.addbustoevent);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.driverPhoneNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.busID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBus";
            this.Text = "AddBus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox eventDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numP;
        private System.Windows.Forms.ComboBox busID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox driverPhoneNum;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button addbustoevent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox capacity;
    }
}