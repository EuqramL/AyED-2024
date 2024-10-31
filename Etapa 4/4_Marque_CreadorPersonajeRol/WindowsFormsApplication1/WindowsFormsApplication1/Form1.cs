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
            string nombreRec = nombre1.Text;
            string vidaRec = vida1.Text;
            string razaRec = raza1.Text;
            string habilidadesRec = habilidades1.Text;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            Form3 pantalla2 = new Form3(nombre1.Text, vida1.Text, raza1.Text, habilidades1.Text);
            pantalla2.Show();
            this.Hide();
        }
    }
}
