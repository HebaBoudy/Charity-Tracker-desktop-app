namespace DBapplication
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stage_combobx = new System.Windows.Forms.ComboBox();
            this.year_combobx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Term_combobx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BNameTxtbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.Subjecttxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stage";
            // 
            // stage_combobx
            // 
            this.stage_combobx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stage_combobx.FormattingEnabled = true;
            this.stage_combobx.Items.AddRange(new object[] {
            "Primary",
            "Prepratory",
            "Secondary",
            "Other"});
            this.stage_combobx.Location = new System.Drawing.Point(71, 139);
            this.stage_combobx.Name = "stage_combobx";
            this.stage_combobx.Size = new System.Drawing.Size(121, 24);
            this.stage_combobx.TabIndex = 2;
            this.stage_combobx.SelectedIndexChanged += new System.EventHandler(this.stage_combobx_SelectedIndexChanged);
            // 
            // year_combobx
            // 
            this.year_combobx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_combobx.FormattingEnabled = true;
            this.year_combobx.Items.AddRange(new object[] {
            "Primary",
            "Prepratory",
            "Secondary",
            "Other"});
            this.year_combobx.Location = new System.Drawing.Point(73, 207);
            this.year_combobx.Name = "year_combobx";
            this.year_combobx.Size = new System.Drawing.Size(121, 24);
            this.year_combobx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // Term_combobx
            // 
            this.Term_combobx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Term_combobx.FormattingEnabled = true;
            this.Term_combobx.Items.AddRange(new object[] {
            "1st",
            "2nd"});
            this.Term_combobx.Location = new System.Drawing.Point(71, 270);
            this.Term_combobx.Name = "Term_combobx";
            this.Term_combobx.Size = new System.Drawing.Size(121, 24);
            this.Term_combobx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Term";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Subject";
            // 
            // ADD
            // 
            this.ADD.AutoSize = true;
            this.ADD.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.ForeColor = System.Drawing.Color.SteelBlue;
            this.ADD.Location = new System.Drawing.Point(413, 335);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(111, 23);
            this.ADD.TabIndex = 11;
            this.ADD.Text = "ADD BOOK";
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name";
            // 
            // BNameTxtbx
            // 
            this.BNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BNameTxtbx.Location = new System.Drawing.Point(71, 77);
            this.BNameTxtbx.Name = "BNameTxtbx";
            this.BNameTxtbx.Size = new System.Drawing.Size(121, 15);
            this.BNameTxtbx.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(375, 76);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 18, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 17, 0, 0, 0, 0);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(375, 142);
            this.Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Size = new System.Drawing.Size(120, 22);
            this.Quantity.TabIndex = 18;
            this.Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Subjecttxt
            // 
            this.Subjecttxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Subjecttxt.Location = new System.Drawing.Point(71, 326);
            this.Subjecttxt.Name = "Subjecttxt";
            this.Subjecttxt.Size = new System.Drawing.Size(121, 15);
            this.Subjecttxt.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(73, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 1);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(71, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 1);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(446, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(369, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 20);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "at Office";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 386);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Subjecttxt);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BNameTxtbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Term_combobx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.year_combobx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stage_combobx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stage_combobx;
        private System.Windows.Forms.ComboBox year_combobx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Term_combobx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ADD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BNameTxtbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.TextBox Subjecttxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}