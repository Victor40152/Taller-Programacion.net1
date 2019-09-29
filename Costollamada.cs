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
    public partial class Costollamada : Form
    {
        Llamadas llamada = new Llamadas();

        public Costollamada()
        {
            InitializeComponent();
        }



        //private void Costollamada_Load(object sender, EventArgs e)
        //{
        //    cmbDestino.Items.Add("Estados Unidos");
        //    cmbDestino.Items.Add("Canadá");
        //    cmbDestino.Items.Add("Europa");
        //    cmbDestino.Items.Add("Resto del mundo");
        //}

        private void btnCosto_Click(object sender, EventArgs e)
        {
            llamada.setdestino(cmbDestino.Text);
            llamada.setduracion(double.Parse(txtduracion.Text));
            lblTotal.Text = llamada.totalapagar().ToString();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

    

