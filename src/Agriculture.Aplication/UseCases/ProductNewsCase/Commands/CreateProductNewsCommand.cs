using Agriculture.Aplication.UseCases.ProductNewsCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductNewsCase.Commands
{
    public class CreateProductNewsCommand :ProductNewsDto,IRequest<bool>
    {
    }
}
