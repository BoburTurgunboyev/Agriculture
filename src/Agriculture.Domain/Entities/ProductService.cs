using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Domain.Entities
{
    public class ProductService
    {
        public int Id { get; set; }
        public string DairyProducts { get; set; }
        public string StoreServices { get; set; }
        public string DeliveryServices { get; set; }
        public string AgriculturalServices { get; set; }
        public string OrganicProducts { get; set; }
        public string FreshVegetables { get; set; }
        public Product Product { get; set; }
    }
}
