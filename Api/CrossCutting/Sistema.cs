using System;
using System.Collections.Generic;
using System.Text;

namespace Api.CrossCutting
{
    public class Sistema
    {
        public static int RetornarSistema()
        {
            return Simpósio;
        }
        public static string RetornarSistema(string Ambiente)
        {
            return Ambiente;
        }
        public static int Simpósio
        {
            get
            {
                return 1;
            }
        }
        public static int RH
        {
            get
            {
                return 2;
            }
        }
        public static int Clinicas
        {
            get
            {
                return 3;
            }
        }

    }
}
