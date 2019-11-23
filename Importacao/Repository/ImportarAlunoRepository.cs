using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System;
using System.Net.Mail;
using Domain.Models;
using Api.Interface;

namespace Api.Repository
{
    public class ImportarAlunoRepository : IImportarAlunoRepository
    {
        private readonly SIUGlobalContext _context;

        public ImportarAlunoRepository(SIUGlobalContext context)
        {
            _context = context;
        }

        public string BuscarNomePorID(int Sistema)
        {
            var result = _context.Sistema.Where(x => x.CodSistema == Sistema).First();
            return result.DescSistema;
        }

        public Return ListarTodosSistemas()
        {
            var retorno = _context.Sistema.ToList();
            if (retorno.Any())
                return Return.Success(retorno);
            else
                return Return.NotFound;
        }
    }
}