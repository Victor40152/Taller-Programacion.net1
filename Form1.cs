using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tallerprogramacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmasa_Click(object sender, EventArgs e)
        {
            Indicemasa indicemasa = new Indicemasa();
            indicemasa.Show();
            this.Hide();
        
        }

        private void btnprom_Click(object sender, EventArgs e)
        {
            Notapromedios notapromedios = new Notapromedios();
            notapromedios.Show();
            this.Hide();

           
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            Cuadradaraiz cuadradaraiz = new Cuadradaraiz();
            cuadradaraiz.Show();
            this.Hide();

        }

        private void btnvolumen_Click(object sender, EventArgs e)
        {
            Cajavolumen cajavolumen = new Cajavolumen();
            cajavolumen.Show();
            this.Hide();
        }

        private void btnetapa_Click(object sender, EventArgs e)
        {
            Edadetapa edadetapa = new Edadetapa();
            edadetapa.Show();
            this.Hide();
        }

        private void btnsegundos_Click(object sender, EventArgs e)
        {
            Nacimiento nacimiento = new Nacimiento();
            nacimiento.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Finalcompra finalcompra = new Finalcompra();
            finalcompra.Show();
            this.Hide();

        }

        private void btnllamadas_Click(object sender, EventArgs e)
        {
            Costollamada costollamada = new Costollamada();
            costollamada.Show();
            this.Hide();
        }
    }
}
