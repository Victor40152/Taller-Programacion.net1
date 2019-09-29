using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerprogramacion1
{
    public class Promedionotas
    {
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        

        public void setNota1(double prom)
        {
            this.nota1 = prom;

        }
        public double getNota1()
        {
            return this.nota1;
        }
        public void setNota2(double prom)
        {
            this.nota2 = prom;

        }
        public double getNota2()
        {
            return this.nota2;
        }
        public void setNota3(double prom)
        {
            this.nota3 = prom;

        }
        public double getNota3()
        {
            return this.nota3;
        }
        public void setNota4(double prom)
        {
            this.nota4 = prom;

        }
        public double getNota4()
        {
            return this.nota4;
        }
        
        public double resultado()
        {
            return ((this.getNota1()+ this.getNota2()+ this.getNota3()+ this.getNota4())/4);
        }
    }
    
}
