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
    public partial class Form3 : Form
    {
        QLTV db = new QLTV();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = BLL.BLLQLAccount.Instance.TaiKhoanHienTai();
            
            if (textBoxMKHT.Text != account.PassWord) MessageBox.Show("Mật khẩu không đúng :<");
            else if (textBoxMKM.Text != textBoxNLMK.Text) MessageBox.Show("Mật khẩu không khớp :<");
            else
            {
                BLL.BLLQLAccount.Instance.DoiMatKhau(account, textBoxMKM.Text);
                this.Close();
                MessageBox.Show("Đổi mật khẩu thành công :>");
            }
        }
    }
}
