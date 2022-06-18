using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class LST : UserControl
    {
        DataGridViewRow dr;
        public LST(DataGridViewRow r)
        {
            dr = r;
            InitializeComponent();
            if (r != null)
            {
                buttonNVQL.Enabled = true;
                buttonXemNguoi.Enabled = true;
                buttonXemSach.Enabled = true;
                textBoxMaSach.Text = r.Cells["Mã_sách"].Value.ToString();
                textBoxMaTra.Text = r.Cells["Mã_trả"].Value.ToString();
                textBoxMãNVQL.Text = r.Cells["Mã_nhân_viên"].Value.ToString();
                textBoxNameNguoiTra.Text = r.Cells["Tên_người_trả"].Value.ToString();
                textBoxMaNguoiTra.Text = r.Cells["Mã_người_trả"].Value.ToString();
                textBoxThoiGianTra.Text = r.Cells["Thời_gian_trả"].Value.ToString();
                textBoxTinhTrang.Text = r.Cells["Tình_trạng"].Value.ToString();
                if (r.Cells["Đã_trả"].Value.ToString() == "Đã trả") checkBox1.Checked = true;

            }
            else
            {
                buttonNVQL.Enabled = false;
                buttonXemNguoi.Enabled = false;
                buttonXemSach.Enabled = false;
            }
        }

        private void buttonXemSach_Click(object sender, EventArgs e)
        {
            if (dr != null)
            {
                string p = dr.Cells["Mã_sách"].Value.ToString();
                SachChiTiet s = new SachChiTiet(p);
                s.Show();
            }
        }
    }
}
