namespace QLCF
{
    partial class UCdanhmuc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimdanhmuc = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTendanhmuc = new System.Windows.Forms.TextBox();
            this.txtIDdanhmuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvDanhmuc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhmuc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 457);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtTimdanhmuc);
            this.panel5.Controls.Add(this.btnTimkiem);
            this.panel5.Location = new System.Drawing.Point(6, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 81);
            this.panel5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm Danh Mục";
            // 
            // txtTimdanhmuc
            // 
            this.txtTimdanhmuc.Location = new System.Drawing.Point(25, 37);
            this.txtTimdanhmuc.Name = "txtTimdanhmuc";
            this.txtTimdanhmuc.Size = new System.Drawing.Size(161, 23);
            this.txtTimdanhmuc.TabIndex = 1;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(218, 23);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 37);
            this.btnTimkiem.TabIndex = 0;
            this.btnTimkiem.Text = "Tìm ";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.txtTendanhmuc);
            this.panel3.Controls.Add(this.txtIDdanhmuc);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(312, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 370);
            this.panel3.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnXem);
            this.panel6.Controls.Add(this.btnSua);
            this.panel6.Controls.Add(this.btnXoa);
            this.panel6.Controls.Add(this.btnThem);
            this.panel6.Location = new System.Drawing.Point(3, 260);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(242, 107);
            this.panel6.TabIndex = 8;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(24, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 37);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(24, 57);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(146, 57);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(146, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTendanhmuc
            // 
            this.txtTendanhmuc.Location = new System.Drawing.Point(80, 93);
            this.txtTendanhmuc.Name = "txtTendanhmuc";
            this.txtTendanhmuc.Size = new System.Drawing.Size(144, 23);
            this.txtTendanhmuc.TabIndex = 5;
            // 
            // txtIDdanhmuc
            // 
            this.txtIDdanhmuc.Enabled = false;
            this.txtIDdanhmuc.Location = new System.Drawing.Point(80, 58);
            this.txtIDdanhmuc.Name = "txtIDdanhmuc";
            this.txtIDdanhmuc.Size = new System.Drawing.Size(144, 23);
            this.txtIDdanhmuc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvDanhmuc);
            this.panel4.Location = new System.Drawing.Point(3, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 283);
            this.panel4.TabIndex = 5;
            // 
            // dtgvDanhmuc
            // 
            this.dtgvDanhmuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhmuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhmuc.Location = new System.Drawing.Point(0, 0);
            this.dtgvDanhmuc.Name = "dtgvDanhmuc";
            this.dtgvDanhmuc.Size = new System.Drawing.Size(303, 283);
            this.dtgvDanhmuc.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 78);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục";
            // 
            // UCdanhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCdanhmuc";
            this.Size = new System.Drawing.Size(563, 457);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhmuc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimdanhmuc;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTendanhmuc;
        private System.Windows.Forms.TextBox txtIDdanhmuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvDanhmuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;

    }
}
