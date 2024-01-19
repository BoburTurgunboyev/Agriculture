﻿using Agriculture.Aplication.UseCases.ProductCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.ProductCase.Commands
{
    public class UpdateProductCommand :ProductDto,IRequest<bool>
    {
        public int Id { get; set; } 
    }
}
