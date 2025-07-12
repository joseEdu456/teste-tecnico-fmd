using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Models
{
    public class UpdateParticipanteInputModel
    {

        public int ParticipanteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public UpdateParticipanteInputModel() { }
        public UpdateParticipanteInputModel(int id, string nome, string email, string telefone)
        {
            ParticipanteId = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
