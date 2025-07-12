using API.Application.Interfaces;
using API.Application.Models;
using API.Core.Interfaces;
using API.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Services
{
    public class ParticipanteService : IParticipanteService
    {
        private readonly IParticipanteRepository _repository;
        public ParticipanteService(IParticipanteRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> DeleteParticipante(int id)
        {
            var participante = await _repository.GetParticipante(id);

            if(participante is null)
            {
                return ResultViewModel.Error("Participante não encontrado");
            }

            participante.SetDeleted();

            await _repository.DeleteParticipante(participante);

            return ResultViewModel.Sucess();
        }

        public async Task<ResultViewModel<List<ParticipanteViewModel>>> GetAllParticipantes()
        {
            var participantes = await _repository.GetAllParticipante();

            if (!participantes.Any())
            {
                return ResultViewModel<List<ParticipanteViewModel>>.Error("Nenhum participante cadastrado");
            }

            var result = participantes.Select(ParticipanteViewModel.ToEntity).ToList();

            return ResultViewModel<List<ParticipanteViewModel>>.Sucess(result);
        }

        public async Task<ResultViewModel<int>> PostParticipante(ParticipanteInputModel model)
        {
            var participante = model.ToEntity();

            await _repository.PostParticipante(participante);

            return ResultViewModel<int>.Sucess(participante.Id);
        }

        public async Task<ResultViewModel> UpdateParticipante(int id, UpdateParticipanteInputModel model)
        {
            var participante = await _repository.GetParticipante(id);

            if(participante is null)
            {
                return ResultViewModel.Error("Participante não encontrado");
            }

            participante.AtualizarDadosParticipante(model.Nome, model.Email, model.Telefone);

            await _repository.UpdateParticipante(participante);

            return ResultViewModel.Sucess();
        }
    }
}
