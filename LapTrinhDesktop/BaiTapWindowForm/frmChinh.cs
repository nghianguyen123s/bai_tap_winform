using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowForm
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        
        private void tsbBai1_Click(object sender, EventArgs e)
        {
            //Mở form bài 1 khi nhấn vào nút bài 1 trên form chính
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            //Mở form bài 2 khi nhấn vào nút bài 2 trên form chính
            var form = new frmBai2();
            form.ShowDialog();
        }

        private void tsbBai3_Click(object sender, EventArgs e)
        {
            //Mở form bài 3 khi nhấn vào nút bài 3 trên form chính
            var form = new frmBai3();
            form.ShowDialog();
        }
    }
}
