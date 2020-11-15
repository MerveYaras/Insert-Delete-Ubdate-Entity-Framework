using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ürün_CRUD.Data.Entity
{
    public class Product
    {
        int _productID;
        string _productName;
        int _supplierID;
        int _categoryID;
        string _quantityPerUnit;
        decimal _unitPrice;
        Int16 _unitsInStock;
        Int16 _unitsOnOrder;
        Int16 _reorderLevel;
        bool _discontinued;

        [Key]
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }


        public int SupplierID
        {
            get { return _supplierID; }
            set { _supplierID = value; }
        }
        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }


        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        public string QuantityPerUnit
        {
            get { return _quantityPerUnit; }
            set { _quantityPerUnit = value; }
        }

        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }

        }

        public Int16 UnitsInStock
        {
            get { return _unitsInStock; }
            set { _unitsInStock = value; }

        }

        public Int16 UnitsOnOrder
        {
            get { return _unitsOnOrder; }
            set { _unitsOnOrder = value; }
        }

        public Int16 ReorderLevel
        {
            get { return _reorderLevel; }
            set { _reorderLevel = value; }
        }

        public bool Discontinued
        {
            get { return _discontinued; }
            set { _discontinued = value; }
        }

    }
}

