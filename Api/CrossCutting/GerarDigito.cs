using System;
using System.Collections.Generic;
using System.Text;

namespace Api.CrossCutting
{
    public static class GerarDigito
    {
        /// <summary>
        /// Recebe um número de CPF ou CNPJ e gera o digito de validação.
        /// </summary>
        /// <param name="numeroDocumento"></param>
        /// <returns></returns>
        public static string GerarDigitoParaValidacao(string numeroDocumento)
        {
            int Peso = 2;
            int Soma = 0;

            for (int i = numeroDocumento.Length - 1; i >= 0; i--)
            {
                Soma += Peso * Convert.ToInt32(numeroDocumento[i].ToString());
                Peso++;
            }

            int pNumero = 11 - (Soma % 11);

            if (pNumero > 9)
                pNumero = 0;

            return pNumero.ToString();
        }
    }
}
