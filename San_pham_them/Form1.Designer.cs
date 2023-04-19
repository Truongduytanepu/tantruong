
namespace San_pham_them
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MASP = new System.Windows.Forms.TextBox();
            this.txt_TENSP = new System.Windows.Forms.TextBox();
            this.txt_SOLUONG = new System.Windows.Forms.TextBox();
            this.txt_NCC = new System.Windows.Forms.TextBox();
            this.date_ngay_Xuat = new System.Windows.Forms.DateTimePicker();
            this.date_ngay_Het = new System.Windows.Forms.DateTimePicker();
            this.btn_LAMMOI = new System.Windows.Forms.Button();
            this.btn_THEM = new System.Windows.Forms.Button();
            this.dgv_hienthi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaSP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TenSp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "SoLuongTon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngay xuat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngay Het Han";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nha Cung Cap";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_ngay_Het);
            this.groupBox1.Controls.Add(this.date_ngay_Xuat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_NCC);
            this.groupBox1.Controls.Add(this.txt_SOLUONG);
            this.groupBox1.Controls.Add(this.txt_TENSP);
            this.groupBox1.Controls.Add(this.txt_MASP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 332);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txt_MASP
            // 
            this.txt_MASP.Location = new System.Drawing.Point(212, 52);
            this.txt_MASP.Name = "txt_MASP";
            this.txt_MASP.Size = new System.Drawing.Size(198, 30);
            this.txt_MASP.TabIndex = 6;
            // 
            // txt_TENSP
            // 
            this.txt_TENSP.Location = new System.Drawing.Point(212, 90);
            this.txt_TENSP.Name = "txt_TENSP";
            this.txt_TENSP.Size = new System.Drawing.Size(198, 30);
            this.txt_TENSP.TabIndex = 7;
            // 
            // txt_SOLUONG
            // 
            this.txt_SOLUONG.Location = new System.Drawing.Point(212, 126);
            this.txt_SOLUONG.Name = "txt_SOLUONG";
            this.txt_SOLUONG.Size = new System.Drawing.Size(198, 30);
            this.txt_SOLUONG.TabIndex = 8;
            this.txt_SOLUONG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SOLUONG_KeyPress);
            // 
            // txt_NCC
            // 
            this.txt_NCC.Location = new System.Drawing.Point(212, 231);
            this.txt_NCC.Name = "txt_NCC";
            this.txt_NCC.Size = new System.Drawing.Size(198, 30);
            this.txt_NCC.TabIndex = 9;
            // 
            // date_ngay_Xuat
            // 
            this.date_ngay_Xuat.CustomFormat = "yyyy-MM-dd";
            this.date_ngay_Xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngay_Xuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngay_Xuat.Location = new System.Drawing.Point(212, 165);
            this.date_ngay_Xuat.Name = "date_ngay_Xuat";
            this.date_ngay_Xuat.Size = new System.Drawing.Size(198, 22);
            this.date_ngay_Xuat.TabIndex = 10;
            // 
            // date_ngay_Het
            // 
            this.date_ngay_Het.CustomFormat = "yyyy-MM-dd";
            this.date_ngay_Het.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngay_Het.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ngay_Het.Location = new System.Drawing.Point(212, 201);
            this.date_ngay_Het.Name = "date_ngay_Het";
            this.date_ngay_Het.Size = new System.Drawing.Size(198, 22);
            this.date_ngay_Het.TabIndex = 11;
            // 
            // btn_LAMMOI
            // 
            this.btn_LAMMOI.Location = new System.Drawing.Point(635, 428);
            this.btn_LAMMOI.Name = "btn_LAMMOI";
            this.btn_LAMMOI.Size = new System.Drawing.Size(128, 51);
            this.btn_LAMMOI.TabIndex = 7;
            this.btn_LAMMOI.Text = "LAM MOI";
            this.btn_LAMMOI.UseVisualStyleBackColor = true;
            this.btn_LAMMOI.Click += new System.EventHandler(this.btn_LAMMOI_Click);
            // 
            // btn_THEM
            // 
            this.btn_THEM.Location = new System.Drawing.Point(158, 428);
            this.btn_THEM.Name = "btn_THEM";
            this.btn_THEM.Size = new System.Drawing.Size(128, 51);
            this.btn_THEM.TabIndex = 8;
            this.btn_THEM.Text = "Thêm";
            this.btn_THEM.UseVisualStyleBackColor = true;
            this.btn_THEM.Click += new System.EventHandler(this.btn_THEM_Click);
            // 
            // dgv_hienthi
            // 
            this.dgv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthi.Location = new System.Drawing.Point(460, 74);
            this.dgv_hienthi.Name = "dgv_hienthi";
            this.dgv_hienthi.RowHeadersWidth = 51;
            this.dgv_hienthi.RowTemplate.Height = 24;
            this.dgv_hienthi.Size = new System.Drawing.Size(447, 320);
            this.dgv_hienthi.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 528);
            this.Controls.Add(this.dgv_hienthi);
            this.Controls.Add(this.btn_THEM);
            this.Controls.Add(this.btn_LAMMOI);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NCC;
        private System.Windows.Forms.TextBox txt_SOLUONG;
        private System.Windows.Forms.TextBox txt_TENSP;
        private System.Windows.Forms.TextBox txt_MASP;
        private System.Windows.Forms.DateTimePicker date_ngay_Het;
        private System.Windows.Forms.DateTimePicker date_ngay_Xuat;
        private System.Windows.Forms.Button btn_LAMMOI;
        private System.Windows.Forms.Button btn_THEM;
        private System.Windows.Forms.DataGridView dgv_hienthi;
    }
}

