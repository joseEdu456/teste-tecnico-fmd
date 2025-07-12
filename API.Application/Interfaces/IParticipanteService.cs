using API.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Interfaces
{
    public interface IParticipanteService
    {
        Task<ResultViewModel<List<ParticipanteViewModel>>> GetAllParticipantes();
        Task<ResultViewModel<int>> PostParticipante(ParticipanteInputModel model);
        Task<ResultViewModel> UpdateParticipante(int id, UpdateParticipanteInputModel model);
        Task<ResultViewModel> DeleteParticipante(int id);
    }
}
