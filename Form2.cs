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
    public partial class Form2 : Form
    {

       
        public Form2()
        {
            InitializeComponent();
            
        }
        private void buttonXemSach_Click(object sender, EventArgs e)
        {
            this.PanelShowAll.Controls.Clear();
            var Ls = new ShowSach();
            this.PanelShowAll.Controls.Add(Ls);
            Ls.Dock = DockStyle.Fill;
            Ls.Show();
        }
      
        private void buttonCaNhan_Click(object sender, EventArgs e)
        {
            this.PanelShowAll.Controls.Clear();
            var CN = new CaNhan();
            this.PanelShowAll.Controls.Add(CN);
            CN.Dock = DockStyle.Fill;
            CN.Show();
        }
        private void buttonDMK_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
      
        private void button2_Click_1(object sender, EventArgs e)
        {
            CaiDat cd = new CaiDat();
            cd.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonMuonSach_Click(object sender, EventArgs e)
        {
            this.PanelShowAll.Controls.Clear();
            var Ls = new LichSuMuonTra(0);
            this.PanelShowAll.Controls.Add(Ls);
            Ls.Dock = DockStyle.Fill;
            Ls.Show();
        }

        private void buttonTraSach_Click(object sender, EventArgs e)
        {
            this.PanelShowAll.Controls.Clear();
            var Ls = new LichSuMuonTra(1);
            this.PanelShowAll.Controls.Add(Ls);
            Ls.Dock = DockStyle.Fill;
            Ls.Show();
        }

        private void buttonDMK_Click_1(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
