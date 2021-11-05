using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmobiliariaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double piso;
            double local;

            String direccion = textBox3.Text;

            int numVentanas = Convert.ToInt32(textBox2.Text);
            int superficie = Convert.ToInt32(textBox4.Text);

            double preBase = Convert.ToDouble(textBox6.Text);

            int anios = Convert.ToInt32(textBox5.Text);
            int numPiso = Convert.ToInt32(textBox1.Text);

            Piso myPiso = new Piso();
            Local myLocal = new Local();

            piso = myPiso.ingresarPiso(preBase, numPiso, anios);
            local = myLocal.local(preBase, anios, superficie, numVentanas);

            mostrarPrecio.Text = "El precio total es de: " + piso + " " + direccion;
            mostrarPrecio.Text = "El precio total es de: " + local + " " + direccion;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            
        }

    }
}
