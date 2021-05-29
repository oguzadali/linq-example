
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
            this.buttonGetCities = new System.Windows.Forms.Button();
            this.buttonAsc = new System.Windows.Forms.Button();
            this.buttonDesc = new System.Windows.Forms.Button();
            this.buttonLength = new System.Windows.Forms.Button();
            this.buttonContain = new System.Windows.Forms.Button();
            this.buttonStartWith = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetNumbers
            // 
            this.buttonGetNumbers.Location = new System.Drawing.Point(12, 33);
            this.buttonGetNumbers.Name = "buttonGetNumbers";
            this.buttonGetNumbers.Size = new System.Drawing.Size(142, 40);
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
            this.buttonNegativeNumbers.Location = new System.Drawing.Point(160, 33);
            this.buttonNegativeNumbers.Name = "buttonNegativeNumbers";
            this.buttonNegativeNumbers.Size = new System.Drawing.Size(100, 40);
            this.buttonNegativeNumbers.TabIndex = 3;
            this.buttonNegativeNumbers.Text = "(-) Numbers";
            this.buttonNegativeNumbers.UseVisualStyleBackColor = true;
            this.buttonNegativeNumbers.Click += new System.EventHandler(this.buttonNegativeNumbers_Click);
            // 
            // buttonPositiveNumbers
            // 
            this.buttonPositiveNumbers.Location = new System.Drawing.Point(266, 33);
            this.buttonPositiveNumbers.Name = "buttonPositiveNumbers";
            this.buttonPositiveNumbers.Size = new System.Drawing.Size(100, 40);
            this.buttonPositiveNumbers.TabIndex = 3;
            this.buttonPositiveNumbers.Text = "(+) Numbers";
            this.buttonPositiveNumbers.UseVisualStyleBackColor = true;
            this.buttonPositiveNumbers.Click += new System.EventHandler(this.buttonPositiveNumbers_Click);
            // 
            // buttonOddNumbers
            // 
            this.buttonOddNumbers.Location = new System.Drawing.Point(372, 33);
            this.buttonOddNumbers.Name = "buttonOddNumbers";
            this.buttonOddNumbers.Size = new System.Drawing.Size(100, 40);
            this.buttonOddNumbers.TabIndex = 3;
            this.buttonOddNumbers.Text = "n Numbers";
            this.buttonOddNumbers.UseVisualStyleBackColor = true;
            this.buttonOddNumbers.Click += new System.EventHandler(this.buttonOddNumbers_Click);
            // 
            // buttonEvenNumbers
            // 
            this.buttonEvenNumbers.Location = new System.Drawing.Point(478, 33);
            this.buttonEvenNumbers.Name = "buttonEvenNumbers";
            this.buttonEvenNumbers.Size = new System.Drawing.Size(100, 40);
            this.buttonEvenNumbers.TabIndex = 3;
            this.buttonEvenNumbers.Text = "2n Numbers";
            this.buttonEvenNumbers.UseVisualStyleBackColor = true;
            this.buttonEvenNumbers.Click += new System.EventHandler(this.buttonEvenNumbers_Click);
            // 
            // buttonMaxNumber
            // 
            this.buttonMaxNumber.Location = new System.Drawing.Point(584, 33);
            this.buttonMaxNumber.Name = "buttonMaxNumber";
            this.buttonMaxNumber.Size = new System.Drawing.Size(69, 40);
            this.buttonMaxNumber.TabIndex = 3;
            this.buttonMaxNumber.Text = "Max.";
            this.buttonMaxNumber.UseVisualStyleBackColor = true;
            this.buttonMaxNumber.Click += new System.EventHandler(this.buttonMaxNumber_Click);
            // 
            // buttonMinNumber
            // 
            this.buttonMinNumber.Location = new System.Drawing.Point(659, 33);
            this.buttonMinNumber.Name = "buttonMinNumber";
            this.buttonMinNumber.Size = new System.Drawing.Size(69, 40);
            this.buttonMinNumber.TabIndex = 3;
            this.buttonMinNumber.Text = "Min.";
            this.buttonMinNumber.UseVisualStyleBackColor = true;
            this.buttonMinNumber.Click += new System.EventHandler(this.buttonMinNumber_Click);
            // 
            // buttonCountNum
            // 
            this.buttonCountNum.Location = new System.Drawing.Point(734, 33);
            this.buttonCountNum.Name = "buttonCountNum";
            this.buttonCountNum.Size = new System.Drawing.Size(82, 40);
            this.buttonCountNum.TabIndex = 3;
            this.buttonCountNum.Text = "Count";
            this.buttonCountNum.UseVisualStyleBackColor = true;
            this.buttonCountNum.Click += new System.EventHandler(this.buttonCountNum_Click);
            // 
            // buttonGetCities
            // 
            this.buttonGetCities.Location = new System.Drawing.Point(12, 91);
            this.buttonGetCities.Name = "buttonGetCities";
            this.buttonGetCities.Size = new System.Drawing.Size(121, 40);
            this.buttonGetCities.TabIndex = 4;
            this.buttonGetCities.Text = "Get Cities";
            this.buttonGetCities.UseVisualStyleBackColor = true;
            this.buttonGetCities.Click += new System.EventHandler(this.buttonGetCities_Click);
            // 
            // buttonAsc
            // 
            this.buttonAsc.Location = new System.Drawing.Point(139, 91);
            this.buttonAsc.Name = "buttonAsc";
            this.buttonAsc.Size = new System.Drawing.Size(100, 40);
            this.buttonAsc.TabIndex = 5;
            this.buttonAsc.Text = "ASC";
            this.buttonAsc.UseVisualStyleBackColor = true;
            this.buttonAsc.Click += new System.EventHandler(this.buttonAsc_Click);
            // 
            // buttonDesc
            // 
            this.buttonDesc.Location = new System.Drawing.Point(245, 91);
            this.buttonDesc.Name = "buttonDesc";
            this.buttonDesc.Size = new System.Drawing.Size(100, 40);
            this.buttonDesc.TabIndex = 5;
            this.buttonDesc.Text = "DSC";
            this.buttonDesc.UseVisualStyleBackColor = true;
            this.buttonDesc.Click += new System.EventHandler(this.buttonDesc_Click);
            // 
            // buttonLength
            // 
            this.buttonLength.Location = new System.Drawing.Point(351, 91);
            this.buttonLength.Name = "buttonLength";
            this.buttonLength.Size = new System.Drawing.Size(100, 40);
            this.buttonLength.TabIndex = 5;
            this.buttonLength.Text = "Length";
            this.buttonLength.UseVisualStyleBackColor = true;
            this.buttonLength.Click += new System.EventHandler(this.buttonLength_Click);
            // 
            // buttonContain
            // 
            this.buttonContain.Location = new System.Drawing.Point(457, 91);
            this.buttonContain.Name = "buttonContain";
            this.buttonContain.Size = new System.Drawing.Size(113, 40);
            this.buttonContain.TabIndex = 5;
            this.buttonContain.Text = "Contains \"t\"";
            this.buttonContain.UseVisualStyleBackColor = true;
            this.buttonContain.Click += new System.EventHandler(this.buttonContain_Click);
            // 
            // buttonStartWith
            // 
            this.buttonStartWith.Location = new System.Drawing.Point(576, 91);
            this.buttonStartWith.Name = "buttonStartWith";
            this.buttonStartWith.Size = new System.Drawing.Size(141, 40);
            this.buttonStartWith.TabIndex = 5;
            this.buttonStartWith.Text = "Start With\"z\"";
            this.buttonStartWith.UseVisualStyleBackColor = true;
            this.buttonStartWith.Click += new System.EventHandler(this.buttonStartWith_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.buttonStartWith);
            this.Controls.Add(this.buttonContain);
            this.Controls.Add(this.buttonLength);
            this.Controls.Add(this.buttonDesc);
            this.Controls.Add(this.buttonAsc);
            this.Controls.Add(this.buttonGetCities);
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
        private System.Windows.Forms.Button buttonGetCities;
        private System.Windows.Forms.Button buttonAsc;
        private System.Windows.Forms.Button buttonDesc;
        private System.Windows.Forms.Button buttonLength;
        private System.Windows.Forms.Button buttonContain;
        private System.Windows.Forms.Button buttonStartWith;
    }
}

