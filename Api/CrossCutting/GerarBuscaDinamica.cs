using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.CrossCutting
{
    public class GerarBuscaDinamica
    {
        public static string BuscaDinamicaFlexivel(List<BuscaDinamica> Lista)
        {
            var Where = "";
            var last = Lista.Last();
            var operadorExato = " = ";
            var operadorInexato = string.Empty;
            var InitString = "(\"";
            var EndString = "\")";
            int number;

            foreach (var item in Lista)
            {
                if (item.OperadorNegativo != null && item.OperadorNegativo == true)
                {
                    operadorExato = " != ";
                    operadorInexato = "!";
                }
                // Caso valor estiver nulo, deverá ser pesquisa Exata, trata também de retirar as barras da pesquisa e tranformar em uma string null
                if (item.Valor == null)
                {
                    item.Valor = "null";
                    InitString = string.Empty;
                    EndString = string.Empty;
                    item.PesquisaExata = true;
                }
                else
                {
                    // Caso valor for integer, a pesquisa deverá ser exata
                    if (Int32.TryParse(item.Valor.ToString(), out number))
                    {
                        item.PesquisaExata = true;
                    }
                    else
                    {
                        // Caso valor estiver string null, deverá ser pesquisa Exata, trata também de retirar as barras da pesquisa
                        if (item.Valor.ToString() == "null")
                        {
                            InitString = string.Empty;
                            EndString = string.Empty;
                            item.PesquisaExata = true;
                        }
                    }
                }

                if (item.Equals(last))
                {
                    if (item.PesquisaExata)
                        Where = Where + item.Campo + operadorExato + InitString + item.Valor + EndString;
                    else
                        Where = Where + operadorInexato + item.Campo + ".Contains" + InitString + item.Valor + EndString;
                }
                else
                {
                    if (item.PesquisaExata)
                        Where = Where + item.Campo + operadorExato + InitString + item.Valor + EndString + " or ";
                    else
                        Where = Where + operadorInexato + item.Campo + ".Contains" + InitString + item.Valor + EndString + " or ";
                }
            }

            return Where;
        }

        public static string BuscaDinamicaRigida(List<BuscaDinamica> Lista)
        {

            var Where = "";
            var last = Lista.Last();
            var operadorExato = " = ";
            var operadorInexato = string.Empty;
            var InitString = "(\"";
            var EndString = "\")";
            int number;

            foreach (var item in Lista)
            {
                if (item.OperadorNegativo != null && item.OperadorNegativo == true)
                {
                    operadorExato = " != ";
                    operadorInexato = "!";
                }
                // Caso valor estiver nulo, deverá ser pesquisa Exata, trata também de retirar as barras da pesquisa e tranformar em uma string null
                if (item.Valor == null)
                {
                    item.Valor = "null";
                    InitString = string.Empty;
                    EndString = string.Empty;
                    item.PesquisaExata = true;
                }
                else
                {
                    // Caso valor for integer, a pesquisa deverá ser exata
                    if (Int32.TryParse(item.Valor.ToString(), out number))
                    {
                        item.PesquisaExata = true;
                    }
                    else
                    {
                        // Caso valor estiver string null, deverá ser pesquisa Exata, trata também de retirar as barras da pesquisa
                        if (item.Valor.ToString() == "null")
                        {
                            InitString = string.Empty;
                            EndString = string.Empty;
                            item.PesquisaExata = true;
                        }
                    }
                }

                if (item.Equals(last))
                {
                    if (item.PesquisaExata)
                        Where = Where + item.Campo + operadorExato + InitString + item.Valor + EndString;
                    else
                        Where = Where + operadorInexato + item.Campo + ".Contains" + InitString + item.Valor + EndString;
                }
                else
                {
                    if (item.PesquisaExata)
                        Where = Where + item.Campo + operadorExato + InitString + item.Valor + EndString + " and ";
                    else
                        Where = Where + operadorInexato + item.Campo + ".Contains" + InitString + item.Valor + EndString + " and ";
                }
            }

            return Where;
        }
    }
}
