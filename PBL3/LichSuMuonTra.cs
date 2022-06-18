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
    public partial class LichSuMuonTra : UserControl
    {
        
        int n;
        QLTV db = new QLTV();
        public LichSuMuonTra(int index)
        {
            InitializeComponent();
            n = index;
            ShowLS();
        }
        public void ShowLS()
        {

            if (n == 0)
            {
                groupBox1.Text = "LỊCH SỬ MƯỢN";
                buttonThem.Text = "Mượn";
                dataGridView1.DataSource = BLL.BLLQLMT.Instance.HienThi(BLL.BLLQLMT.Instance.GetAllLichSuMuon());
                this.PanelLichSu.Controls.Clear();
                LS ls = new LS(null);
                this.PanelLichSu.Controls.Add(ls);
                ls.Dock = DockStyle.Fill;
                ls.Show();
            }
            else
            {
                groupBox1.Text = "LỊCH SỬ TRẢ";
                buttonThem.Text = "Trả";
                dataGridView1.DataSource=  BLL.BLLQLMT.Instance.HienThiTra(BLL.BLLQLMT.Instance.GetAllLichSuTra());
                this.PanelLichSu.Controls.Clear();
                LST ls = new LST(null);
                this.PanelLichSu.Controls.Add(ls);
                ls.Dock = DockStyle.Fill;
                ls.Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(n== 0)
            {
                
                this.PanelLichSu.Controls.Clear();
                DataGridViewRow r = dataGridView1.CurrentRow;
                LS ls = new LS(r);
                this.PanelLichSu.Controls.Add(ls);
                ls.Dock = DockStyle.Fill;
                ls.Show();
            }
           else
            {
               
                this.PanelLichSu.Controls.Clear();
                DataGridViewRow r = dataGridView1.CurrentRow;
                LST ls = new LST(r);
                this.PanelLichSu.Controls.Add(ls);
                ls.Dock = DockStyle.Fill;
                ls.Show();
            }

        }
        public void ReLoad()
        {
            dataGridView1.DataSource = BLL.BLLQLMT.Instance.HienThi(BLL.BLLQLMT.Instance.GetAllLichSuMuon());
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {

            this.PanelLichSu.Controls.Clear();
            AddUpdateMuonSach au = new AddUpdateMuonSach("");
            au.d = new AddUpdateMuonSach.Mydel(ReLoad);
            this.PanelLichSu.Controls.Add(au);
            au.Dock = DockStyle.Fill;
            au.Show();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                
                this.PanelLichSu.Controls.Clear();
                string mm = dataGridView1.SelectedRows[0].Cells["Mã_mượn"].Value.ToString();
                AddUpdateMuonSach au = new AddUpdateMuonSach(mm);
                au.d = new AddUpdateMuonSach.Mydel(ReLoad);
                this.PanelLichSu.Controls.Add(au);
                au.Dock = DockStyle.Fill;
                au.Show();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                if(n==0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        string m = row.Cells["Mã_mượn"].Value.ToString();
                        BLL.BLLQLMT.Instance.DeleteMuon(m);
                    }
                    dataGridView1.DataSource = BLL.BLLQLMT.Instance.HienThi(BLL.BLLQLMT.Instance.GetAllLichSuMuon());
                }
                else
                {

                }
                
            }
        }
    }
}
