using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace San_pham_them
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ket_noi kn = new ket_noi();

        private void btn_THEM_Click(object sender, EventArgs e)
        {
            try
            {
                string query_masp = string.Format("select * from San_Pham where MaSanPham = '{0}'",
                    txt_MASP.Text
                    );

                DataSet ds = kn.lay_du_lieu(query_masp);
                if(ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Masp da ton tai");
        
                }
                else
                {
                    DateTime ngay_xuat = date_ngay_Xuat.Value;
                    DateTime ngay_het = date_ngay_Het.Value;
                    string query_them = string.Format("insert into San_Pham values ('{0}',N'{1}',{2},'{3}','{4}','{5}')",
                            txt_MASP.Text,
                            txt_TENSP.Text,
                            txt_SOLUONG.Text,
                            ngay_xuat,
                            ngay_het,
                            txt_NCC.Text
                        );

                    bool kt = kn.thuthi(query_them);
                    if (kt) MessageBox.Show("them thanh cong");
                    else MessageBox.Show("them that bai");
                }

                getdata();


            }catch(Exception ex)
            {
                MessageBox.Show("loi" + ex);
            }
        }

        private void txt_SOLUONG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public void getdata()
        {
            string query = "select * from San_Pham";
            DataSet ds = kn.lay_du_lieu(query);
            dgv_hienthi.PerformLayout();
            dgv_hienthi.DataSource = ds.Tables[0];
        }

        private void btn_LAMMOI_Click(object sender, EventArgs e)
        {
            txt_MASP.Text = "";
            txt_NCC.Text = "";
            txt_SOLUONG.Text = "";
            txt_TENSP.Text = "";
            getdata();
        }
    }
}
