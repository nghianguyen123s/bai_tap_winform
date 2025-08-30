using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        { 
            if (rdoNam.Checked) 
            MessageBox.Show("Bạn đã chọn giới tính nam","Chúc mừng");
        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNu.Checked)
                MessageBox.Show("Bạn đã chọn giới tính nữ", "Chúc mừng");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTomau_Click(object sender, EventArgs e)
        {
            if(rdDo.Checked)
                txtHopMau.BackColor = Color.Red;
            else if (rdXanh.Checked)
                txtHopMau.BackColor = Color.Blue;
        }
    }
}
