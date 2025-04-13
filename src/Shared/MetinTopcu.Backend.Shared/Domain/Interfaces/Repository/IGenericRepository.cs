using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetinTopcu.Backend.src.Domain.Interfaces;

namespace MetinTopcu.Backend.src.Domain.Interfaces.Repository
{
    public interface IGenericRepository<T, U> : IGenericQueryRepository<T, U>, IGenericCudRepository<T, U> where T : IEntity<U> where U : struct
    {
    }
}
