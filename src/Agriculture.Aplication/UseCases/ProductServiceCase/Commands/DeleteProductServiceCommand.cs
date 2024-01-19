﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductServiceCase.Commands
{
    public class DeleteProductServiceCommand :IRequest<bool>
    {
        public int Id { get; set; } 
    }
}
