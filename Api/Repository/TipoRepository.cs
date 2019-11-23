using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System;
using System.Net.Mail;
using Domain.Models;
using Domain.Entities;
using Api.Interface;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using Api.CrossCutting;
namespace Api.Repository
{
    public class TipoRepository : ITipoRepository
    {
        private readonly SIUGlobalContext _context;
        public TipoRepository(SIUGlobalContext context)
        {
            _context = context;
        }

        public Return Tipo_ListarTodos()
        {
            try
            {
                var retorno = _context.Tipo.ToList();
                if (retorno.Any())
                    return Return.Success(retorno);
                else
                    return Return.NotFound;
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }
        }
        public Return Tipo_BuscaDinamicaFlexivel(dynamic Obj)
        {
            try
            {
                string Where = GerarBuscaDinamica.BuscaDinamicaFlexivel(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
                var retorno = _context.Tipo.Where(Where).ToList();
                if (retorno.Any())
                    return Return.Success(retorno);
                else
                    return Return.NotFound;
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }
        }
        public Return Tipo_BuscaDinamicaRigida(dynamic Obj)
        {
            try
            {
                string Where = GerarBuscaDinamica.BuscaDinamicaRigida(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
                var retorno = _context.Tipo.Where(Where).ToList();
                if (retorno.Any())
                    return Return.Success(retorno);
                else
                    return Return.NotFound;
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }
        }
        public Return Tipo_Criar(dynamic Obj)
        {
            try
            {
                Return retorno = new Return();
                Tipo Tipo = JsonConvert.DeserializeObject<Tipo>(Obj.ToString());

                _context.Tipo.Add(Tipo);
                var retornoTipo = _context.SaveChanges();
                if (retornoTipo != 0)
                    return Return.Success("Tipo de exercício cadastrado com sucesso!");
                else
                    return Return.CustomError("Erro ao salvar o Tipo do exercício.");
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }
        }
        public Return Tipo_Alterar(dynamic Obj)
        {
            try
            {
                Tipo Tipo = JsonConvert.DeserializeObject<Tipo>(Obj.ToString());
                var vTipo = _context.Tipo.First(p => p.IDTipo == Tipo.IDTipo);
                _context.Entry(vTipo).CurrentValues.SetValues(Tipo);
                _context.SaveChanges();
                return Return.Success("Tipo de exercício alterado com sucesso!");
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }

        }
    }
}