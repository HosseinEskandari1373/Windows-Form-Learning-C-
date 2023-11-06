
namespace Soft_University
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Prof = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 7, 0, 7);
            this.menuStrip1.Size = new System.Drawing.Size(888, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Student,
            this.Menu_Prof});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 23);
            this.toolStripMenuItem1.Text = "مدیریت اطلاعات";
            // 
            // Menu_Student
            // 
            this.Menu_Student.BackColor = System.Drawing.Color.Gainsboro;
            this.Menu_Student.Image = global::Soft_University.Properties.Resources.graduated_3135810;
            this.Menu_Student.Name = "Menu_Student";
            this.Menu_Student.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Menu_Student.Size = new System.Drawing.Size(180, 28);
            this.Menu_Student.Text = "ثبت دانشجو";
            this.Menu_Student.ToolTipText = "جهت ورود به فرم دانشجو کلیک نمائید";
            this.Menu_Student.Click += new System.EventHandler(this.MenuStudent_Click);
            // 
            // Menu_Prof
            // 
            this.Menu_Prof.BackColor = System.Drawing.Color.Gainsboro;
            this.Menu_Prof.Image = global::Soft_University.Properties.Resources.teacher_2436654;
            this.Menu_Prof.Name = "Menu_Prof";
            this.Menu_Prof.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Menu_Prof.Size = new System.Drawing.Size(180, 28);
            this.Menu_Prof.Text = "ثبت استاد";
            this.Menu_Prof.ToolTipText = "جهت ورود به فرم استاد کلیک نمائید";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(90, 23);
            this.toolStripMenuItem2.Text = "گزارش گیری";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(118, 23);
            this.toolStripMenuItem3.Text = "مدیریت نرم افزار";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 518);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار مدیریت دانشجویان";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Student;
        private System.Windows.Forms.ToolStripMenuItem Menu_Prof;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

