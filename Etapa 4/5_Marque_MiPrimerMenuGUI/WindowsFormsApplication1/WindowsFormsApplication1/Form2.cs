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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void num2Res_Click(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            num1Res.Text = numero1.Text;
            num2Res.Text = numero2.Text;
            respuesta.Text = (int.Parse(numero1.Text) + int.Parse(numero2.Text)).ToString();
        }

        private void salir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Form1 pantalla1 = new Form1();
            pantalla1.Show();
            this.Hide();
        }
    }
}
