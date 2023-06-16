
namespace DBapplication
{
    partial class MyBusses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBusses));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.viewBus = new System.Windows.Forms.Button();
            this.addBus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "My Busses";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(632, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // viewBus
            // 
            this.viewBus.BackColor = System.Drawing.Color.SteelBlue;
            this.viewBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBus.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBus.ForeColor = System.Drawing.Color.White;
            this.viewBus.Location = new System.Drawing.Point(28, 459);
            this.viewBus.Name = "viewBus";
            this.viewBus.Size = new System.Drawing.Size(246, 68);
            this.viewBus.TabIndex = 8;
            this.viewBus.Text = "View Busses";
            this.viewBus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.viewBus.UseVisualStyleBackColor = false;
            this.viewBus.Click += new System.EventHandler(this.viewBus_Click);
            // 
            // addBus
            // 
            this.addBus.BackColor = System.Drawing.Color.SteelBlue;
            this.addBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBus.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBus.ForeColor = System.Drawing.Color.White;
            this.addBus.Location = new System.Drawing.Point(28, 356);
            this.addBus.Name = "addBus";
            this.addBus.Size = new System.Drawing.Size(246, 68);
            this.addBus.TabIndex = 7;
            this.addBus.Text = "Add Bus";
            this.addBus.UseVisualStyleBackColor = false;
            this.addBus.Click += new System.EventHandler(this.addBus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(366, 458);
            this.dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Capacity";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(187, 111);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 40);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // MyBusses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 574);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.viewBus);
            this.Controls.Add(this.addBus);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyBusses";
            this.Text = "MyBusses";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button viewBus;
        private System.Windows.Forms.Button addBus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}