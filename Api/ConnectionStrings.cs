using System;
using System.Collections.Generic;
using System.Text;

namespace Api
{
    public static class ConnectionStrings
    {
        public static string Local
        {
            get
            {
                return @"Server=localhost\SQLEXPRESS;Database=dbCardFitness;Trusted_Connection=True;";
            }
        }
    }
}
