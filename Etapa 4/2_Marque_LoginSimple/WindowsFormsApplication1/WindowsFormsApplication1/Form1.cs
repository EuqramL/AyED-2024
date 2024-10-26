using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e) { 


            

                if (usurio.Text == "Admin" && contraseña.Text == "Admin12345")
            {
                MessageBox.Show("Autorizado a ingresar");
            }
                else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void usurio_TextChanged(object sender, EventArgs e)
        {


        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {
            contraseña.PasswordChar = '*';
        }
    }
}
