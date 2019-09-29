using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerprogramacion1
{
    public class Masacorporal
    {
        private double dato1;
        private double dato2;

        public void setDato1(double valor)
        {
            this.dato1 = valor;

        }
        public double getDato1()
        {

            return this.dato1;
        }
        public void setDato2(double valor)
        {
            this.dato2 = valor;

        }
        public double getDato2()
        {

            return this.dato2;
        }
        public double resultado()
        {
            return (this.getDato1() / (this.getDato2() * this.getDato2()));
        }
    }
}
