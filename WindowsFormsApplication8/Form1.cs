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

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        private void veri_oku()
        {
            OleDbCommand veri = new OleDbCommand("select * from tablo order by Kimlik", baglanti);
            OleDbDataReader oku = null;
            baglanti.Open();
            oku = veri.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem kayit = new ListViewItem(oku["Kimlik"].ToString());
                kayit.SubItems.Add(oku["Tarih"].ToString());
                kayit.SubItems.Add(oku["Saat"].ToString());
                kayit.SubItems.Add(oku["Tür"].ToString());
                kayit.SubItems.Add(oku["Açıklama"].ToString());
                kayit.SubItems.Add(oku["Giren"].ToString());
                kayit.SubItems.Add(oku["Çıkan"].ToString());
                listView1.Items.Add(kayit);
            }
            oku.Close();
            baglanti.Close();
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            veri_oku();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giren goster = new giren();
            goster.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cikan goster = new cikan();
            goster.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                a = int.Parse(listView1.SelectedItems[0].Text);
                OleDbCommand sil = new OleDbCommand("delete from tablo where Kimlik=" + a + "", baglanti);
                baglanti.Open();
                sil.ExecuteNonQuery();
                baglanti.Close();
                veri_oku();
                MessageBox.Show("Silme İşlemi Başarılı...");
            }
            catch
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Kaydı Üstteki Tablodan Seçiniz...");
            }
        }
        int id = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yazdir goster = new yazdir();
            goster.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            veri_oku();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rapor rpr = new rapor();
            rpr.ShowDialog();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yardim yrdm = new yardim();
            yrdm.ShowDialog();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
