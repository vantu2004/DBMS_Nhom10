using Nhom11.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom11
{
    public partial class form_TaoDongMay : Form
    {
        DonNhapDAO donNhapDAO = new DonNhapDAO();

        public form_TaoDongMay()
        {
            InitializeComponent();
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            DongMay dongMay = new DongMay();

            if (checkNullTaoDongMay())
            {
                dongMay.MaDongMay = BienToanCuc.randomMa9So();
                dongMay.TenDongMay = tbx_TenDongMay.Text;
                dongMay.KichThuocManHinh = tbx_ManHinh.Text;
                dongMay.DungLuongPin = tbx_Pin.Text;

                donNhapDAO.TaoDongMay(dongMay);
                this.Close();
            }
        }

        private bool checkNullTaoDongMay()
        {
            if (!string.IsNullOrEmpty(tbx_TenDongMay.Text) && !string.IsNullOrEmpty(tbx_ManHinh.Text) && !string.IsNullOrEmpty(tbx_Pin.Text))
            {
                return true;
            }
            return false;
        }

    }
}
