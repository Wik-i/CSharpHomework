using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        int hasError = 0;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void DoOp_Click(object sender, EventArgs e)
        {
            if (hasError == 1)
            {
                Result.Text = "error";
            }
            else
            {
                double numA = Convert.ToDouble(Num1.Text);
                double numB = Convert.ToDouble(Num2.Text);
                double result = 0;
                switch (OP.Text)
                {
                    case "+":
                        result = numA + numB;
                        break;
                    case "-":
                        result = numA - numB;
                        break;
                    case "*":
                        result = numA * numB;
                        break;
                    case "/":
                        if (numB == 0) { Result.Text = "error";return; }
                        result = numA / numB;
                        break;
                    default: break;
                }

             
                Result.Text = Convert.ToString(result);
            }        
        }

        private void OP_Click(object sender, EventArgs e)
        {
        
        }

        private void Num2_TextChanged(object sender, EventArgs e)
        {
            //检查数字输入是否合法
            double numCheck2 = 0;
            if(!double.TryParse(Num2.Text, out numCheck2))
            {
                hasError = 1;
            }
            else
            {
                hasError = 0;
            }
        }

        private void Num1_TextChanged(object sender, EventArgs e)
        {
            //检查数字输入是否合法
            double numCheck1 = 0;
            if (!double.TryParse(Num1.Text, out numCheck1))
            {
                hasError = 1;
            }
            else
            {
                hasError = 0;
            }
        }


        private void OP_TextChanged(object sender, EventArgs e)
        {
            string operation = " ";
            operation = OP.Text;
            if(operation != "+" && operation != "/" && operation != "*" && operation != "-")
            {//检查运算符是否合法
                hasError = 1;
            }
            else
            {
                hasError = 0;
            }
        }
    }
}
