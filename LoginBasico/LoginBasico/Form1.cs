using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginBasico
{
    public partial class Form1 : Form
    {
        string contraseña;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contra = txtcontraseña.Text;
            string url = "C:\\Progra\\" + usuario + ".txt"; //usted elige ubicación de carpeta, 
            //la que hizo en el paso 3, pero esta debe existir

            if (File.Exists(url)) //verifica que el archive exista 
            {
                MessageBox.Show("ERROR. ¡Usuario ya existe!"); //usuario registrado 
                txtusuario.Clear(); //limpiamos todos los textbox 
                txtcontraseña.Clear();
            }

            else
            {
                File.WriteAllText(url, contra); /*Crea un Nuevo archivo con ese nombre y guarda 
	            dentro del archivo el valor del segundo parámetro*/
                MessageBox.Show("Usuario Registrado con éxito");
                txtusuario.Clear();
                txtcontraseña.Clear();
            }
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text; //capturamos los valores de usuario y contraseña 
            string contra = txtcontraseña.Text;
            string url = "C:\\Progra\\" + usuario + ".txt";

            if (File.Exists(url)) //verifica si existe 
            {
                contraseña = File.ReadAllText(url); //lee el texto almacenado dentro del archivo 
                if (contra.Equals(contraseña)) //verifica si contraseña es igual al archivo 
                {
                    MessageBox.Show("¡Ingreso exitoso, bienvenido!"); //login exitoso 
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!  ");//login fallido 
                }
            }
            else
            {
                MessageBox.Show("¡Usuario incorrecto! "); //usuario incorrecto 
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
