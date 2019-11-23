using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api;
using Domain.Entities;
using Api.Interface;
using Microsoft.Extensions.Options;
using Api.Helpers;
using Domain.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Api.CrossCutting;

namespace Api.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private ICursoRepository _repository;
        private readonly AppSettings _appSettings;
        public CursoController(ICursoRepository repository, IOptions<AppSettings> appSettings)
        {
            _repository = repository;
            _appSettings = appSettings.Value;
        }

        //[Authorize(Roles = "DEV")]
        //[HttpGet("[controller]/ListarTodos")]
        //public Return Curso_ListarTodos(int Sistema)
        //{
        //    return _repository.Curso_ListarTodos(Sistema);
        //}

        //[Authorize(Roles = "DEV")]
        //[HttpPost("[controller]/BuscaDinamicaFlexivel")]
        //public Return Curso_BuscaDinamicaFlexivel(dynamic Obj)
        //{
        //    return _repository.Curso_BuscaDinamicaFlexivel(Obj.Info, Convert.ToInt32(Obj.Sistema.Id.Value));
        //}

        //[Authorize(Roles = "DEV")]
        //[HttpPost("[controller]/BuscaDinamicaRigida")]
        //public Return Curso_BuscaDinamicaRigida(dynamic Obj)
        //{
        //    return _repository.Curso_BuscaDinamicaRigida(Obj.Info, Convert.ToInt32(Obj.Sistema.Id.Value));
        //}

        //[Authorize(Roles = "DEV")]
        //[HttpGet("TipoCurso/ListarTodos")]
        //public Return TipoCurso_ListarTodos(int Sistema)
        //{
        //    return _repository.TipoCurso_ListarTodos(Sistema);
        //}

        //[Authorize(Roles = "DEV")]
        //[HttpPost("TipoCurso/BuscaDinamicaFlexivel")]
        //public Return TipoCurso_BuscaDinamicaFlexivel(dynamic Obj)
        //{
        //    return _repository.TipoCurso_BuscaDinamicaFlexivel(Obj.Info, Convert.ToInt32(Obj.Sistema.Id.Value));
        //}

        //[Authorize(Roles = "DEV")]
        //[HttpPost("TipoCurso/BuscaDinamicaRigida")]
        //public Return TipoCurso_BuscaDinamicaRigida(dynamic Obj)
        //{
        //    return _repository.TipoCurso_BuscaDinamicaRigida(Obj.Info, Convert.ToInt32(Obj.Sistema.Id.Value));
        //}


    }
}