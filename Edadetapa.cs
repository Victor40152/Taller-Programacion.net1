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
    public partial class Edadetapa : Form
    {
        Edad edad = new Edad();
        public Edadetapa()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            edad.setNumeroedad(int.Parse(txtedad.Text));
            txtedad.Text = "";
            txtedad.Focus();
            if (edad.getNumeroedad() <= 10)
            {
                MessageBox.Show("Es un niño");
            }
            else
            {
                if (edad.getNumeroedad() <= 14)
                {
                    MessageBox.Show("Es un Pre-adolescente");
                }
                else
                {
                    if (edad.getNumeroedad() <= 18)
                    {
                        MessageBox.Show("Es un adolescente");
                    }
                    
                        
                    
                    else
                    {
                        if (edad.getNumeroedad() <= 25)
                        {
                            MessageBox.Show("Es un joven");
                        }
                        else
                        {
                            if (edad.getNumeroedad() <= 65)
                            {
                                MessageBox.Show("Es un adulto");
                            }
                            else
                            {
                             if (edad.getNumeroedad() > 65)
                                {
                                    MessageBox.Show("Es un anciano");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
