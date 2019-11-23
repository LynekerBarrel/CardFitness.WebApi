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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExercicioController : ControllerBase
    {
        private IExercicioRepository _Exercicio;
        private readonly AppSettings _appSettings;
        public ExercicioController(IExercicioRepository Exercicio, IOptions<AppSettings> appSettings)
        {
            _Exercicio = Exercicio;
            _appSettings = appSettings.Value;
        }

        [HttpGet("ListarTodos")]
        public Return Exercicio_ListarTodos()
        {
            return _Exercicio.Exercicio_ListarTodos();
        }

        [HttpPost("BuscaDinamicaFlexivel")]
        public Return Exercicio_BuscaDinamicaFlexivel(dynamic Obj)
        {
            return _Exercicio.Exercicio_BuscaDinamicaFlexivel(Obj); ;
        }

        [HttpPost("BuscaDinamicaRigida")]
        public Return Exercicio_BuscaDinamicaRigida(dynamic Obj)
        {
            return _Exercicio.Exercicio_BuscaDinamicaRigida(Obj); ;
        }

        [HttpPost("Criar")]
        public Return Exercicio_Criar(dynamic Obj)
        {
            return _Exercicio.Exercicio_Criar(Obj);
        }

        [HttpPut("Alterar")]
        public Return Exercicio_Alterar(dynamic Obj)
        {
            return _Exercicio.Exercicio_Alterar(Obj);
        }

    }
}