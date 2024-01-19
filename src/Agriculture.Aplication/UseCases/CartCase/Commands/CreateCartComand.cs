using Agriculture.Aplication.UseCases.CartCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.CartCase.Commands
{
    public class CreateCartComand :CartDto,IRequest<bool>
    {
    }
}
