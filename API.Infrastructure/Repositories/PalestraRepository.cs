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
    public class PalestraRepository : IPalestraRepository
    {
        private readonly ApplicationDbContext _db;
        public PalestraRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Palestra>> GetPalestras()
        {
            return await _db.Palestras.Include(o => o.Participantes
                                      .Where(o => !o.IsDeleted))
                                      .ToListAsync();
        }

        public async Task PostPalestra(Palestra model)
        {
            _db.Palestras.Add(model);
            await _db.SaveChangesAsync();
        }
    }
}
