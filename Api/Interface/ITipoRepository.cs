using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Interface
{
    public interface ITipoRepository
    {
        Return Tipo_ListarTodos();
        Return Tipo_BuscaDinamicaFlexivel(dynamic Obj);
        Return Tipo_BuscaDinamicaRigida(dynamic Obj);
        Return Tipo_Criar(dynamic Obj);
        Return Tipo_Alterar(dynamic Obj);
    }
}
