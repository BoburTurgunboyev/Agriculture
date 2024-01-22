﻿using Agriculture.Aplication.UseCases.UserCase.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Aplication.UseCases.UserCase.Commands
{
    public class UpdateUserCommand:UserDto,IRequest<bool>
    {
        public int Id {  get; set; } 
    }
}
