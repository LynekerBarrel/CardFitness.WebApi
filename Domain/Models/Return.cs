using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Domain.Models
{
    public class Return
    {
        public int Code { get; set; }

        public dynamic Result { get; set; }

        public static Return NotFound
        {
            get
            {
                return new Return { Code = 404, Result = "Registro não encontrado." };
            }
        }

        public static Return AlreadyRegistered
        {
            get
            {
                return new Return { Code = 409, Result = "Registro já cadastrado" };
            }
        }

        public static Return Unauthorized
        {
            get
            {
                return new Return { Code = 401, Result = "Autenticação falhou. Tente novamente." };
            }
        }

        public static Return Forbidden
        {
            get
            {
                return new Return { Code = 403, Result = "Usuário não tem acesso a esse conteúdo." };
            }
        }

        public static dynamic CatchedError(dynamic Result)
        {
            return new Return { Code = 100, Result = Result };
        }

        public static dynamic CustomError(dynamic Result)
        {

            return new Return { Code = 110, Result = Result };

        }

        public static dynamic Success(dynamic Result)
        {
            return new Return { Code = 200, Result = Result };
        }

        public static Return ErrorToken
        {
            get
            {
                return new Return { Code = 001, Result = "Token não autorizado." };
            }
        }
    }
}


