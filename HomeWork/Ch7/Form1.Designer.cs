namespace WindowsFormsApp2
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
            this.lastYearLabel = new System.Windows.Forms.Label();
            this.thisYearLabel = new System.Windows.Forms.Label();
            this.lastYearTextBox = new System.Windows.Forms.TextBox();
            this.thisYearTextBox = new System.Windows.Forms.TextBox();
            this.resultsButton = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Label();
            this.entryGroupBox = new System.Windows.Forms.GroupBox();
            this.greenvilleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.entryGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastYearLabel
            // 
            this.lastYearLabel.AutoSize = true;
            this.lastYearLabel.ForeColor = System.Drawing.Color.Black;
            this.lastYearLabel.Location = new System.Drawing.Point(6, 16);
            this.lastYearLabel.Name = "lastYearLabel";
            this.lastYearLabel.Size = new System.Drawing.Size(165, 13);
            this.lastYearLabel.TabIndex = 0;
            this.lastYearLabel.Text = "Last year\'s number of contestants";
            // 
            // thisYearLabel
            // 
            this.thisYearLabel.AutoSize = true;
            this.thisYearLabel.ForeColor = System.Drawing.Color.Black;
            this.thisYearLabel.Location = new System.Drawing.Point(6, 38);
            this.thisYearLabel.Name = "thisYearLabel";
            this.thisYearLabel.Size = new System.Drawing.Size(165, 13);
            this.thisYearLabel.TabIndex = 1;
            this.thisYearLabel.Text = "This year\'s number of contestants";
            // 
            // lastYearTextBox
            // 
            this.lastYearTextBox.BackColor = System.Drawing.Color.White;
            this.lastYearTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastYearTextBox.Location = new System.Drawing.Point(177, 13);
            this.lastYearTextBox.Name = "lastYearTextBox";
            this.lastYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastYearTextBox.TabIndex = 2;
            // 
            // thisYearTextBox
            // 
            this.thisYearTextBox.BackColor = System.Drawing.Color.White;
            this.thisYearTextBox.ForeColor = System.Drawing.Color.Black;
            this.thisYearTextBox.Location = new System.Drawing.Point(177, 31);
            this.thisYearTextBox.Name = "thisYearTextBox";
            this.thisYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.thisYearTextBox.TabIndex = 3;
            this.thisYearTextBox.Leave += new System.EventHandler(this.thisYearTextBox_Leave);
            // 
            // resultsButton
            // 
            this.resultsButton.BackColor = System.Drawing.Color.White;
            this.resultsButton.ForeColor = System.Drawing.Color.Green;
            this.resultsButton.Location = new System.Drawing.Point(224, 447);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(94, 29);
            this.resultsButton.TabIndex = 18;
            this.resultsButton.Text = "Get Revenue(s)";
            this.resultsButton.UseVisualStyleBackColor = false;
            this.resultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.Color.White;
            this.results.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.ForeColor = System.Drawing.Color.Black;
            this.results.Location = new System.Drawing.Point(90, 479);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(363, 108);
            this.results.TabIndex = 19;
            this.results.Text = "\r\n\r\n\r\n          ";
            // 
            // entryGroupBox
            // 
            this.entryGroupBox.Controls.Add(this.lastYearLabel);
            this.entryGroupBox.Controls.Add(this.thisYearLabel);
            this.entryGroupBox.Controls.Add(this.lastYearTextBox);
            this.entryGroupBox.Controls.Add(this.thisYearTextBox);
            this.entryGroupBox.ForeColor = System.Drawing.Color.Black;
            this.entryGroupBox.Location = new System.Drawing.Point(84, 69);
            this.entryGroupBox.Name = "entryGroupBox";
            this.entryGroupBox.Size = new System.Drawing.Size(284, 61);
            this.entryGroupBox.TabIndex = 6;
            this.entryGroupBox.TabStop = false;
            // 
            // greenvilleLabel
            // 
            this.greenvilleLabel.AutoSize = true;
            this.greenvilleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenvilleLabel.ForeColor = System.Drawing.Color.Black;
            this.greenvilleLabel.Location = new System.Drawing.Point(111, 2);
            this.greenvilleLabel.Name = "greenvilleLabel";
            this.greenvilleLabel.Size = new System.Drawing.Size(196, 42);
            this.greenvilleLabel.TabIndex = 7;
            this.greenvilleLabel.Text = "Greenville";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "talent";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter contestant information";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 324);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter talent to display";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(90, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 97);
            this.label5.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 92);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Display contestants\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Enter X to exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(621, 601);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.greenvilleLabel);
            this.Controls.Add(this.entryGroupBox);
            this.Controls.Add(this.results);
            this.Controls.Add(this.resultsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Greenville Revenue Estimator";
            this.entryGroupBox.ResumeLayout(false);
            this.entryGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastYearLabel;
        private System.Windows.Forms.Label thisYearLabel;
        private System.Windows.Forms.TextBox lastYearTextBox;
        private System.Windows.Forms.TextBox thisYearTextBox;
        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.GroupBox entryGroupBox;
        private System.Windows.Forms.Label greenvilleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

