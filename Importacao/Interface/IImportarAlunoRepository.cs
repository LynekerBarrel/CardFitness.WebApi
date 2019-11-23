using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Interface
{
    public interface IImportarAlunoRepository
    {
        Task<Return> ImportarAlunos();
    }
}
