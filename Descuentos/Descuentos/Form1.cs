using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double salario;
            salario = Convert.ToDouble(txtsalario.Text);
            string salario1 = txtsalario.Text;
            string nombre = txtnombre.Text;
            string apellido= txtapellido.Text;
            double b = 0;

            if (rbtn1.Checked == true)
            { b = 0.20;
                double salarioNeto = (salario - (salario * b));
                double descuento = (salario - salarioNeto);
                MessageBox.Show("Bienvenido " + nombre + " " + apellido + " este es un formulario para descuento de salario: \n"
                    + "Salario: " + salario1 + "\n"
                    + "Descuentos: " + descuento.ToString() + "\n"
                    + "Salario Neto: "+ salarioNeto);
            }

            else if (rbtn2.Checked == true)
            { b = 0.15;
                double salarioNeto2 = salario - (salario * b);
                double descuento2 = (salario - salarioNeto2);
                MessageBox.Show("Bienvenido " + nombre + " " + apellido + " este es un formulario para descuento de salario: \n"
                        + "Salario: " + salario1 + "\n"
                        + "Descuentos: " + descuento2.ToString() + "\n"
                        + "Salario Neto: "+ salarioNeto2);
            }
            else
            {    b = 0.05;
                double salarioNeto3 = salario - (salario * b); 
                double descuento3 = (salario - salarioNeto3);
                MessageBox.Show("Bienvenido " + nombre + " " + apellido + " este es un formulario para descuento de salario: \n"
                        + "Salario: " + salario1 + "\n"
                        + "Descuentos: " + descuento3.ToString() + "\n"
                        + "Salario Neto: "+ salarioNeto3);
            } 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
