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
    public partial class FormBaiTap3 : Form
    {
        public FormBaiTap3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormBaiTap3_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int so;
            for (int i = 1; i < 10; i++)
            {
                so = random.Next(1, 100);
                listBox1.Items.Add(so);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSo.Text);
            label3.Text = "Không tìm thấy";

            foreach (int so in listBox1.Items)
            {
                if (so == soCanTim)
                    label3.Text = "Tìm thấy số ";
                break;
            }    

        }


            
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
