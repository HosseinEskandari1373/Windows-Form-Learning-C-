using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_University.Frameworks
{
    public static class MyMessageBox
    {
        public static void ValidationErrorMessage(string msg = "اطلاعات کامل وارد نشده است", string warn = "خطا")
        {
            MessageBox.Show(msg, warn, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SuccessMessage(string msg = "عملیات با موفقیت انجام شد", string warn = "پیام")
        {
            MessageBox.Show(msg, warn, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SelectionErrorMessage(string msg = "لطفا موردی را از لیست انتخاب نمائید", string warn = "خطا")
        {
            MessageBox.Show(msg, warn, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ConfirmedMessage()
        {
            var result = MessageBox.Show("آیا از حذف مورد انتخابی مطمئن هستید؟", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return false;
            }

            return true;
        }
    }
}
