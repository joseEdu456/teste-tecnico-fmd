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
    public class PalestraService : IPalestraService
    {
        private readonly IPalestraRepository _repository;
        public PalestraService(IPalestraRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<List<PalestraViewModel>>> GetAllPalestra()
        {
            var palestras = await _repository.GetPalestras();

            if (!palestras.Any())
            {
                return ResultViewModel<List<PalestraViewModel>>.Error("Nenhuma palestra cadastrada ainda");
            }

            var model = palestras.Select(PalestraViewModel.ToEntity).ToList();

            return ResultViewModel<List<PalestraViewModel>>.Sucess(model);
        }

        public async Task<ResultViewModel<int>> PostPalestra(PalestraInputModel model)
        {
            var palestra = model.ToEntity();

            await _repository.PostPalestra(palestra);

            return ResultViewModel<int>.Sucess(palestra.Id);
        }
    }
}
