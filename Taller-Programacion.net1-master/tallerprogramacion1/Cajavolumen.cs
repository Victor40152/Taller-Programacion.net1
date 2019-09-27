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
    public partial class Cajavolumen : Form

    {
        Volumencaja volumencaja = new Volumencaja();

        public Cajavolumen()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            volumencaja.setNumerolargo(double.Parse(txtlargo.Text));
            volumencaja.setNumeroalto(double.Parse(txtalto.Text));
            volumencaja.setNumeroancho(double.Parse(txtancho.Text));
            lblvol.Text = volumencaja.resultado().ToString();
            lblvol.Visible = true;
            txtlargo.Text = "";
            txtalto.Text = "";
            txtancho.Text = "";
            txtlargo.Focus();



        }
    }
}
