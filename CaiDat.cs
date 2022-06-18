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
    public partial class CaiDat : Form
    {
        public delegate void Mydel(Control control);
        public Mydel d;
        public CaiDat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void buttonDMK_Click(object sender, EventArgs e)
        {
            
        }
    }
}
