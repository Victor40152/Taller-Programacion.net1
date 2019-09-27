using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerprogramacion1
{
    public class Volumencaja
    {
        private double numerolargo;
        private double numeroalto;
        private double numeroancho;

        public void setNumerolargo (double largo)
        {
            this.numerolargo = largo;
        }
        public void setNumeroalto(double alto)
        {
            this.numeroalto = alto;
        }
        public void setNumeroancho(double ancho)
        {
            this.numeroancho = ancho;
        }

        public double getNumerolargo()
        {
            return this.numerolargo;
        }
        public double getNumeroalto()
        {
            return this.numeroalto;
        }
        public double getNumeroancho()
        {
            return this.numeroancho;
        }
        public double resultado()
        {
            return (this.getNumerolargo() * this.getNumeroalto() * this.getNumeroancho());
        }
    }

}
