using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitSearch
{
    public partial class FormDigit : Form
    {
        List<int> _list = new List<int>();
        public FormDigit()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (txt_Number.Text.Trim() == "")
            {
                MessageBox.Show("! لطفا عدد را وارد نمائید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int _num = Convert.ToInt32(txt_Number.Text.Trim());
            _list.Add(_num);

            Clear_Text();
            Show_Digit();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (txt_Number.Text.Trim() == "")
            {
                MessageBox.Show("! لطفا عدد را وارد نمائید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int _num = Convert.ToInt32(txt_Number.Text.Trim());

            if (_list.Count == 0)
            {
                MessageBox.Show("! لیست اعداد خالی می باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_list.Contains(_num))
            {
                MessageBox.Show("! عدد ورودی پیدا شد ", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("! عدد وارد شده در لیست وجود ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (txt_Number.Text.Trim() == "")
            {
                MessageBox.Show("! لطفا عدد را وارد نمائید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int _num = Convert.ToInt32(txt_Number.Text.Trim());

            if (_list.Count == 0)
            {
                MessageBox.Show("! لیست اعداد خالی می باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_list.Contains(_num))
            {
                _list.Remove(_num);

                Clear_Text();
                Show_Digit();
            }
            else
            {
                MessageBox.Show("! عدد وارد شده در لیست وجود ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemoveSelectedItem_Click(object sender, EventArgs e)
        {
            if (_list.Count == 0)
            {
                MessageBox.Show("! لیست اعداد خالی می باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ListDigit.SelectedIndex == -1)
            {
                MessageBox.Show("! لطفا عنصری را از لیست انتخاب نمائید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _list.RemoveAt(ListDigit.SelectedIndex);

                Clear_Text();
                Show_Digit();
            }
        }

        /******************توابع******************/
        private void Show_Digit()
        {
            ListDigit.DataSource = _list.ToList();
            ListDigit.SelectedIndex = -1;
        }

        private void Clear_Text()
        {
            txt_Number.Text = "";
            txt_Number.Focus();
        }
    }
}
