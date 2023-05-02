using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020523_NBUY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities1 db = new NorthwindEntities1();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.Urunler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.Kategoriler.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kategoriler x = new Kategoriler();
            x.KategoriAdi = textBox1.Text;
            x.Tanimi= textBox2.Text;
            db.Kategoriler.Add(x);
            db.SaveChanges();
            dataGridView1.DataSource = db.Kategoriler.ToList();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Urunler x = new Urunler();
            x.UrunAdi = textBox1.Text;
            db.Urunler.Add(x);
            db.SaveChanges();
            dataGridView1.DataSource = db.Urunler.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var x = db.Kategoriler.Find(id);
            db.Kategoriler.Remove(x);
            db.SaveChanges();
            MessageBox.Show("kayıt silindi");
            dataGridView1.DataSource = db.Kategoriler.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var x = db.Urunler.Find(id);
            db.Urunler.Remove(x);
            db.SaveChanges();
            MessageBox.Show("kayıt silindi");
            dataGridView1.DataSource = db.Urunler.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var x = db.Kategoriler.Find(id);
            x.KategoriAdi = textBox1.Text.ToUpper();
            x.Tanimi = textBox2.Text.ToUpper();
            db.SaveChanges();
            MessageBox.Show("güncellendi");
            dataGridView1.DataSource = db.Kategoriler.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
