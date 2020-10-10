// TK
// Date: 2/9/18
// Chapter 4 Case Problem 1
// Modified Ch3 case problem with addition of if-else

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        int thisyearnum, ccount=0;
        string [,] cont;
    

        public Form1()
        {
            InitializeComponent();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            int conNum1 = Convert.ToInt32(lastYearTextBox.Text);
            int conNum2 = Convert.ToInt32(thisYearTextBox.Text);
            int lastRev = conNum1 * 25;
            int thisRev = conNum2 * 25;

            string compMes;
            if (conNum1 > 30 || conNum1 < 0)
               {
               results.Text = "Last year must use a number 0 through 30";
               return; 
               }
            if (conNum2 > 30 || conNum1 < 0)
               {
               results.Text = "This year must use a number 0 through 30";
               return; 
               }
            if (conNum2 > (2 * conNum1))
                compMes = "Compared to last year, the competition is over twice as large!";
            else if (conNum2 > conNum1)
                compMes = "The competition is bigger than ever!";
            else if (conNum2 < conNum1)
                compMes = "A tighter race this year! Come out and cast your vote!";
            else
                compMes = "The competition is the same as last year.";

            this.results.Text = string.Format("With an entrance fee of $25..." +
                "\nLast year's revenue was: ${0}" +
                "\nand this year's revenue estimate is: ${1}" +
                "\n{2}", lastRev, thisRev, compMes);
            this.results.Visible = true;
        }

        private void thisYearTextBox_Leave(object sender, EventArgs e)
        {
            groupBox1.Visible=true;
            textBox1.Focus();
            thisyearnum= Convert.ToInt32(thisYearTextBox.Text);
            cont= new string [thisyearnum,2];
        }

        private void lastYearLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != "S" && textBox3.Text != "D" && textBox3.Text != "M" && textBox3.Text != "O")
            {label8.Text="Invalid Entry"; return;}
            int cc=0;            
            while (cc < ccount)
                {
                    if (cont[cc,1]==textBox3.Text)
                    {
                        label5.Text=label5.Text+ cont[cc,0]+"\r\n" ;
                    }
                    cc=cc+1;  
                }  
            if    (textBox3.Text == "X")
                {   results.Text="All Done!!";
                 textBox3.Enabled=false;           
                 } 

        }

        private void button1_Click(object sender, EventArgs e)
        {
        if (ccount < thisyearnum )
        {
        cont[ccount,0]=textBox1.Text;
        cont[ccount,1]=textBox2.Text;
        textBox1.Text=textBox2.Text="";
        ccount = ccount + 1;
        }
        else {textBox3.Focus();
        }        
        if (ccount==thisyearnum)
            {textBox3.Focus();}


        }
    }
}
