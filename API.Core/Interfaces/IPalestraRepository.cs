using API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Interfaces
{
    public interface IPalestraRepository
    {
        Task<List<Palestra>> GetPalestras();
        Task PostPalestra(Palestra model);
    }
}
