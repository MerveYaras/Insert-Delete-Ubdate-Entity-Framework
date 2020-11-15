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
    public partial class frmGuncelle : Form
    {
        Product _p;
        public frmGuncelle(Product p)
        {
            _p = p;
            InitializeComponent();
        }

        private void frmGuncelle_Load(object sender, EventArgs e)
        {

            NorthwindDbContext tablo = new NorthwindDbContext();
            var category = tablo.Categories.ToList();
            comboBox1.DataSource = category;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";

            var supplier = tablo.Suppliers.ToList();
            comboBox2.DataSource = supplier;
            comboBox2.DisplayMember = "CompanyName";
            comboBox2.ValueMember = "SupplierID";
            Product p = tablo.Products.FirstOrDefault(x => x.ProductID == _p.ProductID);

            textBox1.Text = p.ProductName;
            label9.Text = p.Supplier.CompanyName.ToString();
            label11.Text = p.Category.CategoryName.ToString();
            textBox2.Text = p.QuantityPerUnit;
            textBox3.Text = p.UnitPrice.ToString();
            textBox4.Text = p.UnitsInStock.ToString();
            textBox7.Text = p.UnitsOnOrder.ToString();
            textBox6.Text = p.ReorderLevel.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            DialogBoxMesaj m = new DialogBoxMesaj();
            m.Mesaj = "Güncellemek İstediğinizden EminMisiniz?";
            m.Uyari = "Dikkat!";
            DialogBoxKutusu f = new DialogBoxKutusu(m);
            f.StartPosition = FormStartPosition.CenterScreen;
            DialogResult response = f.ShowDialog();

            if (response == DialogResult.Yes)
            {
                NorthwindDbContext tablo = new NorthwindDbContext();
                Product p = tablo.Products.FirstOrDefault(x => x.ProductID == _p.ProductID);

                p.ProductName = textBox1.Text;
                p.SupplierID = Convert.ToInt32(comboBox2.SelectedValue);
                p.CategoryID = Convert.ToInt32(comboBox1.SelectedValue);
                p.QuantityPerUnit = textBox2.Text;
                p.UnitPrice = Convert.ToDecimal(textBox3.Text);
                p.UnitsInStock = Convert.ToInt16(textBox4.Text);
                p.UnitsOnOrder = Convert.ToInt16(textBox7.Text);
                p.ReorderLevel = Convert.ToInt16(textBox6.Text);
                tablo.SaveChanges();
                MessageBox.Show("Güncelleme Yapıldı.");
                this.Close();
            }
            else if (response == DialogResult.No)
            { f.Close(); }
            else if (response == DialogResult.Cancel)
            { f.Close(); }





        }
    }
}
