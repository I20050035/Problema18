using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_18
{
    class Operaciones
    {
        public double Operacionn(double n)
        {

            double suma = 0;
            for (double i = 1; i <= n; i++)
            {
                double ar = 1;
                double ab = Math.Pow(n, i);
                for (double j = 1; j <= i; j++)
                {

                    ab = ab * j;


                }
                double div = ar / ab;
                suma = suma + div;

            }
            suma = suma + 1;
            return suma;
        }
    }
}
