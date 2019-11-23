using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcessoUsuario
{
    class Criptografia
    {
        private HashAlgorithm hash;

        /// <Doc Nome = "Criptografar" 
        /// Descricao="Criptografa uma string usando o método de Hash." 
        /// Parametros= "senha (É normalmente utilizado com o GeraSenhaAleatoria,
        /// ou seja, a senha é gerada aleatoriamente e posteriormente criptografada, 
        /// para ser gravada no banco)." 
        /// Retorno = "" 
        /// Autor="Gesilene Martins">  
        /// </Doc>
        public string Criptografar(string senha)
        {
            //O modo de criptografia é SHA1
            hash = new SHA1Managed();
            byte[] cryptoByte = hash.ComputeHash(ASCIIEncoding.ASCII.GetBytes(senha));

            return Convert.ToBase64String(cryptoByte, 0, cryptoByte.Length);
        }
    }
}
