using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("سلام برنامه نویس");
            //int a = 20;
            //int b = 30;

            //int Sum = a + b;

            //int S = Sum(10, 20);

            //MessageBox.Show(S.ToString());

            //MessageBox.Show(txtNum1.Text);
            //MessageBox.Show(txtNum2.Text);

            int Num1;
            int Num2;
            int s;

            if (txtNum1.Text.Trim() == "" || txtNum2.Text.Trim() == "")
            {
                MessageBox.Show("لطفا مقادیر ورودی را چک نمائید!!!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Num1 = Convert.ToInt32(txtNum1.Text.Trim());
                Num2 = Convert.ToInt32(txtNum2.Text.Trim());

                s = Sum(Num1, Num2);

                //MessageBox.Show(s.ToString());
                txtResult.Text = s.ToString();
            }
        }

        private int Sum(int a, int b)
        {
            return a + b;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
