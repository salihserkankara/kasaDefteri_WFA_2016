using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class rapor : Form
    {
        public rapor()
        {
            InitializeComponent();
        }

        private void rapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database2DataSet7.tablo' table. You can move, or remove it, as needed.
            this.tabloTableAdapter2.Fill(this.Database2DataSet7.tablo);
            // TODO: This line of code loads data into the 'Database2DataSet7.tablo' table. You can move, or remove it, as needed.
            //this.tabloTableAdapter.Fill(this.Database2DataSet7.tablo);
            // TODO: This line of code loads data into the 'Database2DataSet6.tablo' table. You can move, or remove it, as needed.
            //this.tabloTableAdapter1.Fill(this.Database2DataSet6.tablo);
            // TODO: This line of code loads data into the 'Database2DataSet5.tablo' table. You can move, or remove it, as needed.
            //this.tabloTableAdapter.Fill(this.Database2DataSet5.tablo);

            this.reportViewer1.RefreshReport();
        }
    }
}
