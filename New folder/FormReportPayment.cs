using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKaraoke
{
    public partial class FormReportPayment : Form
    {
        public static string N8_1 = string.Empty;
        public FormReportPayment()
        {
            InitializeComponent();
        }

        //Hiển thị khung report thanh toán 
        private void FormReportPayment_Load(object sender, EventArgs e)
        {
            this.USP_ReportBillPaymentTableAdapter.Fill(this.QLKaraokeDataSet.USP_ReportBillPayment, N8_1);
            this.reportViewer1.RefreshReport();
        }
    }
}
