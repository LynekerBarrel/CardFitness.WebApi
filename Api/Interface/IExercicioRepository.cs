using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Interface
{
    public interface IExercicioRepository
    {
        Return Exercicio_ListarTodos();
        Return Exercicio_BuscaDinamicaFlexivel(dynamic Obj);
        Return Exercicio_BuscaDinamicaRigida(dynamic Obj);
        Return Exercicio_Criar(dynamic Obj);
        Return Exercicio_Alterar(dynamic Obj);
    }
}
