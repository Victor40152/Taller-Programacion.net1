using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerprogramacion1
{
    public class Anacimiento
    {
        private int numeronac;

        public void setNumeronac (int numero)
        {
            this.numeronac = numero;
        }

        public int getNumeronac()
        {
            return this.numeronac;
        }

        public int calcular()
        {
            return ((2019) - (this.getNumeronac() ));
        }

        public int segundos()
        {
            return (this.calcular()) * (3600) * (24) * (365) - 2019;
        }
    }
}
