using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ürün_CRUD.Data.Entity;

namespace Ürün_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            NorthwindDbContext tablo = new NorthwindDbContext();
            List<Product> c = tablo.Products.ToList();
            dataGridView1.DataSource = c;

        }
        int id;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmKaydet f = new frmKaydet();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                NorthwindDbContext tablo = new NorthwindDbContext();
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Product p = tablo.Products.FirstOrDefault(x => x.ProductID == id);
                frmGuncelle f = new frmGuncelle(p);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else { MessageBox.Show("Lütfen güncellenecek satırı seçiniz."); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            NorthwindDbContext tablo = new NorthwindDbContext();
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Product p = tablo.Products.FirstOrDefault(x => x.ProductID == id);
            DialogBoxMesaj m = new DialogBoxMesaj();
            m.Mesaj = "Silmek İstediğinizdenEmin Misiniz?";
            m.Uyari = "Dikkat!";
            DialogBoxKutusu d = new DialogBoxKutusu(m);
            DialogResult response = d.ShowDialog();
            if (response == DialogResult.Yes)
            {
                tablo.Products.Remove(p);
                tablo.SaveChanges();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            NorthwindDbContext tablo = new NorthwindDbContext();
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Product p = tablo.Products.FirstOrDefault(x => x.ProductID == id);

        }
    }
}
