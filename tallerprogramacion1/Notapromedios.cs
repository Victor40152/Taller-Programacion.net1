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
    public partial class Notapromedios : Form
    {

        Promedionotas promedionotas = new Promedionotas();

        public Notapromedios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            promedionotas.setNota1(double.Parse(txtnota1.Text));
            promedionotas.setNota2(double.Parse(txtnota2.Text));
            promedionotas.setNota3(double.Parse(txtnota3.Text));
            promedionotas.setNota4(double.Parse(txtnota4.Text));
            
            lblprom.Text = promedionotas.resultado().ToString();
            lblprom.Visible = true;
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtnota4.Text = "";
            
            txtnota1.Focus();
            if (promedionotas.resultado() < 2.99)
            {
                MessageBox.Show("Deficiente");
            }
            else
            {
                if (promedionotas.resultado() <= 3.99)
                {
                    MessageBox.Show("Bien");
                }
                else
                {
                    if (promedionotas.resultado()>=4 && (promedionotas.resultado() <= 5))
                    {
                        MessageBox.Show("Excelente");
                    }
                }
            }
        }
    }
}
