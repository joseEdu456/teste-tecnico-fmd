using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Entities
{
    public class Palestra : BaseEntity
    {
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataHora { get; private set; }
        public List<Participante> Participantes { get; private set; }
        public Palestra(string titulo, string descricao, DateTime dataHora) : base()
        {
            Titulo = titulo;
            Descricao = descricao;
            DataHora = dataHora;

            Participantes = [];
        }
    }
}
