using Soft_University.Models;
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
    public partial class Frm_Student : Form
    {
        List<Student> students;
        Student selectedStudent;
        public Frm_Student()
        {
            students = new List<Student>();
            InitializeComponent();
            selectedStudent = null;
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text.Trim() == "" || txt_ID.Text.Trim() == "" || txt_LastName.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام و نام خانوادگی و شماره دانشجویی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedStudent == null)
            {
                //Register
                Student student = new Student();
                student.FirstName = txt_FirstName.Text.Trim();
                student.LastName = txt_LastName.Text.Trim();
                student.ID = Convert.ToInt32(txt_ID.Text.Trim());
                student.IsMarried = Check_Married.Checked;
                student.Gender = Radio_Female.Checked;

                students.Add(student);
                MessageBox.Show("اطلاعات با موفقیت ثبت گردید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Edit
                selectedStudent.FirstName = txt_FirstName.Text.Trim();
                selectedStudent.LastName = txt_LastName.Text.Trim();
                selectedStudent.ID = Convert.ToInt32(txt_ID.Text.Trim());
                selectedStudent.IsMarried = Check_Married.Checked;
                selectedStudent.Gender = Radio_Female.Checked;
                MessageBox.Show("اطلاعات با موفقیت ویرایش گردید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Show_Students();
            Clear_Text();
        }

        private void Grid_Student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            int _id = Convert.ToInt32(Grid_Student["Col_Id", e.RowIndex].Value);
            selectedStudent = Find_Student(_id);

            if (selectedStudent != null)
            {
                txt_FirstName.Text = selectedStudent.FirstName;
                txt_LastName.Text = selectedStudent.LastName;
                txt_ID.Text = selectedStudent.ID.ToString();
                Radio_Female.Checked = selectedStudent.Gender;
                Radio_Male.Checked = !selectedStudent.Gender;
                Check_Married.Checked = selectedStudent.IsMarried;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                MessageBox.Show("لطفا موردی را از لیست انتخاب نمائید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("آیا از حذف مورد انتخابی مطمئن هستید؟", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            students.Remove(selectedStudent);
            Clear_Text();
            Show_Students();

            MessageBox.Show("مورد انتخابی با موفقیت حذف گردید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NewRegister_Click(object sender, EventArgs e)
        {
            Clear_Text();
        }

        private void Clear_Text()
        {
            txt_FirstName.Text = txt_LastName.Text = txt_ID.Text = "";
            txt_FirstName.Focus();
            Radio_Male.Checked = true;
            Check_Married.Checked = false;
            selectedStudent = null;
        }

        private void Show_Students()
        {
            Grid_Student.AutoGenerateColumns = false;
            Grid_Student.DataSource = students.ToList();
            if (Grid_Student.RowCount > 0)
            {
                Grid_Student.Rows[0].Selected = false;
            }
        }
        private Student Find_Student(int id)
        {
            foreach (var student in students)
            {
                if (student.ID == id)
                {
                    return student;
                }
            }

            return null;
        }
    }
}
