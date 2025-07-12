using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Models.TriviaModels
{
    public class TriviaViewModel
    {

        public string Pergunta { get; private set; }
        public string Resposta_Correta { get; private set; }
        public TriviaViewModel(string pergunta, string resposta_Correta)
        {
            Pergunta = pergunta;
            Resposta_Correta = resposta_Correta;
        }


    }
}
