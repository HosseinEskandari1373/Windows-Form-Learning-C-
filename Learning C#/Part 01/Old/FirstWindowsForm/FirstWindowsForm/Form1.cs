using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void پروژه_Load(object sender, EventArgs e)
        {

        }

        private void Add_Number(object sender, EventArgs e)
        {
            if (txtNum1.Text.Trim() == "" || txtNum2.Text.Trim() == "")
            {
                MessageBox.Show("باکس عدد اول یا عدد دوم نمی تواند خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int num1 = Convert.ToInt32(txtNum1.Text.Trim());
                int num2 = Convert.ToInt32(txtNum2.Text.Trim());

                string Result = (num1 + num2).ToString();

                txtResult.Text = Result;
                //MessageBox.Show(Result);
            }
        }

        private int Sum(int a, int b)
        {
            return (a + b);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
