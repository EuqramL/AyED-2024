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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void num2Res_Click(object sender, EventArgs e)
        {

        }

        private void num1Res_Click(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            num1Res.Text = numero1.Text;
            num2Res.Text = numero2.Text;
            respuesta.Text = (int.Parse(numero1.Text) * int.Parse(numero2.Text)).ToString();
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void respuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
