using API.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Models
{
    public class ParticipanteViewModel
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string NomePalestra { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public ParticipanteViewModel(int id, string nome, string nomePalestra, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            NomePalestra = nomePalestra;
            Email = email;
            Telefone = telefone;
        }

        public static ParticipanteViewModel ToEntity(Participante participante)
        {
            return new ParticipanteViewModel(participante.Id, participante.Nome, participante.Palestra.Titulo, participante.Email, participante.Telefone);
        }
    }
}
