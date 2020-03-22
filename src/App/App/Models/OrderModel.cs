using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class OrderModel
    {
        public string Id { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
       
    }
}