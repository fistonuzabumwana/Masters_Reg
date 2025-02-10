namespace Masters_Reg
{
    partial class Teacher
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
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button5;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Button button3;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button2 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(6, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(815, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.Color.Wheat;
            button2.Location = new System.Drawing.Point(341, 85);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(162, 30);
            button2.TabIndex = 36;
            button2.Text = "Delete Teacher";
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Green;
            button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button5.ForeColor = System.Drawing.Color.White;
            button5.Location = new System.Drawing.Point(131, 85);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(179, 30);
            button5.TabIndex = 15;
            button5.Text = "Add New Teacher";
            button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teacher\'s Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(449, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(325, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Teacher\'s ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(button1);
            this.panel2.Controls.Add(button2);
            this.panel2.Controls.Add(button5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(3, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 134);
            this.panel2.TabIndex = 49;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Blue;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(530, 85);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(183, 30);
            button1.TabIndex = 16;
            button1.Text = "Display All Teacher";
            button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(394, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Department:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Faculty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Teacher Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 79);
            this.panel1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "ALL TEACHER";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(3, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 208);
            this.panel3.TabIndex = 47;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Blue;
            button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.ForeColor = System.Drawing.Color.White;
            button4.Location = new System.Drawing.Point(3, 12);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(79, 30);
            button4.TabIndex = 48;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "DOB";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(630, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TEACHER ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 260;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TEACHER NAME";
            this.Column2.Name = "Column2";
            this.Column2.Width = 260;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DATE OF BIRTH";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Red;
            button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(745, 19);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(79, 30);
            button3.TabIndex = 44;
            button3.Text = "LogOut";
            button3.UseVisualStyleBackColor = false;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 508);
            this.Controls.Add(button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(button4);
            this.Name = "Teacher";
            this.Text = "Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}