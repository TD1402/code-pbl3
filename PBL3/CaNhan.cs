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
    public partial class CaNhan : UserControl
    {
        
        public CaNhan()
        {
            InitializeComponent();
            HienThi();
        }
        public void HienThi()
        {
            Account a = BLL.BLLQLAccount.Instance.TaiKhoanHienTai();
            NhanVien nv = BLL.BLLQLNV.Instance.GetNhanVienByMNV(a.MNV);
            textBoxTK.Text = a.UserName.ToString();
            textBoxMNV.Text = nv.MNV.ToString();
            textBoxSDT.Text = nv.SDT.ToString();
            textBoxNameNV.Text = nv.NameNV;
            textBoxDiaChi.Text = nv.DiaChi.ToString();
            if (nv.Gender=="Nam") radioButton1.Checked = true;
            else radioButton2.Checked = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            

        }
       
    }
}
