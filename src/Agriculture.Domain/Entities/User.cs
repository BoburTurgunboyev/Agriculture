using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Domain.Entities
{
    internal class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Image {  get; set; }
        public string Job { get; set; }

    }
}
