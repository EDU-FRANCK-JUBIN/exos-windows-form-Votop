using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppVCL
{
    public partial class Calculatrice : Form
    {
        String sOperation;
        String sCurrentNumber;
        String sLastOperator;
        double dResult;

        public Calculatrice()
        {
            InitializeComponent();
            sOperation = "";
            sCurrentNumber = "0";
            sLastOperator = "";
            dResult = 0;
        }

        private void buttonNumberClick(object sender, EventArgs e)
        {
            if(sLastOperator == "=")
            {
                sOperation = "";
                labelCurrentOperation.Text = sOperation;
            }
            sCurrentNumber = sCurrentNumber == "0" ? ((Button)sender).Text : sCurrentNumber + ((Button)sender).Text;
            labelResult.Text = sCurrentNumber;
        }

        private void buttonOperatorClick(object sender, EventArgs e)
        {
            if(sCurrentNumber.Length > 0)
            {
                if(sLastOperator == "=")
                {
                    sLastOperator = "";
                    dResult = 0;
                }
                double dCurrentNumber = Convert.ToDouble(sCurrentNumber);
                sCurrentNumber = "";
                dResult = Calculate(dResult, dCurrentNumber, sLastOperator);
                Console.WriteLine(dResult.ToString());
                labelResult.Text = dResult.ToString();
                sOperation += dCurrentNumber.ToString() + " " + ((Button)sender).Text + " ";
            } 
            else
            {
                sOperation = sOperation.Remove(sOperation.Length - 2) + ((Button)sender).Text + " ";
            }
            labelCurrentOperation.Text = sOperation;
            sLastOperator = ((Button)sender).Text;
        }

        private void btnVirgule_Click(object sender, EventArgs e)
        {
            if (sLastOperator == "=")
            {
                sOperation = "";
                labelCurrentOperation.Text = sOperation;
            }
            sCurrentNumber += sCurrentNumber.Length == 0 ? "0," : ",";
            labelResult.Text = sCurrentNumber;
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if(sCurrentNumber.Length > 0)
            {
                double dCurrentNumber = Convert.ToDouble(sCurrentNumber) * -1.0;
                sCurrentNumber = dCurrentNumber.ToString();
                labelResult.Text = sCurrentNumber;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            sCurrentNumber = sCurrentNumber.Length > 1 ? sCurrentNumber.Remove(sCurrentNumber.Length - 1) : "0";
            labelResult.Text = sCurrentNumber;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            dResult = 0;
            sCurrentNumber = "0";
            sOperation = sLastOperator = "";
            labelCurrentOperation.Text = sOperation;
            labelResult.Text = sCurrentNumber;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            sCurrentNumber = "0";
            labelResult.Text = sCurrentNumber;
        }

        private double Calculate(double n1, double n2, String optr)
        {
            Console.WriteLine();
            double dResult;
            switch (optr)
            {
                case "*":
                    dResult = n1 * n2;
                    break;
                case "/":
                    dResult = n1 / n2;
                    break;
                case "+":
                    dResult = n1 + n2;
                    break;
                case "-":
                    dResult = n1 - n2;
                    break;
                default:
                    dResult = n2;
                    break;
            }
            Console.WriteLine(n1.ToString() + " " + optr + " " + n2.ToString() + " = " + dResult.ToString());
            return dResult;
        }
    }
}
