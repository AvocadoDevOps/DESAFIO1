using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESAFIO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            double IMC, ALTURA2, PESO2, FINAL2;
            PESO2 = double.Parse(PESO.Text);
            ALTURA2 = double.Parse(ALTURA.Text);
            IMC = PESO2 / (ALTURA2 * ALTURA2);
            FINAL2 = IMC * 10000;
            MessageBox.Show("Seu Imc é : " + FINAL2, "Resultado", MessageBoxButtons.OK);
        }
    }
}
