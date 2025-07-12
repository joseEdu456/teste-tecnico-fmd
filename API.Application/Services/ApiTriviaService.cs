using API.Application.Interfaces;
using API.Application.Models;
using API.Application.Models.TriviaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace API.Application.Services
{
    public class ApiTriviaService : IApiExtensionService
    {
        private readonly HttpClient _httpClient;
        public ApiTriviaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResultViewModel<TriviaViewModel>> GetTrivia()
        {
            string urlApi = $"https://opentdb.com/api.php?amount=1";

            var resposta = await _httpClient.GetAsync(urlApi);

            if (!resposta.IsSuccessStatusCode)
            {
                return ResultViewModel<TriviaViewModel>.Error("Erro ao acessar a API");
            }

            string conteudoString = await resposta.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var dados = JsonSerializer.Deserialize<TriviaResponse>(conteudoString, options);
            ApiTriviaDTO resultado = dados.Results.FirstOrDefault();

            var result = resultado.GetViewModel();

            return ResultViewModel<TriviaViewModel>.Sucess(result);   
        }
    }
}
