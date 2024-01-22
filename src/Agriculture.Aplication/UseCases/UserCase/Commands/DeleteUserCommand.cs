using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.UserCase.Commands
{
    public class DeleteUserCommand:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
