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
    public partial class Cuadradaraiz : Form


    {
        Raizcuadrada raizcuadrada = new Raizcuadrada();


        public Cuadradaraiz()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            raizcuadrada.setNumero1(double.Parse(txtraiz.Text));
            lblraiz.Text = raizcuadrada.resultado().ToString();
            lblraiz.Visible = true;
            txtraiz.Text = "";
            txtraiz.Focus();

            
        }
    }
}
