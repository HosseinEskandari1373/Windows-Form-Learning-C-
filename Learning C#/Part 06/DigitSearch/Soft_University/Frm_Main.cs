using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_University
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            //Menu_Student.Click += MenuStudent_Click;
        }

        private void MenuStudent_Click(object sender, EventArgs e)
        {
            Frm_Student _frm_student = new Frm_Student();
            _frm_student.ShowDialog();
        }

        private void Proof_Click(object sender, EventArgs e)
        {
            Frm_Proof proof = new Frm_Proof();
            proof.ShowDialog();
        }
    }
}
