using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Api.CrossCutting
{
    class ValidarCNPJ
    {
        public static bool resultado { get; set; }
        public static bool Validar(string cnpj)
        {
            resultado = false;
            // Se for vazio
            if (String.IsNullOrEmpty(cnpj.Trim()))
                return resultado;

            // Retirar todos os caracteres que não sejam numéricos
            string aux = string.Empty;

            for (int i = 0; i < cnpj.Length; i++)
            {
                if (char.IsNumber(cnpj[i]))
                    aux += cnpj[i].ToString();
            }

            // O tamanho do CNPJ tem que ser 14
            if (aux.Length != 14)
                return resultado;

            // Verifica se não é apenas o mesmo numero
            if (cnpj.Distinct().Count() != 1)
                return resultado;

            // Guardo os dígitos para compará-lo no final
            string pDigito = aux.Substring(12, 2);
            aux = aux.Substring(0, 12);

            //Calculo do 1º digito
            aux += GerarDigito.GerarDigitoParaValidacao(aux);

            //Calculo do 2º digito
            aux += GerarDigito.GerarDigitoParaValidacao(aux);

            //Comparo os dígitos calculadoscom os guardados anteriormente

            resultado = pDigito == aux.Substring(12, 2);

            return resultado;
        }

        public override string ToString()
        {
            if (resultado)
                return "CNPJ Válido.";
            else
                return "CNPJ Inválido.";
        }
    }
}
