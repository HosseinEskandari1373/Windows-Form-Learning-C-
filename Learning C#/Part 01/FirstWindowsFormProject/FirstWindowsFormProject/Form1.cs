using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            if (txtNumber1.Text.Trim() == "" || txtNumber2.Text.Trim() == "")
            {
                MessageBox.Show("باکس عدد اول و عدد دوم نمی تواند خالی باشد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int Num1 = Convert.ToInt32(txtNumber1.Text);
                int Num2 = Convert.ToInt32(txtNumber2.Text);
                int S = Sum(Num1, Num2);

                txtResult.Text = S.ToString();
            }
        }

        private int Sum(int a, int b)
        {
            return a + b;
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            int[] a = { 10, 20, 30, 40, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };
            int s = 0;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    s += a[i];
            //}

            foreach (var item in a)
            {
                s += item;
            }

            ListDigit.DataSource = a;

            txtResult.Text = s.ToString();
        }
    }
}
