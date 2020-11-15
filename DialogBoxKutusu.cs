using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ürün_CRUD
{
    public partial class DialogBoxKutusu : Form
    {
        DialogBoxMesaj _m;
        public DialogBoxKutusu(DialogBoxMesaj m)
        {
            _m = m;
            InitializeComponent();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnHayır_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void DialogBox_Load(object sender, EventArgs e)
        {
            lblHata.Text = _m.Uyari;
            lblMesaj.Text = _m.Mesaj;
        }
    }
}
