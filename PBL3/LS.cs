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
    public partial class LS : UserControl
    {
        DataGridViewRow dr;
        public LS(DataGridViewRow r)
        {
            dr = r;
            InitializeComponent();
            if(r!=null)
            {
                buttonNVQL.Enabled = true;
                buttonXemNguoi.Enabled = true;
                buttonXemSach.Enabled = true;
                textBoxMaSach.Text = r.Cells["Mã_sách"].Value.ToString();
                textBoxMaMuon.Text = r.Cells["Mã_mượn"].Value.ToString();
                textBoxMãNVQL.Text = r.Cells["Mã_nhân_viên"].Value.ToString();
                textBoxNameNguoiMuon.Text = r.Cells["Tên_người_mượn"].Value.ToString();
                textBoxMaNguoiMuon.Text = r.Cells["Mã_người_mượn"].Value.ToString();
                textBoxTimeMuon.Text = r.Cells["Thời_gian_mượn"].Value.ToString();
                textBoxTinhTrang.Text = r.Cells["Tình_trạng"].Value.ToString();
                textBoxTimeTra.Text = r.Cells["Thời_gian_trả"].Value.ToString();
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
            if(dr!=null)
            {
                string p = dr.Cells["Mã_sách"].Value.ToString();
                SachChiTiet s = new SachChiTiet(p);
                s.Show();
            }
        }
        

       
    }
}
