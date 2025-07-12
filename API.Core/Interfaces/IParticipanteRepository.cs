using API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Interfaces
{
    public interface IParticipanteRepository
    {
        Task<Participante?> GetParticipante(int id);
        Task<List<Participante>> GetAllParticipante();
        Task DeleteParticipante(Participante participante);
        Task UpdateParticipante(Participante participante);
        Task PostParticipante(Participante participante);
    }
}
