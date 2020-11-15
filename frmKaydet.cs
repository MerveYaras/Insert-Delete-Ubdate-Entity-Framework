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
    public partial class frmKaydet : Form
    {
        public frmKaydet()
        {
            InitializeComponent();
        }

        private void frmKaydet_Load(object sender, EventArgs e)
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
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogBoxMesaj m = new DialogBoxMesaj();
            m.Mesaj = "Kaydetmekİstediğinizden EminMisiniz?";
            m.Uyari = "Dikkat!";
            DialogBoxKutusu f = new DialogBoxKutusu(m);
            f.StartPosition = FormStartPosition.CenterScreen;
            DialogResult response = f.ShowDialog();

            if (response == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                NorthwindDbContext tablo = new NorthwindDbContext();
                Product c = new Product();
                c.ProductName = textBox1.Text;
                c.SupplierID = Convert.ToInt32(comboBox2.SelectedValue);
                c.CategoryID = Convert.ToInt32(comboBox1.SelectedValue);
                c.QuantityPerUnit = textBox2.Text;
                c.UnitPrice = Convert.ToDecimal(textBox3.Text);
                c.UnitsInStock = Convert.ToInt16(textBox4.Text);
                c.UnitsOnOrder = Convert.ToInt16(textBox7.Text);
                c.ReorderLevel = Convert.ToInt16(textBox6.Text);
                if (checkBox1.Checked == true) { c.Discontinued = true; }
                else { c.Discontinued = false; }

                tablo.Products.Add(c);
                tablo.SaveChanges();
                MessageBox.Show("Kaydetme Yapıldı.");
               
            }
            else if (response == DialogResult.No)
            { f.Close(); }
            else if (response == DialogResult.Cancel)
            { f.Close(); }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
