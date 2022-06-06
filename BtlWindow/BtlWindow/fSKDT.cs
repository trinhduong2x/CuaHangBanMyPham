using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlWindow
{
    public partial class fSKDT : Form
    {
        DateTime start, end;
        public fSKDT()
        {
            InitializeComponent();
        }

        private void btnExel_Click(object sender, EventArgs e)
        {

        }

        private void fSKDT_Load(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            
        }
    }
}
