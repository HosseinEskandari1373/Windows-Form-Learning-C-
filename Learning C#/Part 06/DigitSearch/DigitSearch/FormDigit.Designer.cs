
namespace DigitSearch
{
    partial class FormDigit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDigit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ListDigit = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.49645F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.50355F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListDigit, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 638);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txt_Number);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(396, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 632);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد:";
            // 
            // txt_Number
            // 
            this.txt_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Number.Font = new System.Drawing.Font("B Mitra", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Number.Location = new System.Drawing.Point(4, 6);
            this.txt_Number.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txt_Number.Mask = "00000";
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(109, 29);
            this.txt_Number.TabIndex = 1;
            this.txt_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(24, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(25, 12, 3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "اضافه";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.button1, "لطفا جهت اضافه کردن عدد کلیک نمائید");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete (1).png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "edit-add.png");
            this.imageList1.Images.SetKeyName(3, "search (1).png");
            this.imageList1.Images.SetKeyName(4, "search.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(24, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(25, 12, 3, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "جستجو";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Search_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(24, 158);
            this.button3.Margin = new System.Windows.Forms.Padding(25, 12, 3, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button3.Size = new System.Drawing.Size(112, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "حذف";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Remove_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button4.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(24, 212);
            this.button4.Margin = new System.Windows.Forms.Padding(25, 12, 3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "حذف عدد انتخابی";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.RemoveSelectedItem_Click);
            // 
            // ListDigit
            // 
            this.ListDigit.BackColor = System.Drawing.Color.Ivory;
            this.ListDigit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListDigit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListDigit.Font = new System.Drawing.Font("B Mitra", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListDigit.FormattingEnabled = true;
            this.ListDigit.ItemHeight = 29;
            this.ListDigit.Location = new System.Drawing.Point(3, 3);
            this.ListDigit.Name = "ListDigit";
            this.ListDigit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListDigit.Size = new System.Drawing.Size(387, 632);
            this.ListDigit.TabIndex = 1;
            // 
            // FormDigit
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "FormDigit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت اعداد";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_Number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox ListDigit;
    }
}

