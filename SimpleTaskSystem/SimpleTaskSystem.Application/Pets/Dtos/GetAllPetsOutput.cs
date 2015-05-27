using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace SimpleTaskSystem.Pets.Dtos
{
    public class GetAllPetsOutput : IOutputDto
    {
        public List<PetDto> Pets { get; set; }
    }
}
