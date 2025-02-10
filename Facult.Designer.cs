namespace Masters_Reg
{
    partial class Facult
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
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button5;
            System.Windows.Forms.Button button3;
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Blue;
            button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.ForeColor = System.Drawing.Color.White;
            button4.Location = new System.Drawing.Point(12, 13);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(79, 30);
            button4.TabIndex = 47;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(482, 72);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(154, 30);
            button1.TabIndex = 16;
            button1.Text = "Display Faculty";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.Color.Wheat;
            button2.Location = new System.Drawing.Point(351, 72);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(116, 30);
            button2.TabIndex = 36;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Green;
            button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button5.ForeColor = System.Drawing.Color.White;
            button5.Location = new System.Drawing.Point(181, 72);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(154, 30);
            button5.TabIndex = 39;
            button5.Text = "Add Faculty";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(9, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 298);
            this.panel3.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(8, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 169);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Faculty Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Code";
            this.Column3.Name = "Column3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "ALL FACULTY";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Facult Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 79);
            this.panel1.TabIndex = 45;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(button5);
            this.panel2.Controls.Add(button1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(9, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 121);
            this.panel2.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(512, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Faculty Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(99, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(387, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Faculty Code:";
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Red;
            button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(754, 12);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(79, 30);
            button3.TabIndex = 49;
            button3.Text = "LogOut";
            button3.UseVisualStyleBackColor = false;
            // 
            // Facult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 504);
            this.Controls.Add(button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(button4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Facult";
            this.Text = "Facult";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}