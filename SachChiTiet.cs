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
    public partial class SachChiTiet : Form
    {
        public SachChiTiet(string MS)
        {
            InitializeComponent();
            Sach sach = BLL.BLLQLS.Instance.GetSachByMaSach(MS);
            
            textBoxMS.Text = sach.Mã_sách;
            textBoxTS.Text = sach.Tên_sách;
            textBoxNhaXB.Text = sach.Nhà_xuất_bản;
            textBoxNamXB.Text = sach.Năm_xuất_bản;
            textBoxTG.Text = sach.Tác_giả;
            textBoxLoai.Text = sach.Loại;
            textBoxGia.Text = sach.Giá.ToString();
            textBoxSL.Text = sach.Số_lượng.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
