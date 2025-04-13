using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinTopcu.Backend.src.Domain.Interfaces
{
    public interface IEntity<TIDType> where TIDType : struct
    {
        TIDType Id { get; set; }
    }
}
