using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Api.CrossCutting
{
    public class CPF
    {
        private string _cpf;

        public CPF()
        {

        }
        public CPF(string cpf)
        {
            _cpf = cpf;
        }

        public override string ToString()
        {
            return _cpf;
        }

        /// <summary>
        /// Retorna o CPF com Máscara aplicada.
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static string CPFComMascara(string cpf)
        {
            string aux = "";

            // Retirar todos os caracteres que não sejam numéricos
            for (int i = 0; i < cpf.Length; i++)
            {
                if (char.IsNumber(cpf[i]))
                    aux += cpf[i].ToString();
            }

            if (aux.Length != 11)
                return cpf;

            string pmontado = "";
            pmontado = aux.Substring(0, 3) + ".";
            pmontado += aux.Substring(3, 3) + ".";
            pmontado += aux.Substring(6, 3) + "-";
            pmontado += aux.Substring(9, 2);

            return pmontado;
        }

        public static string CPFSemMascara(string cpf)
        {
            string aux = "";

            // Retirar todos os caracteres que não sejam numéricos.
            if (cpf != null && cpf.Length > 0)
            {
                for (int i = 0; i < cpf.Length; i++)
                {
                    if (char.IsNumber(cpf[i]))
                        aux += cpf[i].ToString();
                }
            }

            return aux;
        }
        public static string RemoverCaracteresEspeciais(string cpf)
        {
            string aux = "";

            // Retirar todos os caracteres que não sejam numéricos.
            if (cpf != null && cpf.Length > 0)
            {
                for (int i = 0; i < cpf.Length; i++)
                {
                    if (char.IsNumber(cpf[i]) || char.IsLetter(cpf[i]))
                        aux += cpf[i].ToString();
                }
            }

            return aux;
        }
    }
}
