using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductNewsCase.Commands
{
    public class DeleteProductNewsCommand:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
