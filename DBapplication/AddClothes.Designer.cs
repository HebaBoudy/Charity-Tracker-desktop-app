namespace DBapplication
{
    partial class AddClothes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClothes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sizeCombobox = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.addC = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clothType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Clothes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(40, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Quantity";
            // 
            // sizeCombobox
            // 
            this.sizeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeCombobox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeCombobox.FormattingEnabled = true;
            this.sizeCombobox.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.sizeCombobox.Location = new System.Drawing.Point(111, 169);
            this.sizeCombobox.Name = "sizeCombobox";
            this.sizeCombobox.Size = new System.Drawing.Size(121, 30);
            this.sizeCombobox.TabIndex = 29;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown1.Location = new System.Drawing.Point(618, 96);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 38;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 26);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(6, 21);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(74, 25);
            this.Male.TabIndex = 40;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(6, 81);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(94, 25);
            this.Female.TabIndex = 41;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // addC
            // 
            this.addC.BackColor = System.Drawing.Color.White;
            this.addC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addC.Location = new System.Drawing.Point(552, 301);
            this.addC.Name = "addC";
            this.addC.Size = new System.Drawing.Size(177, 38);
            this.addC.TabIndex = 43;
            this.addC.Text = "ADD";
            this.addC.UseVisualStyleBackColor = false;
            this.addC.Click += new System.EventHandler(this.addC_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(712, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Male);
            this.groupBox2.Controls.Add(this.Female);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(517, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 112);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Gender";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(47, 330);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 25);
            this.checkBox1.TabIndex = 50;
            this.checkBox1.Text = "At Office";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // clothType
            // 
            this.clothType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clothType.FormattingEnabled = true;
            this.clothType.Items.AddRange(new object[] {
            "Shirt",
            "T_Shirt",
            "Jacket",
            "Jeans",
            "Shoes",
            "Pyjamas",
            "Hoodie",
            "PullOver"});
            this.clothType.Location = new System.Drawing.Point(111, 98);
            this.clothType.Name = "clothType";
            this.clothType.Size = new System.Drawing.Size(121, 28);
            this.clothType.TabIndex = 51;
            // 
            // AddClothes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 382);
            this.Controls.Add(this.clothType);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.addC);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.sizeCombobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "AddClothes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sizeCombobox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Button addC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox clothType;
    }
}