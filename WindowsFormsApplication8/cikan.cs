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

namespace WindowsFormsApplication8
{
    public partial class cikan : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb");
        OleDbCommand komut = new OleDbCommand();
        public cikan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text.Trim() != "" && dateTimePicker2.Text.Trim() != "" && textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                string tarih = dateTimePicker1.Text.Trim();
                string saat = dateTimePicker2.Text.Trim();
                string tur = "Çıkan";
                string aciklama = textBox1.Text.Trim();
                int cmiktar = Convert.ToInt32(textBox2.Text.Trim());

                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO tablo (Tarih, Saat, Tür, Açıklama, Çıkan) VALUES('" + tarih + "','" + saat + "','" + tur + "','" + aciklama + "','" + cmiktar + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla eklenmiştir.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
