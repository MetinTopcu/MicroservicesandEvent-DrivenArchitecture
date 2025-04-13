using MetinTopcu.Backend.src.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinTopcu.Backend.ProfileService.Core.Entities
{
    public class Profile : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string GitHub { get; set; }
    }
}
