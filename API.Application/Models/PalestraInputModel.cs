using API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Models
{
    public class PalestraInputModel
    {

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public PalestraInputModel(string titulo, string descricao, DateTime dataHora)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataHora = dataHora;
        }

        public Palestra ToEntity()
        {
            return new Palestra(Titulo, Descricao, DataHora);
        }
    }
}
