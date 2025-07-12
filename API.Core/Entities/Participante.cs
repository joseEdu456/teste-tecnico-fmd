using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Entities
{
    public class Participante : BaseEntity
    {

        public string Nome { get; private set; }
        public int PalestraId { get; private set; }
        public Palestra Palestra { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public Participante(string nome, int palestraId, string email, string telefone) : base()
        {
            Nome = nome;
            PalestraId = palestraId;
            Email = email;
            Telefone = telefone;
        }

        public void AtualizarDadosParticipante(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
