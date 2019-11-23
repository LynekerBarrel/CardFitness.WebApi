using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Helpers
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

            return new Return { Code = 000, Result = Result };

        }

        public static dynamic Success(dynamic Result)
        {
            
            return new Return { Code = 200, Result = Result };
            
        }


    }
}


