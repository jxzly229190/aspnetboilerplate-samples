using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace SimpleTaskSystem.Pets.Dtos
{
    [AutoMapFrom(typeof (Pet))]
    public class PetDto : EntityDto
    {
        public string Name { get; set; }
    }
}
