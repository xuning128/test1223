using _1223test.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _1223test.ViewModels
{
    public class CProductsVIewModel
    {
        public Products entity_products { get; set; }

        [DisplayName("商品序號")]
        public int ID { get { return this.entity_products.ProductID; } }

        [DisplayName("商品名稱")]
        public string productname { get { return this.entity_products.ProductName; } }


        public int? supplierID { get { return this.entity_products.SupplierID; } }

    }
}