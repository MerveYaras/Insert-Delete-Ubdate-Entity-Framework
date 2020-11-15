﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ürün_CRUD.Data.Entity
{
    public class Supplier
    {
        int _supplierID;
        string _companyName;
        string _contactName;
        string _contactTitle;
        string _address;
        string _city;
        string _region;
        string _postalCode;
        string _country;
        string _phone;
        string _fax;

        [Key]
        public int SupplierID
        {
            get { return _supplierID; }
            set { _supplierID = value; }
        }
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public string ContactName
        {
            get { return _contactName; }
            set { _contactName = value; }
        }
        public string ContactTitle
        {
            get { return _contactTitle; }
            set { _contactTitle = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Region
        {
            get { return _region; }
            set { _region = value; }
        }
        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
    }
}

