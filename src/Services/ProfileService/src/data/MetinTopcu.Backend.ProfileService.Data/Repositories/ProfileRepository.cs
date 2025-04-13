using MetinTopcu.Backend.ProfileService.Core.Entities;
using MetinTopcu.Backend.ProfileService.Data.Abstractions;
using MetinTopcu.Backend.src.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinTopcu.Backend.ProfileService.Data.Repositories
{
    public class ProfileRepository<TDbContext> : GenericRepository<Profile, TDbContext, Guid>, IProfileRepository where TDbContext : DbContext
    {
        public ProfileRepository(TDbContext dbContext) : base(dbContext)
        {
        }
    }
}
