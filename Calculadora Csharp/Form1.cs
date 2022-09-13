using Microsoft.VisualBasic.Devices;
using System;
using System.Windows.Forms;

namespace Calculadora_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;


        // 0
        private void btn0_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 0;
        }

        
        
        // -
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text != "")
            {
                num1 = float.Parse(txbVisor.Text);
                txbVisor.Clear();
                txbVisor.Focus();
                count = 1;
            }
        }

        //+
        private void btnSomar_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txbVisor.Text);
            txbVisor.Clear();
            txbVisor.Focus();
            count = 2;
        }

        //*
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txbVisor.Text);
            txbVisor.Clear();
            txbVisor.Focus();
            count = 3;
        }
         // / 
        private void btnDividir_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txbVisor.Text);
            txbVisor.Clear();
            txbVisor.Focus();
            count = 4;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(txbVisor.Text);
                    txbVisor.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txbVisor.Text);
                    txbVisor.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txbVisor.Text);
                    txbVisor.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txbVisor.Text);
                    txbVisor.Text = ans.ToString();
                    break;
            }

        }
        //SQUARE ROOT
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Math.Sqrt(float.Parse(txbVisor.Text));
            txbVisor.Text = sqrt.ToString();
        }

        // RESET
        private void btnResetar_Click(object sender, EventArgs e)
        {
            txbVisor.Clear();
            count = 0;
        }

        // .
        private void btnDot_Click(object sender, EventArgs e)
        {
            int c = txbVisor.TextLength;
            int flag = 0;
            string text = txbVisor.Text;
            for(int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".") 
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
                if (flag == 0)
                {
                    txbVisor.Text = txbVisor + ".";
                }
              
            }

        }
        //ON
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 0;
        }

        //1-9
        private void btn1_Click_1(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 1;
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 2;
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 3;
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 4;
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 5;
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 6;
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 7;
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 8;
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}