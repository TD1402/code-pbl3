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
    public partial class ShowSach : UserControl
    {
       
        QLTV db = new QLTV();
        public ShowSach()
        {
            InitializeComponent();
            
            AddLoaiSach();
            listBox1.SelectedIndex = 0;
            dataGridView1.DataSource = BLL.BLLQLS.Instance.HienThi(BLL.BLLQLS.Instance.GetAllSach());
           
        }
        public void AddLoaiSach()
        {
            listBox1.Items.Add("All");
            foreach (string s in BLL.BLLQLS.Instance.GetLoaiSach().Distinct())
            {
                
                listBox1.Items.Add(s);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            if (n == "" || listBox1.SelectedItem.ToString() == "All")
            {
                dataGridView1.DataSource = BLL.BLLQLS.Instance.HienThi(BLL.BLLQLS.Instance.GetSachByName(n));
                listBox1.SelectedItem = listBox1.Items[0];
            }
            else
            {
                string loai = listBox1.SelectedItem.ToString();
                dataGridView1.DataSource = BLL.BLLQLS.Instance.HienThi(BLL.BLLQLS.Instance.GetSach(n, loai));
            }
            textBox1.Text = "";
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dataGridView1.CurrentRow;
            textBoxMS.Text = r.Cells["Mã_sách"].Value.ToString();
            textBoxTS.Text = r.Cells["Tên_sách"].Value.ToString();
            textBoxNhaXB.Text = r.Cells["Nhà_xuất_bản"].Value.ToString();
            textBoxNamXB.Text = r.Cells["Năm_xuất_bản"].Value.ToString();
            textBoxTG.Text = r.Cells["Tác_giả"].Value.ToString();
            textBoxLoai.Text = r.Cells["Loại"].Value.ToString();
            textBoxGia.Text = r.Cells["Giá"].Value.ToString();
            textBoxSL.Text = r.Cells["Số_lượng"].Value.ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = listBox1.SelectedItem.ToString();
            if (s == "All") dataGridView1.DataSource = BLL.BLLQLS.Instance.HienThi(BLL.BLLQLS.Instance.GetAllSach());
            else dataGridView1.DataSource = BLL.BLLQLS.Instance.HienThi(BLL.BLLQLS.Instance.GetSachByLoai(s));
        }

 
    }
}
