
namespace linq_example
{
    partial class Form1
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
            this.buttonGetNumbers = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonNegativeNumbers = new System.Windows.Forms.Button();
            this.buttonPositiveNumbers = new System.Windows.Forms.Button();
            this.buttonOddNumbers = new System.Windows.Forms.Button();
            this.buttonEvenNumbers = new System.Windows.Forms.Button();
            this.buttonMaxNumber = new System.Windows.Forms.Button();
            this.buttonMinNumber = new System.Windows.Forms.Button();
            this.buttonCountNum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetNumbers
            // 
            this.buttonGetNumbers.Location = new System.Drawing.Point(12, 33);
            this.buttonGetNumbers.Name = "buttonGetNumbers";
            this.buttonGetNumbers.Size = new System.Drawing.Size(100, 40);
            this.buttonGetNumbers.TabIndex = 0;
            this.buttonGetNumbers.Text = "Get Numbers";
            this.buttonGetNumbers.UseVisualStyleBackColor = true;
            this.buttonGetNumbers.Click += new System.EventHandler(this.buttonGetNumbers_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 233);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 212);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(173, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 212);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonNegativeNumbers
            // 
            this.buttonNegativeNumbers.Location = new System.Drawing.Point(118, 33);
            this.buttonNegativeNumbers.Name = "buttonNegativeNumbers";
            this.buttonNegativeNumbers.Size = new System.Drawing.Size(100, 40);
            this.buttonNegativeNumbers.TabIndex = 3;
            this.buttonNegativeNumbers.Text = "(-) Numbers";
            this.buttonNegativeNumbers.UseVisualStyleBackColor = true;
            this.buttonNegativeNumbers.Click += new System.EventHandler(this.buttonNegativeNumbers_Click);
            // 
            // buttonPositiveNumbers
            // 
            this.buttonPositiveNumbers.Location = new System.Drawing.Point(224, 33);
            this.buttonPositiveNumbers.Name = "buttonPositiveNumbers";
            this.buttonPositiveNumbers.Size = new System.Drawing.Size(100, 40);
            this.buttonPositiveNumbers.TabIndex = 3;
            this.buttonPositiveNumbers.Text = "(+) Numbers";
            this.buttonPositiveNumbers.UseVisualStyleBackColor = true;
            this.buttonPositiveNumbers.Click += new System.EventHandler(this.buttonPositiveNumbers_Click);
            // 
            // buttonOddNumbers
            // 
            this.buttonOddNumbers.Location = new System.Drawing.Point(330, 33);
            this.buttonOddNumbers.Name = "buttonOddNumbers";
            this.buttonOddNumbers.Size = new System.Drawing.Size(100, 40);
            this.buttonOddNumbers.TabIndex = 3;
            this.buttonOddNumbers.Text = "n Numbers";
            this.buttonOddNumbers.UseVisualStyleBackColor = true;
            this.buttonOddNumbers.Click += new System.EventHandler(this.buttonOddNumbers_Click);
            // 
            // buttonEvenNumbers
            // 
            this.buttonEvenNumbers.Location = new System.Drawing.Point(436, 33);
            this.buttonEvenNumbers.Name = "buttonEvenNumbers";
            this.buttonEvenNumbers.Size = new System.Drawing.Size(100, 40);
            this.buttonEvenNumbers.TabIndex = 3;
            this.buttonEvenNumbers.Text = "2n Numbers";
            this.buttonEvenNumbers.UseVisualStyleBackColor = true;
            this.buttonEvenNumbers.Click += new System.EventHandler(this.buttonEvenNumbers_Click);
            // 
            // buttonMaxNumber
            // 
            this.buttonMaxNumber.Location = new System.Drawing.Point(542, 33);
            this.buttonMaxNumber.Name = "buttonMaxNumber";
            this.buttonMaxNumber.Size = new System.Drawing.Size(100, 40);
            this.buttonMaxNumber.TabIndex = 3;
            this.buttonMaxNumber.Text = "Max.";
            this.buttonMaxNumber.UseVisualStyleBackColor = true;
            this.buttonMaxNumber.Click += new System.EventHandler(this.buttonMaxNumber_Click);
            // 
            // buttonMinNumber
            // 
            this.buttonMinNumber.Location = new System.Drawing.Point(648, 33);
            this.buttonMinNumber.Name = "buttonMinNumber";
            this.buttonMinNumber.Size = new System.Drawing.Size(100, 40);
            this.buttonMinNumber.TabIndex = 3;
            this.buttonMinNumber.Text = "Min.";
            this.buttonMinNumber.UseVisualStyleBackColor = true;
            this.buttonMinNumber.Click += new System.EventHandler(this.buttonMinNumber_Click);
            // 
            // buttonCountNum
            // 
            this.buttonCountNum.Location = new System.Drawing.Point(754, 33);
            this.buttonCountNum.Name = "buttonCountNum";
            this.buttonCountNum.Size = new System.Drawing.Size(100, 40);
            this.buttonCountNum.TabIndex = 3;
            this.buttonCountNum.Text = "Count";
            this.buttonCountNum.UseVisualStyleBackColor = true;
            this.buttonCountNum.Click += new System.EventHandler(this.buttonCountNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.buttonCountNum);
            this.Controls.Add(this.buttonMinNumber);
            this.Controls.Add(this.buttonMaxNumber);
            this.Controls.Add(this.buttonEvenNumbers);
            this.Controls.Add(this.buttonOddNumbers);
            this.Controls.Add(this.buttonPositiveNumbers);
            this.Controls.Add(this.buttonNegativeNumbers);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonGetNumbers);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetNumbers;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNegativeNumbers;
        private System.Windows.Forms.Button buttonPositiveNumbers;
        private System.Windows.Forms.Button buttonOddNumbers;
        private System.Windows.Forms.Button buttonEvenNumbers;
        private System.Windows.Forms.Button buttonMaxNumber;
        private System.Windows.Forms.Button buttonMinNumber;
        private System.Windows.Forms.Button buttonCountNum;
    }
}

