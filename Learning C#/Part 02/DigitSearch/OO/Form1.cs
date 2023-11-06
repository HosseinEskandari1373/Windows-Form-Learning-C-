using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO
{
    public partial class Form1 : Form
    {
        Person p = new Person();
        public Form1()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            p._id = 10;
            p._firstName = "Hossein";
            p._lastName = "Eskandari";
        }

        private void Show_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.Valid_Person());
        }
    }
}
