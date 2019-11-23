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
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoController : ControllerBase
    {
        private ITipoRepository _tipo;
        private readonly AppSettings _appSettings;
        public TipoController(ITipoRepository tipo, IOptions<AppSettings> appSettings)
        {
            _tipo = tipo;
            _appSettings = appSettings.Value;
        }

        [HttpGet("ListarTodos")]
        public Return Tipo_ListarTodos()
        {
            return _tipo.Tipo_ListarTodos();
        }

        [HttpPost("BuscaDinamicaFlexivel")]
        public Return Tipo_BuscaDinamicaFlexivel(dynamic Obj)
        {
            return _tipo.Tipo_BuscaDinamicaFlexivel(Obj); ;
        }

        [HttpPost("BuscaDinamicaRigida")]
        public Return Tipo_BuscaDinamicaRigida(dynamic Obj)
        {
            return _tipo.Tipo_BuscaDinamicaRigida(Obj); ;
        }

        [HttpPost("Criar")]
        public Return Tipo_Criar(dynamic Obj)
        {
            return _tipo.Tipo_Criar(Obj);
        }

        [HttpPost("Alterar")]
        public Return Tipo_Alterar(dynamic Obj)
        {
            return _tipo.Tipo_Alterar(Obj);
        }

    }
}