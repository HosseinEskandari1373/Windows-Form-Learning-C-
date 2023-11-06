
namespace Soft_University
{
    partial class Frm_Proof
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proof));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Main_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Right_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.RightFlow_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ProofName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Layout.SuspendLayout();
            this.Right_Layout.SuspendLayout();
            this.RightFlow_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Layout
            // 
            this.Main_Layout.ColumnCount = 2;
            this.Main_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.08443F));
            this.Main_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.91557F));
            this.Main_Layout.Controls.Add(this.Right_Layout, 0, 0);
            this.Main_Layout.Controls.Add(this.Grid, 1, 0);
            this.Main_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Layout.Location = new System.Drawing.Point(0, 0);
            this.Main_Layout.Name = "Main_Layout";
            this.Main_Layout.RowCount = 1;
            this.Main_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_Layout.Size = new System.Drawing.Size(540, 628);
            this.Main_Layout.TabIndex = 1;
            // 
            // Right_Layout
            // 
            this.Right_Layout.ColumnCount = 1;
            this.Right_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Right_Layout.Controls.Add(this.RightFlow_Layout, 0, 0);
            this.Right_Layout.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.Right_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Right_Layout.Location = new System.Drawing.Point(354, 3);
            this.Right_Layout.Name = "Right_Layout";
            this.Right_Layout.RowCount = 2;
            this.Right_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.91319F));
            this.Right_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.08681F));
            this.Right_Layout.Size = new System.Drawing.Size(183, 622);
            this.Right_Layout.TabIndex = 0;
            // 
            // RightFlow_Layout
            // 
            this.RightFlow_Layout.BackColor = System.Drawing.Color.Gainsboro;
            this.RightFlow_Layout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RightFlow_Layout.Controls.Add(this.label1);
            this.RightFlow_Layout.Controls.Add(this.txt_ProofName);
            this.RightFlow_Layout.Controls.Add(this.button1);
            this.RightFlow_Layout.Controls.Add(this.button2);
            this.RightFlow_Layout.Controls.Add(this.button3);
            this.RightFlow_Layout.Controls.Add(this.button4);
            this.RightFlow_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightFlow_Layout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RightFlow_Layout.Location = new System.Drawing.Point(3, 3);
            this.RightFlow_Layout.Name = "RightFlow_Layout";
            this.RightFlow_Layout.Padding = new System.Windows.Forms.Padding(5, 8, 0, 5);
            this.RightFlow_Layout.Size = new System.Drawing.Size(177, 348);
            this.RightFlow_Layout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام مقطع:";
            // 
            // txt_ProofName
            // 
            this.txt_ProofName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ProofName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProofName.Location = new System.Drawing.Point(11, 31);
            this.txt_ProofName.Margin = new System.Windows.Forms.Padding(6, 8, 5, 5);
            this.txt_ProofName.Name = "txt_ProofName";
            this.txt_ProofName.PlaceholderText = "نام مقطع را وارد کنید";
            this.txt_ProofName.Size = new System.Drawing.Size(151, 23);
            this.txt_ProofName.TabIndex = 1;
            this.txt_ProofName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(20, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(20, 15, 3, 10);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 9;
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
            this.imageList1.Images.SetKeyName(4, "icons8_add_480px.png");
            this.imageList1.Images.SetKeyName(5, "icons8_delete_400px.png");
            this.imageList1.Images.SetKeyName(6, "icons8_new_copy_480px_1.png");
            this.imageList1.Images.SetKeyName(7, "icons8_return_400px.png");
            this.imageList1.Images.SetKeyName(8, "search (1).png");
            this.imageList1.Images.SetKeyName(9, "search.png");
            this.imageList1.Images.SetKeyName(10, "teacher_2436654.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(20, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(20, 12, 3, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 10;
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
            this.button3.ImageIndex = 6;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(20, 189);
            this.button3.Margin = new System.Windows.Forms.Padding(20, 12, 3, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button3.Size = new System.Drawing.Size(128, 39);
            this.button3.TabIndex = 11;
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
            this.button4.ImageIndex = 7;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(20, 243);
            this.button4.Margin = new System.Windows.Forms.Padding(20, 12, 3, 3);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.button4.Size = new System.Drawing.Size(128, 39);
            this.button4.TabIndex = 12;
            this.button4.Text = "بازگشت";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Return_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 357);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 262);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Column3});
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.GridColor = System.Drawing.Color.White;
            this.Grid.Location = new System.Drawing.Point(3, 3);
            this.Grid.Name = "Grid";
            this.Grid.RowTemplate.Height = 25;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(345, 622);
            this.Grid.TabIndex = 1;
            this.Grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_CellMouseClick);
            // 
            // Col_ID
            // 
            this.Col_ID.DataPropertyName = "ID";
            this.Col_ID.Frozen = true;
            this.Col_ID.HeaderText = "کد";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.ReadOnly = true;
            this.Col_ID.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProofName";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "مقطع";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Frm_Proof
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 628);
            this.Controls.Add(this.Main_Layout);
            this.MaximizeBox = false;
            this.Name = "Frm_Proof";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت مقطع تحصیلی";
            this.Load += new System.EventHandler(this.Frm_Proof_Load);
            this.Main_Layout.ResumeLayout(false);
            this.Right_Layout.ResumeLayout(false);
            this.RightFlow_Layout.ResumeLayout(false);
            this.RightFlow_Layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Main_Layout;
        private System.Windows.Forms.TableLayoutPanel Right_Layout;
        private System.Windows.Forms.FlowLayoutPanel RightFlow_Layout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ProofName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}