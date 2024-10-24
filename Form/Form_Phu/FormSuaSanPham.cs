using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11
{
    public partial class form_SuaSanPham : Form
    {
        public form_SuaSanPham()
        {
            InitializeComponent();
        }

        private void btn_TaoDongMay_Click(object sender, EventArgs e)
        {
            form_TaoDongMay form_TaoDongMay = new form_TaoDongMay();

            form_TaoDongMay.ShowDialog();
        }
    }
}
