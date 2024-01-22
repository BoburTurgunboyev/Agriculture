using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductNewsCase.Dtos
{
    public class ProductNewsDto
    {
        public IFormFile Image { get; set; }
        public string Vitamin { get; set; }
        public string VitaminDescription { get; set; }
    }
}
