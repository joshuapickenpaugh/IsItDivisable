//Joshua Pickenpaugh
//February 27th, 2017
//Is it Divisable? (by 2, 3, or 5)

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is_It_Divisable
{
    public partial class frmMain : Form
    {
        //Class-level variables:
        String strUserInput;
        int intUserInput;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Initializes an ArrayList object:
            ArrayList arylistNums = new ArrayList();

            //Gets user input:
            strUserInput = txtUserInput.Text;
            intUserInput = Int32.Parse(strUserInput);

            for (int x = 1; x <= intUserInput; x++)
            {
                if (x % 2 == 0)
                {
                    arylistNums.Add(x + " is divisable by 2");
                }
                if (x % 3 == 0)
                {
                    arylistNums.Add(x + " is divisable by 3");
                }
                if (x % 5 == 0)
                {
                    arylistNums.Add(x + " is divisable by 5");
                }
            }

            //Display the ArrayList in the label:
            foreach(string x in arylistNums)
            {
                txtScrollDisplay.Text += x + Environment.NewLine;
            }
   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = "";
            txtScrollDisplay.Text = "";
        }
    }
}
