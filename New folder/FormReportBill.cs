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
    public partial class FormReportBill : Form
    {
        public FormReportBill()
        {
            InitializeComponent();
        }

        //Hiển thị khung report
        private void FormReportBill_Load(object sender, EventArgs e)
        {
            this.BillTableAdapter.Fill(this.QLKaraokeDataSet2.Bill);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            this.BillTableAdapter.Fill(this.QLKaraokeDataSet2.Bill);
            this.reportViewer1.RefreshReport();
        }
    }
}
