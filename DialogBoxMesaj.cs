using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ürün_CRUD
{
    public class DialogBoxMesaj
    {
        string _uyari;
        string _mesaj;
        public string Mesaj { get { return _mesaj; } set { _mesaj = value; } }
        public string Uyari { get { return _uyari; } set { _uyari = value; } }
    }
}
