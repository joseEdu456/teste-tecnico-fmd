using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Models.TriviaModels
{
    public class ApiTriviaDTO
    {

        public string Categoria { get; set; }
        public string Type { get; set; }
        public string Difficulty { get; set; }
        public string Question { get; set; }
        public string Correct_Answer { get; set; }
        public List<string> Incorrect_Answers { get; set; }
        public ApiTriviaDTO(string categoria, string type, string difficulty, string question, string correct_Answer, List<string> incorrect_Answers)
        {
            Categoria = categoria;
            Type = type;
            Difficulty = difficulty;
            Question = question;
            Correct_Answer = correct_Answer;
            Incorrect_Answers = incorrect_Answers;
        }

        public TriviaViewModel GetViewModel()
        {
            return new TriviaViewModel(Question, Correct_Answer);
        }
        
    }
}
