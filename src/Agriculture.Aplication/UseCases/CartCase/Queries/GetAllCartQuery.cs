using Agriculture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.CartCase.Queries
{
    public class GetAllCartQuery :IRequest<List<Cart>>
    {

    }
}
