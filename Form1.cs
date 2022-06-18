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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string TK = textBoxUser.Text;
            string MK = textBoxPass.Text;
            int dem= 0;
            foreach(Account i in BLL.BLLQLAccount.Instance.GetALLAccount())
            {
                if(TK==i.UserName&&MK==i.PassWord)
                {
                    Form2 f = new Form2();
                    f.Show();
                    BLL.BLLQLAccount.Instance.TaiKhoan(i);
                    dem++;
                    textBoxPass.Text = "";
                }
            }
            if (dem == 0) MessageBox.Show("Sai ten tai khoan hoac mat khau");
            
        }

     

      
    }
}
