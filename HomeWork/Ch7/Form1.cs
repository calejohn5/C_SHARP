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
//comparing revenue
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

  

//Method buttonclick to display array of person and their talent
        private void button2_Click(object sender, EventArgs e)
        {
            if    (textBox3.Text == "X")
                {   results.Text="All Done!!";
                 textBox3.Enabled=false;
                 return;           
                 } 
            label5.Text= label8.Text="";
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

        }

//Method buttonclick to display what they entered
        private void button3_Click(object sender, EventArgs e)
        {   
            label9.Visible = true;
            label10.Visible = true;
            label9.Text = "You entered " + lastYearTextBox.Text + " for last year";
            label10.Text = "You entered " + thisYearTextBox.Text + " for this year";
            groupBox1.Visible = true;
        }

//Onleave method toy display comparison between this and last year
        private void thisYearTextBox_Leave(object sender, EventArgs e)
        {
            int ly = Convert.ToInt32 (lastYearTextBox.Text);
            int ty = Convert.ToInt32 (thisYearTextBox.Text);
            thisyearnum=ty;
            cont= new string [thisyearnum,2];
            if (ly > ty){
                        label11.Text = "Last year had a bigger turnout";
            } 
            else if (ty > ly){
                        label11.Text = "This year has more contestants";
            }
            else {
                 label11.Text = "We have the same number of contestants";
            }
            label11.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

// Storing contestants and their talents into an array
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
