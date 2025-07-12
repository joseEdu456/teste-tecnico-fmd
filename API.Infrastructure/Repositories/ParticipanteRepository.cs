using API.Core.Entities;
using API.Core.Interfaces;
using API.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.Repositories
{
    public class ParticipanteRepository : IParticipanteRepository
    {
        private readonly ApplicationDbContext _db;
        public ParticipanteRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task DeleteParticipante(Participante participante)
        {
            _db.Participantes.Update(participante);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Participante>> GetAllParticipante()
        {
            return await _db.Participantes.Include(o => o.Palestra)
                                          .Where(o => !o.IsDeleted)
                                          .ToListAsync();
        }

        public async Task<Participante?> GetParticipante(int id)
        {
            return await _db.Participantes.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task PostParticipante(Participante participante)
        {
            _db.Participantes.Add(participante);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateParticipante(Participante participante)
        {
            _db.Participantes.Update(participante);
            await _db.SaveChangesAsync();
        }
    }
}
