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
    public class ExercicioRepository : IExercicioRepository
    {
        private readonly SIUGlobalContext _context;
        public ExercicioRepository(SIUGlobalContext context)
        {
            _context = context;
        }

        public Return Exercicio_ListarTodos()
        {
            try
            {
                var retorno = _context.Exercicio.ToList();
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
        public Return Exercicio_BuscaDinamicaFlexivel(dynamic Obj)
        {
            try
            {
                string Where = GerarBuscaDinamica.BuscaDinamicaFlexivel(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
                var retorno = _context.Exercicio.Where(Where).ToList();
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
        public Return Exercicio_BuscaDinamicaRigida(dynamic Obj)
        {
            try
            {
                string Where = GerarBuscaDinamica.BuscaDinamicaRigida(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
                var retorno = _context.Exercicio.Where(Where).ToList();
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
        public Return Exercicio_Criar(dynamic Obj)
        {
            try
            {
                Return retorno = new Return();
                Exercicio Exercicio = JsonConvert.DeserializeObject<Exercicio>(Obj.ToString());

                _context.Exercicio.Add(Exercicio);
                var retornoExercicio = _context.SaveChanges();
                if (retornoExercicio != 0)
                    return Return.Success(Exercicio);
                else
                    return Return.CustomError("Erro ao salvar o Exercicio do exercício.");
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }
        }
        public Return Exercicio_Alterar(dynamic Obj)
        {
            try
            {
                Exercicio Exercicio = JsonConvert.DeserializeObject<Exercicio>(Obj.ToString());
                var vExercicio = _context.Exercicio.First(p => p.IDExercicio == Exercicio.IDExercicio);
                _context.Entry(vExercicio).CurrentValues.SetValues(Exercicio);
                _context.SaveChanges();
                return Return.Success(Exercicio);
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }

        }
    }
}