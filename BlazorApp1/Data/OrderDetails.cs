using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class OrderDetails
    {
        public int Key { get; set; }
        public int Seq { get; set; }
        public int Cust_Id { get; set; }
        public string Cust_Name { get; set; }
        public int Haulier_Id { get; set; }
        public string Haulier_Name { get; set; }
        public string Driver_Name { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string CollectionTown { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryTown { get; set; }

    }
}
