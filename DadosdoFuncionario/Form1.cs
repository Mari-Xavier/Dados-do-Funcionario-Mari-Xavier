using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadosdoFuncionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataNasc;

            if (DateTime.TryParse(maskedTextBox1.Text, out dataNasc))
                MessageBox.Show("Data ok " + dataNasc.ToString("dd/MM/yyyy"));
            else
                MessageBox.Show("Data Inválida");

            Double salario;
            Double desconto;

            if (Double.TryParse(maskedTextBox2.Text, out salario))
                MessageBox.Show("Salário ok " + salario.ToString("N21"));
            else
                MessageBox.Show("Salário inválido");

            string stringona;
            stringona = maskedTextBox3.Text.Replace("R$", "").Trim();

                if (Double.TryParse(stringona, out desconto))
                MessageBox.Show("Desconto OK " + desconto.ToString("N2"));
                else
                MessageBox.Show("Desconto inválido");



        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Componente perdeu o foco");
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Componente ganhou o foco");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Endereço foi alterado");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
