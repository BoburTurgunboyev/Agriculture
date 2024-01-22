using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.UserCase.Dtos
{
    public class UserDto
    {
        public string FullName { get; set; }
        public IFormFile Image { get; set; }
        public string Job { get; set; }

    }
}
