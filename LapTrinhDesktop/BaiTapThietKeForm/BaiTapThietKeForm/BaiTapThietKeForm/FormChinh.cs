using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class FormChinh : System.Windows.Forms.Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

      
        private void tsmibai1_Click(object sender, EventArgs e)
        {
            var form = new FormBaiTap1();
            form.ShowDialog();
        }

        private void tsmibai2_Click(object sender, EventArgs e)
        {
            var form = new FormBaiTap2();
            form.ShowDialog();
        }

        private void tsmibai3_Click(object sender, EventArgs e)
        {
            var form = new FormBaiTap3();
            form.ShowDialog();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }
    }
}