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

        private void button1_Click(object sender, EventArgs e)
        {
            if (((int.Parse(Edad.Text) >= 19) && (salario.Text == "100001 a 200000" || salario.Text == "Más de 200000")))
            {
                MessageBox.Show("podes cobrar la beca");
            }
            else
            {
                MessageBox.Show("no podes cobrar la beca");
            }
        }
    }
}
