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
    public partial class Nacimiento : Form
    {
        Anacimiento anacimiento = new Anacimiento();
        public Nacimiento()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            anacimiento.setNumeronac(int.Parse(txtedad.Text));
            lbledad.Text = anacimiento.calcular().ToString();
            lblsegundos.Text = anacimiento.segundos().ToString();
            txtedad.Text = "";
            txtedad.Focus();
        }
    }
}
