using MetinTopcu.Backend.ProfileService.Core.Entities;
using MetinTopcu.Backend.src.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinTopcu.Backend.ProfileService.Data.Abstractions
{
    public interface IProfileRepository : IGenericRepository<Profile, Guid>
    {
    }
}
