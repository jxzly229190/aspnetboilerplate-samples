using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace SimpleTaskSystem.Pets
{
    [Table("StsPets")]
    public class Pet:Entity
    {
        public virtual string Name { get; set; }
    }
}
