using Agriculture.Aplication.UseCases.ProductServiceCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductServiceCase.Commands
{
    public class UpdateProductServiceCommand:ProductServiceDto,IRequest<bool>
    {
        public int Id { get; set; }
    }
}
