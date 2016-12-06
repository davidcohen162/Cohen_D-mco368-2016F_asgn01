using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ageInt = 0;
            var noOfYearsInt = 0;
            var noOfTermsInt = 0;
            bool ageIsInt = Int32.TryParse(age.Text, out ageInt);
            bool noOfYearsIsInt = Int32.TryParse(noOfYears.Text, out noOfYearsInt);
            bool noOfTermsIsInt = Int32.TryParse(noOfTerms.Text, out noOfTermsInt);
            label1.Text="What is your age?";
            label2.Text="How many years have you resided in the US?";
            label3.Text="How many prior terms have you served?";
            label4.Text = "";

            if (ageIsInt == false)
            {
                this.label1.Text = "Enter an int for age.";
            }

           
            if (noOfYearsIsInt == false)
            {
                this.label2.Text = "Enter an int for years resided.";
            }

            

            if (noOfTermsIsInt == false)
            {
                this.label3.Text = "Enter an int for amount of terms.";
            }

            
            else if(ageIsInt==true&&noOfYearsIsInt==true&&noOfTermsIsInt==true)
            {
                if (rebelledUS.Checked ||
                    naturalBornCitizen.Checked == false ||
                    ageInt < 35 ||
                    noOfYearsInt < 14 ||
                    noOfTermsInt > 1)
                {
                    this.label4.Text = "You're not eligible.";
                    
                }
                else
                {
                    this.label4.Text = "You're eligible.";
                }
            }



            
        
           

        }
    }
}
