using API.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Interfaces
{
    public interface IPalestraService
    {
        Task<ResultViewModel<List<PalestraViewModel>>> GetAllPalestra();
        Task<ResultViewModel<int>> PostPalestra(PalestraInputModel model);
        
    }
}
