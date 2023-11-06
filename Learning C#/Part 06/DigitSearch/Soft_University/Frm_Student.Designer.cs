
namespace Soft_University
{
    partial class Frm_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Student));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuReport_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Right_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.RightFlow_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Combo_Proof = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radio_Female = new System.Windows.Forms.RadioButton();
            this.Radio_Male = new System.Windows.Forms.RadioButton();
            this.Check_Married = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Grid_Student = new System.Windows.Forms.DataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Layout.SuspendLayout();
            this.Right_Layout.SuspendLayout();
            this.RightFlow_Layout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuReport_Student
            // 
            this.MenuReport_Student.Name = "MenuReport_Student";
            this.MenuReport_Student.Size = new System.Drawing.Size(230, 24);
            this.MenuReport_Student.Text = "گزارش از اطلاعات دانشجو";
            // 
            // Main_Layout
            // 
            this.Main_Layout.ColumnCount = 2;
            this.Main_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.76357F));
            this.Main_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.23643F));
            this.Main_Layout.Controls.Add(this.Right_Layout, 0, 0);
            this.Main_Layout.Controls.Add(this.Grid_Student, 1, 0);
            this.Main_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Layout.Location = new System.Drawing.Point(0, 0);
            this.Main_Layout.Name = "Main_Layout";
            this.Main_Layout.RowCount = 1;
            this.Main_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_Layout.Size = new System.Drawing.Size(829, 724);
            this.Main_Layout.TabIndex = 0;
            // 
            // Right_Layout
            // 
            this.Right_Layout.ColumnCount = 1;
            this.Right_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Right_Layout.Controls.Add(this.RightFlow_Layout, 0, 0);
            this.Right_Layout.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.Right_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Right_Layout.Location = new System.Drawing.Point(635, 3);
            this.Right_Layout.Name = "Right_Layout";
            this.Right_Layout.RowCount = 2;
            this.Right_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.57997F));
            this.Right_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.42003F));
            this.Right_Layout.Size = new System.Drawing.Size(191, 718);
            this.Right_Layout.TabIndex = 0;
            // 
            // RightFlow_Layout
            // 
            this.RightFlow_Layout.BackColor = System.Drawing.Color.Gainsboro;
            this.RightFlow_Layout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RightFlow_Layout.Controls.Add(this.label1);
            this.RightFlow_Layout.Controls.Add(this.txt_FirstName);
            this.RightFlow_Layout.Controls.Add(this.label2);
            this.RightFlow_Layout.Controls.Add(this.txt_LastName);
            this.RightFlow_Layout.Controls.Add(this.label3);
            this.RightFlow_Layout.Controls.Add(this.txt_ID);
            this.RightFlow_Layout.Controls.Add(this.label4);
            this.RightFlow_Layout.Controls.Add(this.Combo_Proof);
            this.RightFlow_Layout.Controls.Add(this.groupBox1);
            this.RightFlow_Layout.Controls.Add(this.Check_Married);
            this.RightFlow_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightFlow_Layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RightFlow_Layout.Location = new System.Drawing.Point(3, 3);
            this.RightFlow_Layout.Name = "RightFlow_Layout";
            this.RightFlow_Layout.Padding = new System.Windows.Forms.Padding(5, 8, 0, 5);
            this.RightFlow_Layout.Size = new System.Drawing.Size(185, 407);
            this.RightFlow_Layout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام:";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FirstName.Location = new System.Drawing.Point(19, 31);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(6, 8, 5, 5);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.PlaceholderText = "نام را وارد کنید";
            this.txt_FirstName.Size = new System.Drawing.Size(151, 23);
            this.txt_FirstName.TabIndex = 1;
            this.txt_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی:";
            // 
            // txt_LastName
            // 
            this.txt_LastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LastName.Location = new System.Drawing.Point(19, 87);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(6, 8, 5, 5);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.PlaceholderText = "نام خانوادگی را وارد کنید";
            this.txt_LastName.Size = new System.Drawing.Size(151, 23);
            this.txt_LastName.TabIndex = 2;
            this.txt_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "شماره دانشجویی:";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID.Location = new System.Drawing.Point(19, 143);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(6, 8, 5, 5);
            this.txt_ID.MaxLength = 10;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PlaceholderText = "شماره دانشجویی را وارد کنید";
            this.txt_ID.Size = new System.Drawing.Size(151, 23);
            this.txt_ID.TabIndex = 3;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "مقطع:";
            // 
            // Combo_Proof
            // 
            this.Combo_Proof.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Combo_Proof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo_Proof.FormattingEnabled = true;
            this.Combo_Proof.Location = new System.Drawing.Point(19, 199);
            this.Combo_Proof.Margin = new System.Windows.Forms.Padding(6, 8, 5, 5);
            this.Combo_Proof.Name = "Combo_Proof";
            this.Combo_Proof.Size = new System.Drawing.Size(151, 23);
            this.Combo_Proof.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.Radio_Female);
            this.groupBox1.Controls.Add(this.Radio_Male);
            this.groupBox1.Location = new System.Drawing.Point(19, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جنسیت:";
            // 
            // Radio_Female
            // 
            this.Radio_Female.AutoSize = true;
            this.Radio_Female.Location = new System.Drawing.Point(102, 56);
            this.Radio_Female.Name = "Radio_Female";
            this.Radio_Female.Size = new System.Drawing.Size(38, 19);
            this.Radio_Female.TabIndex = 1;
            this.Radio_Female.Text = "زن";
            this.Radio_Female.UseVisualStyleBackColor = true;
            // 
            // Radio_Male
            // 
            this.Radio_Male.AutoSize = true;
            this.Radio_Male.Checked = true;
            this.Radio_Male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Radio_Male.Location = new System.Drawing.Point(98, 30);
            this.Radio_Male.Name = "Radio_Male";
            this.Radio_Male.Size = new System.Drawing.Size(42, 19);
            this.Radio_Male.TabIndex = 0;
            this.Radio_Male.TabStop = true;
            this.Radio_Male.Text = "مرد";
            this.Radio_Male.UseVisualStyleBackColor = true;
            // 
            // Check_Married
            // 
            this.Check_Married.AutoSize = true;
            this.Check_Married.Location = new System.Drawing.Point(90, 325);
            this.Check_Married.Name = "Check_Married";
            this.Check_Married.Size = new System.Drawing.Size(83, 19);
            this.Check_Married.TabIndex = 8;
            this.Check_Married.Text = "متأهل است";
            this.Check_Married.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 416);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 299);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageIndex = 10;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(36, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(20, 15, 3, 10);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "ثبت";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Register_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete (1).png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "edit-add.png");
            this.imageList1.Images.SetKeyName(3, "graduated_3135810.png");
            this.imageList1.Images.SetKeyName(4, "search (1).png");
            this.imageList1.Images.SetKeyName(5, "search.png");
            this.imageList1.Images.SetKeyName(6, "delete (1).png");
            this.imageList1.Images.SetKeyName(7, "delete.png");
            this.imageList1.Images.SetKeyName(8, "edit-add.png");
            this.imageList1.Images.SetKeyName(9, "graduated_3135810.png");
            this.imageList1.Images.SetKeyName(10, "icons8_add_480px.png");
            this.imageList1.Images.SetKeyName(11, "icons8_delete_400px.png");
            this.imageList1.Images.SetKeyName(12, "icons8_new_copy_480px_1.png");
            this.imageList1.Images.SetKeyName(13, "icons8_return_400px.png");
            this.imageList1.Images.SetKeyName(14, "search (1).png");
            this.imageList1.Images.SetKeyName(15, "search.png");
            this.imageList1.Images.SetKeyName(16, "teacher_2436654.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageIndex = 11;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(36, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(20, 12, 3, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "حذف";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Remove_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.ImageIndex = 12;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(36, 150);
            this.button3.Margin = new System.Windows.Forms.Padding(20, 12, 3, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button3.Size = new System.Drawing.Size(128, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "جدید";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NewRegister_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button4.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.ImageIndex = 13;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(36, 204);
            this.button4.Margin = new System.Windows.Forms.Padding(20, 12, 3, 3);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button4.Size = new System.Drawing.Size(128, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "بازگشت";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Grid_Student
            // 
            this.Grid_Student.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            this.Grid_Student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Student.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Student.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7});
            this.Grid_Student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Student.GridColor = System.Drawing.Color.White;
            this.Grid_Student.Location = new System.Drawing.Point(3, 3);
            this.Grid_Student.Name = "Grid_Student";
            this.Grid_Student.RowTemplate.Height = 25;
            this.Grid_Student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Student.Size = new System.Drawing.Size(626, 718);
            this.Grid_Student.TabIndex = 1;
            this.Grid_Student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Student_CellClick);
            // 
            // Col_ID
            // 
            this.Col_ID.DataPropertyName = "ID";
            this.Col_ID.Frozen = true;
            this.Col_ID.HeaderText = "شماره دانشجویی";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.ReadOnly = true;
            this.Col_ID.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FullName";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "نام و نام خانوادگی";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProofName";
            this.Column5.HeaderText = "مقطع";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GenderName";
            this.Column6.HeaderText = "جنسیت";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MarriedName";
            this.Column7.HeaderText = "وضعیت تأهل";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 724);
            this.Controls.Add(this.Main_Layout);
            this.Name = "Frm_Student";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت دانشجو";
            this.Load += new System.EventHandler(this.Frm_Student_Load);
            this.Main_Layout.ResumeLayout(false);
            this.Right_Layout.ResumeLayout(false);
            this.RightFlow_Layout.ResumeLayout(false);
            this.RightFlow_Layout.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem MenuReport_Student;
        private System.Windows.Forms.TableLayoutPanel Main_Layout;
        private System.Windows.Forms.TableLayoutPanel Right_Layout;
        private System.Windows.Forms.FlowLayoutPanel RightFlow_Layout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView Grid_Student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Combo_Proof;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radio_Female;
        private System.Windows.Forms.RadioButton Radio_Male;
        private System.Windows.Forms.CheckBox Check_Married;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}