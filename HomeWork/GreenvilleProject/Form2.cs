namespace ch3_caseproblem
{
    partial class GreenvilleRevenueGUI
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
            this.lastYear = new System.Windows.Forms.Label();
            this.thisYear = new System.Windows.Forms.TextBox();
            this.lastYearTxt = new System.Windows.Forms.Label();
            this.thisYearTxt = new System.Windows.Forms.TextBox();
            this.finalButton = new System.Windows.Forms.Button();
            this.final = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastYear
            // 
            this.lastYear.AutoSize = true;
            this.lastYear.Location = new System.Drawing.Point(40, 58);
            this.lastYear.Name = "label1";
            this.lastYear.Size = new System.Drawing.Size(106, 17);
            this.lastYear.TabIndex = 0;
            this.lastYear.Text = "Enter a number";
            // 
            // thisYear
            // 
            this.thisYear.Location = new System.Drawing.Point(152, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lastYearTxt
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter another nuber";
            // 
            // thisYearTxt
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // finalButton
            // 
            this.sumButton.Location = new System.Drawing.Point(43, 151);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(106, 23);
            this.sumButton.TabIndex = 4;
            this.sumButton.Text = "Click to add";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // final
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Label label3;
    }
}
