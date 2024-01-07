using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Domain.Entities
{
    public class Farm
    {
        public int Id { get; set; }   
        public string AboutTheFarm { get; set; }
        public string HowToFarm { get; set; }
        public string Conclusion { get; set; }
        public string Description3 { get; set; }
        public Product Product { get; set; }

    }
}
