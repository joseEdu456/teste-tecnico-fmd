using API.Application.Models;
using API.Application.Models.TriviaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Interfaces
{
    public interface IApiExtensionService
    {
        Task<ResultViewModel<TriviaViewModel>> GetTrivia();
    }
}
