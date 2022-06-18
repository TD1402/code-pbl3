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
    public partial class AddUpdateMuonSach : UserControl
    {
        public delegate void Mydel();
        public Mydel d;
        string MaMuon;
        public AddUpdateMuonSach(string MM)
        {
            InitializeComponent();
            MaMuon = MM;
            button1.Enabled = false;
            GUI();
            textBoxNameNguoiMuon.Enabled = false;
            
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (MuonSach i in BLL.BLLQLMT.Instance.GetAllLichSuMuon())
            {
                dem++;
            }
            MuonSach ms = null;
            if (MaMuon == "")
            {
                ms = new MuonSach
                {
                    STT = dem + 1,
                    Mã_mượn = (dem + 1).ToString(),
                    Mã_Sách = textBoxMaSach.Text,
                    Mã_Nhân_Viên = BLL.BLLQLAccount.Instance.TaiKhoanHienTai().MNV,
                    Tên_Người_Mượn = textBoxNameNguoiMuon.Text,
                    Mã_Người_Mượn = textBoxMaNguoiMuon.Text,
                    Thời_Gian_Mượn = Convert.ToDateTime(dateTimePicker1.Value),
                    Thời_Gian_Trả = Convert.ToDateTime(dateTimePicker2.Value),
                    Tình_Trạng = comboBox1.SelectedItem.ToString()
                };
                textBoxMaSach.Text = "";
                textBoxNameNguoiMuon.Text = "";
                textBoxMaNguoiMuon.Text = "";
                comboBox1.SelectedItem = null;
            }
            else
            {
                
                ms = new MuonSach
                {
                    Mã_mượn =  BLL.BLLQLMT.Instance.GetMuonSachByMaMuon(MaMuon).Mã_mượn,
                    STT = BLL.BLLQLMT.Instance.GetMuonSachByMaMuon(MaMuon).STT,
                    Mã_Sách = textBoxMaSach.Text,
                    Mã_Nhân_Viên = BLL.BLLQLMT.Instance.GetMuonSachByMaMuon(MaMuon).Mã_Nhân_Viên,
                    Tên_Người_Mượn = textBoxNameNguoiMuon.Text,
                    Mã_Người_Mượn = textBoxMaNguoiMuon.Text,
                    Thời_Gian_Mượn = Convert.ToDateTime(dateTimePicker1.Value),
                    Thời_Gian_Trả = Convert.ToDateTime(dateTimePicker2.Value),
                    Tình_Trạng = comboBox1.SelectedItem.ToString()
                };
            }
            if (BLL.BLLQLS.Instance.CheckSach(ms.Mã_Sách) && BLL.BLLQLNguoiDung.Instance.CheckND(ms.Mã_Người_Mượn)) label1.Text = "Thành công!!!";
            else if (BLL.BLLQLS.Instance.CheckSach(ms.Mã_Sách) == false) label1.Text = "Mã sách không đúng!!!";
            else label1.Text = "Mã người mượn không đúng!!!";
            BLL.BLLQLMT.Instance.AddUpdateMuon(ms);
            d();
            

        }

        private void textBoxMaSach_TextChanged(object sender, EventArgs e)
        {
            string name = BLL.BLLQLNguoiDung.Instance.GetNameByMND(textBoxMaNguoiMuon.Text);
      
            if(name != null) textBoxNameNguoiMuon.Text = name;
            if (textBoxMaSach.Text != ""&& textBoxMaNguoiMuon.Text != ""&&textBoxNameNguoiMuon.Text!=""&&comboBox1.SelectedItem!=null)
                button1.Enabled = true;
            else button1.Enabled = false;
        }
        public void GUI()
        {
            if(MaMuon!="")
            {
                groupBox.Text = "Sửa lịch sử";
                MuonSach muonSach = BLL.BLLQLMT.Instance.GetMuonSachByMaMuon(MaMuon);
                textBoxMaNguoiMuon.Text = muonSach.Mã_Người_Mượn;
                textBoxMaSach.Text = muonSach.Mã_Sách;
                textBoxNameNguoiMuon.Text = muonSach.Tên_Người_Mượn;
                if (muonSach.Tình_Trạng == "Tốt") comboBox1.SelectedIndex=0;
                else comboBox1.SelectedIndex = 1;
                dateTimePicker1.Value = muonSach.Thời_Gian_Mượn.Value;
                dateTimePicker2.Value = muonSach.Thời_Gian_Trả.Value;
            }
        }
    }
}
