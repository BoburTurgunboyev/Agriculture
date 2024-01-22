using Agriculture.Aplication.FileSercives.ITTradeSoft.Application.FileServices;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductCase.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; }
        public IFormFile Image { get; set; }
        public decimal Price { get; set; }
        
     
    }
}
