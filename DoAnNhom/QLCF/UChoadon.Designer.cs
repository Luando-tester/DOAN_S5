namespace QLCF
{
    partial class UChoadon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timePicktungay = new System.Windows.Forms.DateTimePicker();
            this.timePickdenngay = new System.Windows.Forms.DateTimePicker();
            this.btnXemhoadon = new System.Windows.Forms.Button();
            this.dtgvHoadon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 457);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 78);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXemhoadon);
            this.panel3.Controls.Add(this.timePickdenngay);
            this.panel3.Controls.Add(this.timePicktungay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 76);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvHoadon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 303);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến";
            // 
            // timePicktungay
            // 
            this.timePicktungay.Location = new System.Drawing.Point(61, 13);
            this.timePicktungay.Name = "timePicktungay";
            this.timePicktungay.Size = new System.Drawing.Size(200, 23);
            this.timePicktungay.TabIndex = 2;
            // 
            // timePickdenngay
            // 
            this.timePickdenngay.Location = new System.Drawing.Point(61, 46);
            this.timePickdenngay.Name = "timePickdenngay";
            this.timePickdenngay.Size = new System.Drawing.Size(200, 23);
            this.timePickdenngay.TabIndex = 3;
            // 
            // btnXemhoadon
            // 
            this.btnXemhoadon.Location = new System.Drawing.Point(450, 15);
            this.btnXemhoadon.Name = "btnXemhoadon";
            this.btnXemhoadon.Size = new System.Drawing.Size(98, 52);
            this.btnXemhoadon.TabIndex = 4;
            this.btnXemhoadon.Text = "Xem Hóa Đơn";
            this.btnXemhoadon.UseVisualStyleBackColor = true;
            // 
            // dtgvHoadon
            // 
            this.dtgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHoadon.Location = new System.Drawing.Point(0, 0);
            this.dtgvHoadon.Name = "dtgvHoadon";
            this.dtgvHoadon.Size = new System.Drawing.Size(563, 303);
            this.dtgvHoadon.TabIndex = 0;
            // 
            // UChoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UChoadon";
            this.Size = new System.Drawing.Size(563, 457);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvHoadon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXemhoadon;
        private System.Windows.Forms.DateTimePicker timePickdenngay;
        private System.Windows.Forms.DateTimePicker timePicktungay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
