using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public ulong Factorial(uint n)

        {
            ulong factorial = 1;
            for (uint i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

    }
}
