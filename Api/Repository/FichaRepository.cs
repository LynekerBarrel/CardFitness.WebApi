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
    public class FichaRepository : IFichaRepository
    {
        private readonly SIUGlobalContext _context;
        public FichaRepository(SIUGlobalContext context)
        {
            _context = context;
        }

        #region Ficha
        public Return Ficha_ListarTodos()
        {
            try
            {
                var retorno = _context.Ficha.ToList();
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
        public Return Ficha_BuscaDinamicaFlexivel(dynamic Obj)
        {
            try
            {
                string Where = GerarBuscaDinamica.BuscaDinamicaFlexivel(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
                var retorno = _context.Ficha.Where(Where).ToList();
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
        public Return Ficha_BuscaDinamicaRigida(dynamic Obj)
        {
            try
            {
                string Where = GerarBuscaDinamica.BuscaDinamicaRigida(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
                var retorno = _context.Ficha.Where(Where).ToList();
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
        public Return Ficha_Criar(dynamic Obj)
        {
            try
            {
                Return retorno = new Return();
                Ficha Ficha = JsonConvert.DeserializeObject<Ficha>(Obj.ToString());

                _context.Ficha.Add(Ficha);
                var retornoFicha = _context.SaveChanges();
                if (retornoFicha != 0)
                    return Return.Success("Ficha criada com sucesso!");
                else
                    return Return.CustomError("Erro ao salvar o Ficha do exercício.");
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }
        }
        public Return Ficha_Alterar(dynamic Obj)
        {
            try
            {
                Ficha Ficha = JsonConvert.DeserializeObject<Ficha>(Obj.ToString());
                var vFicha = _context.Ficha.First(p => p.IDFicha == Ficha.IDFicha);
                _context.Entry(vFicha).CurrentValues.SetValues(Ficha);
                _context.SaveChanges();
                return Return.Success("Ficha alterada com sucesso!");
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }

        }
        #endregion

        #region FichaExercicio
        public Return FichaExercicio_BuscaDinamicaFlexivel(dynamic Obj)
        {
            try
            {
                string Where = GerarBuscaDinamica.BuscaDinamicaFlexivel(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
                var retorno = _context.FichaExercicio.Where(Where).ToList();
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
        public Return FichaExercicio_BuscaDinamicaRigida(dynamic Obj)
        {
            try
            {
                string Where = GerarBuscaDinamica.BuscaDinamicaRigida(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
                var retorno = _context.FichaExercicio.Where(Where).ToList();
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
        public Return FichaExercicio_Criar(dynamic Obj)
        {
            try
            {
                Return retorno = new Return();
                FichaExercicio FichaExercicio = JsonConvert.DeserializeObject<FichaExercicio>(Obj.ToString());

                _context.FichaExercicio.Add(FichaExercicio);
                var retornoFichaExercicio = _context.SaveChanges();
                if (retornoFichaExercicio != 0)
                    return Return.Success("Exercício foi vinculado a ficha com sucesso!");
                else
                    return Return.CustomError("Erro ao salvar o FichaExercicio do exercício.");
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }
        }
        public Return FichaExercicio_Alterar(dynamic Obj)
        {
            try
            {
                FichaExercicio FichaExercicio = JsonConvert.DeserializeObject<FichaExercicio>(Obj.ToString());
                var vFichaExercicio = _context.FichaExercicio.First(p => p.IDFichaExercicio == FichaExercicio.IDFichaExercicio);
                _context.Entry(vFichaExercicio).CurrentValues.SetValues(FichaExercicio);
                _context.SaveChanges();
                return Return.Success("Erro ao alterar o vínculo do exercício na ficha");
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }

        }
        #endregion

        #region FilaFicha
        public Return FilaFicha_BuscaDinamicaFlexivel(dynamic Obj)
        {
            try
            {
                string Where = GerarBuscaDinamica.BuscaDinamicaFlexivel(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
                var retorno = _context.FilaFicha.Where(Where).ToList();
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
        public Return FilaFicha_BuscaDinamicaRigida(dynamic Obj)
        {
            try
            {
                string Where = GerarBuscaDinamica.BuscaDinamicaRigida(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
                var retorno = _context.FilaFicha.Where(Where).ToList();
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
        public Return FilaFicha_Alterar(dynamic Obj)
        {
            try
            {
                FilaFicha FilaFicha = JsonConvert.DeserializeObject<FilaFicha>(Obj.ToString());
                var vFilaFicha = _context.FilaFicha.First(p => p.IDFilaFicha == FilaFicha.IDFilaFicha);
                _context.Entry(vFilaFicha).CurrentValues.SetValues(FilaFicha);
                _context.SaveChanges();
                return Return.Success("Parabéns! Executado com sucesso!");
            }
            catch (Exception ex)
            {
                return Return.CatchedError(ex);
            }

        }
        #endregion
    }
}