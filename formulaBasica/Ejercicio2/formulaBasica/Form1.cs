using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c, x, x1, x2;
            a= Convert.ToDouble(txta.Text);
            b= Convert.ToDouble(txtb.Text);
            c= Convert.ToDouble(txtc.Text);
            x = (Math.Pow(b,2) - (4 * a * c));
            if (x < 0)
            {
                txtx1.Text = "No tiene solucion real";
                txtx2.Text = "No tiene solucion real";
            }
            else if (x > 0)
            {
                x1 = (-b + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
                x2 = (-b - (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);

                txtx1.Text = x1.ToString();
                txtx2.Text = x2.ToString();
            }
            else 
            {
                //Tiene una solucion real dada por: -b/2a
                x2 = (-b / (2 * a);
                x1 = (-b / (2 * a);
                txtx2.Text = x2.ToString();
                txtx1.Text = x1.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
