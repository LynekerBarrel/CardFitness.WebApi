using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Api.CrossCutting
{
    public class ValidarCPF : CPF
    {
        public static bool resultado { get; private set; }
        public static bool Validar(string cpf)
        {
            resultado = false;
            // Se for vazio
            if (String.IsNullOrEmpty(cpf.Trim()))
                return resultado;

            // Retirar todos os caracteres que não sejam numéricos
            string aux = string.Empty;
            for (int i = 0; i < cpf.Length; i++)
            {
                if (char.IsNumber(cpf[i]))
                    aux += cpf[i].ToString();
            }

            // O tamanho do CPF tem que ser 11
            if (aux.Length != 11)
                return resultado;

            // Verifica se não é apenas o mesmo numero
            resultado = aux.Distinct().Count() > 1;
            if (resultado == false)
                return false;

            // Guardo o dígito para comparar no final
            string pDigito = aux.Substring(9, 2);
            aux = aux.Substring(0, 9);

            //Cálculo do 1o. digito do CPF
            aux += GerarDigito.GerarDigitoParaValidacao(aux);

            //Cálculo do 2o. digito do CPF
            aux += GerarDigito.GerarDigitoParaValidacao(aux);

            resultado = pDigito == aux.Substring(9, 2);

            return resultado;
        }

        public override string ToString()
        {
            if (resultado)
                return "CPF Válido.";
            else
                return "CPF Inválido.";
        }
    }
}
