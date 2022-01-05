using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class tipCalc : Form
    {
        
        public tipCalc()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Declaring variables 
           
            double billamt, tipamt, personamt, totalamt, tiptotalamt;

            //Assign value to variables 
            
            billamt = double.Parse(billAmt.Text);
            tipamt = double.Parse(tipAmt.Text) / 100;
            personamt = double.Parse(peopleAmt.Text);

            //Calculation funtion
            tiptotalamt = billamt / personamt * tipamt;
            totalamt = billamt / personamt + tiptotalamt;

            //Output 
            tipTotal.Text = Math.Round(tiptotalamt, 2, MidpointRounding.ToEven).ToString();
            billtotal.Text = Math.Round(totalamt, 2, MidpointRounding.ToEven).ToString();
        }

        private void billAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //Validating Input type is numeric

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                errorProvider1.SetError(label1, "Only numeric Value allowed");
                label1.Text = "Enter numeric Value";
                e.Handled = true;
            }
            else 
            {
                errorProvider1.SetError(label1, "");
                label1.Text = "";
               
            }
        }
    }
}
