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
    public partial class Indicemasa : Form

    {

        Masacorporal masacorporal = new Masacorporal();
        public Indicemasa()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            masacorporal.setDato1(double.Parse(txtdato1.Text));
            masacorporal.setDato2(double.Parse(txtdato2.Text));
            lblmasa.Text = masacorporal.resultado().ToString();
            lblmasa.Visible = true;
            txtdato1.Text = "";
            txtdato2.Text = "";
            txtdato2.Focus();
            if (masacorporal.resultado() < 18.5)
            {
                MessageBox.Show("Peso Bajo");
            }
            else
            {
                if (masacorporal.resultado() < 24.9)
                {
                    MessageBox.Show("Peso Normal");
                }
                else
                {
                    if (masacorporal.resultado() < 29.9)
                    {
                        MessageBox.Show("Sobrepreso");
                    }
                    else
                    {
                        if (masacorporal.resultado() < 34.9)
                        {
                            MessageBox.Show("Obesidad Tipo 1");
                        }
                        else
                        {
                            if (masacorporal.resultado() < 39.9)
                            {
                                MessageBox.Show("Obesidad Tipo 2");
                            }
                            else
                            {
                                if (masacorporal.resultado() >= 40)
                                {
                                    MessageBox.Show("Obesidad Tipo 3");
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
