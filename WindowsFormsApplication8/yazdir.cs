using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.IO;

namespace WindowsFormsApplication8
{
    public partial class yazdir : Form
    {
        
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb");
        public yazdir()
        {
            InitializeComponent();
        }
        
        private void girentoplam()
        {
            string islem = "select sum (Giren) as gtoplam from tablo";
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(islem, baglanti);
            textBox1.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void cikantoplam()
        {
            string islem = "select sum (Çıkan) as ctoplam from tablo";
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(islem, baglanti);
            textBox2.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rapor rpr = new rapor();
            rpr.ShowDialog();
        }
        private void yazdir_Load(object sender, EventArgs e)
        {
            girentoplam();
            cikantoplam();
            textBox3.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
        }
        
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
    }
}
