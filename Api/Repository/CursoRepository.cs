using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System;
using System.Net.Mail;
using Domain.Models;
using Api.Interface;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using Api.CrossCutting;
namespace Api.Repository
{
    public class CursoRepository : ICursoRepository
    {
        private readonly SIUGlobalContext _context;
        //private ISistemaRepository _sistema;
        public CursoRepository(SIUGlobalContext context/*, ISistemaRepository sistema*/)
        {
            _context = context;
            //_sistema = sistema;
        }

        //#region Curso
        //public Return Curso_ListarTodos(int Sistema)
        //{
        //    try
        //    {
        //        var retorno = _context.Cursos.ToList();
        //        if (retorno.Any())
        //            return Return.Success(retorno);
        //        else
        //            return Return.NotFound;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Return.CatchedError(ex, "CursoRepository - Curso_ListarTodos", "Sem parâmetros.", _sistema.BuscarNomePorID(Sistema));
        //    }
        //}
        //public Return Curso_BuscaDinamicaFlexivel(dynamic Obj, int Sistema)
        //{

        //    try
        //    {
        //        string Where = GerarBuscaDinamica.BuscaDinamicaFlexivel(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
        //        var retorno = _context.Cursos.Where(Where).ToList();
        //        if (retorno.Any())
        //            return Return.Success(retorno);
        //        else
        //            return Return.NotFound;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Return.CatchedError(ex, "CursoRepository - Curso_BuscaDinamicaFlexivel", Obj, _sistema.BuscarNomePorID(Sistema));
        //    }
        //}
        //public Return Curso_BuscaDinamicaRigida(dynamic Obj, int Sistema)
        //{
        //    try
        //    {
        //        string Where = GerarBuscaDinamica.BuscaDinamicaRigida(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
        //        var retorno = _context.Cursos.Where(Where).ToList();
        //        if (retorno.Any())
        //            return Return.Success(retorno);
        //        else
        //            return Return.NotFound;

        //    }
        //    catch (Exception ex)
        //    {
        //        return Return.CatchedError(ex, "CursoRepository - Curso_BuscaDinamicaRigida", Obj, _sistema.BuscarNomePorID(Sistema));
        //    }
        //}
        //#endregion

        //#region TipoCurso
        //public Return TipoCurso_ListarTodos(int Sistema)
        //{
        //    try
        //    {
        //        var retorno = _context.TipoCurso.ToList();
        //        if (retorno.Any())
        //            return Return.Success(retorno);
        //        else
        //            return Return.NotFound;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Return.CatchedError(ex, "TipoCursoRepository - TipoCurso_ListarTodos", "Sem parâmetros.", _sistema.BuscarNomePorID(Sistema));
        //    }
        //}
        //public Return TipoCurso_BuscaDinamicaFlexivel(dynamic Obj, int Sistema)
        //{

        //    try
        //    {
        //        string Where = GerarBuscaDinamica.BuscaDinamicaFlexivel(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
        //        var retorno = _context.TipoCurso.Where(Where).ToList();
        //        if (retorno.Any())
        //            return Return.Success(retorno);
        //        else
        //            return Return.NotFound;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Return.CatchedError(ex, "TipoCursoRepository - TipoCurso_BuscaDinamicaFlexivel", Obj, _sistema.BuscarNomePorID(Sistema));
        //    }
        //}
        //public Return TipoCurso_BuscaDinamicaRigida(dynamic Obj, int Sistema)
        //{
        //    try
        //    {
        //        string Where = GerarBuscaDinamica.BuscaDinamicaRigida(JsonConvert.DeserializeObject<List<BuscaDinamica>>(Obj.ToString()));
        //        var retorno = _context.TipoCurso.Where(Where).ToList();
        //        if (retorno.Any())
        //            return Return.Success(retorno);
        //        else
        //            return Return.NotFound;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Return.CatchedError(ex, "TipoCursoRepository - TipoCurso_BuscaDinamicaRigida", Obj, _sistema.BuscarNomePorID(Sistema));
        //    }
        //}
        //#endregion
    }
}