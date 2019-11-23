using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Interface
{
    public interface IFichaRepository
    {
        Return Ficha_ListarTodos();
        Return Ficha_BuscaDinamicaFlexivel(dynamic Obj);
        Return Ficha_BuscaDinamicaRigida(dynamic Obj);
        Return Ficha_Criar(dynamic Obj);
        Return Ficha_Alterar(dynamic Obj);

        Return FichaExercicio_BuscaDinamicaFlexivel(dynamic Obj);
        Return FichaExercicio_BuscaDinamicaRigida(dynamic Obj);
        Return FichaExercicio_Criar(dynamic Obj);
        Return FichaExercicio_Alterar(dynamic Obj);

        Return FilaFicha_BuscaDinamicaFlexivel(dynamic Obj);
        Return FilaFicha_BuscaDinamicaRigida(dynamic Obj);
        Return FilaFicha_Alterar(dynamic Obj);
    }
}
