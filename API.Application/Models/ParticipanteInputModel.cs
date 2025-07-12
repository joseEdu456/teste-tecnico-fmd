using API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Models
{
    public class ParticipanteInputModel
    {
        public string Nome { get; set; }
        public int PalestraId { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public ParticipanteInputModel(string nome, int palestraId, string email, string telefone)
        {
            Nome = nome;
            PalestraId = palestraId;
            Email = email;
            Telefone = telefone;
        }

        public Participante ToEntity()
        {
            return new Participante(Nome, PalestraId, Email, Telefone);
        }
    }
}
