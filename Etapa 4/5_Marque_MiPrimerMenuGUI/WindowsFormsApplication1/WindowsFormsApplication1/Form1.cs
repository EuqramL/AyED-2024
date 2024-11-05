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

        private void suma_Click(object sender, EventArgs e)
        {
            Form2 pantalla2 = new Form2();
            pantalla2.Show();
            this.Hide();
        }

        private void salir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            Form3 pantalla3 = new Form3();
            pantalla3.Show();
            this.Hide();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            Form4 pantalla4 = new Form4();
            pantalla4.Show();
            this.Hide();
        }
    }
}
