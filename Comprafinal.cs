using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerprogramacion1
{
    public class Comprafinal
    {
        private double Numerocompra;
        public void setNumerocompra(double compra)
        {
            this.Numerocompra = compra;
        }
        public double getNumerocompra()
        {
            return this.Numerocompra;
        }
        public double descuento()
        {
            return this.getNumerocompra() -(this.getNumerocompra() *0.20);
        }
        public double total()
        {
            return (this.descuento() * (1.19));
        }
    }
}
