using API.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Models
{
    public class PalestraViewModel
    {
        public int PalestraId { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataHora { get; private set; }
        
        public List<string> Participantes { get; private set; }
        public PalestraViewModel(int id, string titulo, string descricao, DateTime dataHora, List<Participante> participantes)
        {
            PalestraId = id;
            Titulo = titulo;
            Descricao = descricao;
            DataHora = dataHora;
            Participantes = participantes.Select(p => p.Nome).ToList();
        }

        public static PalestraViewModel ToEntity(Palestra palestra)
        {
            return new PalestraViewModel(palestra.Id, palestra.Titulo, palestra.Descricao, palestra.DataHora, palestra.Participantes);
        }
    }
}
