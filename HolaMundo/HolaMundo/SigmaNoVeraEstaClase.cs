using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class SigmaNoVeraEstaClase
    {
        public static int Factorial(int n)
        {
            if (n < 0)
                return 0;
            else if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
