using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Models.TriviaModels
{
    public class TriviaResponse
    {
        public int Response_Code { get; set; }
        public List<ApiTriviaDTO> Results { get; set; }
    }
}
