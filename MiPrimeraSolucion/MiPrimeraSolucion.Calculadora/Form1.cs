using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraSolucion.Calculadora
{
    public partial class Form1 : Form
    {
        int numeroUno = 0;
        int numeroDos = 0;
        int resultado = 0;
        string operacion = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            if (txtVentanaDeResultados.Text == "0")
            {
                txtVentanaDeResultados.Text = "0";
            }
            else
            {
                txtVentanaDeResultados.Text = txtVentanaDeResultados.Text + "0";
            }
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            if (txtVentanaDeResultados.Text == "0")
            {
                txtVentanaDeResultados.Text = "1";
            }
            else
            {
                txtVentanaDeResultados.Text = txtVentanaDeResultados.Text + "1";
            }
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            if (txtVentanaDeResultados.Text == "0")
            {
                txtVentanaDeResultados.Text = "2";
            }
            else
            {
                txtVentanaDeResultados.Text = txtVentanaDeResultados.Text + "2";
            }
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            if (txtVentanaDeResultados.Text == "0")
            {
                txtVentanaDeResultados.Text = "3";
            }
            else
            {
                txtVentanaDeResultados.Text = txtVentanaDeResultados.Text + "3";
            }
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            if (txtVentanaDeResultados.Text == "0")
            {
                txtVentanaDeResultados.Text = "4";
            }
            else
            {
                txtVentanaDeResultados.Text = txtVentanaDeResultados.Text + "4";
            }
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            if (txtVentanaDeResultados.Text == "0")
            {
                txtVentanaDeResultados.Text = "5";
            }
            else
            {
                txtVentanaDeResultados.Text = txtVentanaDeResultados.Text + "5";
            }
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            if (txtVentanaDeResultados.Text == "0")
            {
                txtVentanaDeResultados.Text = "6";
            }
            else
            {
                txtVentanaDeResultados.Text = txtVentanaDeResultados.Text + "6";
            }
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            if (txtVentanaDeResultados.Text == "0")
            {
                txtVentanaDeResultados.Text = "7";
            }
            else
            {
                txtVentanaDeResultados.Text = txtVentanaDeResultados.Text + "7";
            }
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            if (txtVentanaDeResultados.Text == "0")
            {
                txtVentanaDeResultados.Text = "8";
            }
            else
            {
                txtVentanaDeResultados.Text = txtVentanaDeResultados.Text + "8";
            }
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            if (txtVentanaDeResultados.Text == "0")
            {
                txtVentanaDeResultados.Text = "9";
            }
            else
            {
                txtVentanaDeResultados.Text = txtVentanaDeResultados.Text + "9";
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numeroUno = int.Parse(txtVentanaDeResultados.Text);
            txtVentanaDeResultados.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numeroUno = int.Parse(txtVentanaDeResultados.Text);
            txtVentanaDeResultados.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numeroUno = int.Parse(txtVentanaDeResultados.Text);
            txtVentanaDeResultados.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numeroUno = int.Parse(txtVentanaDeResultados.Text);
            txtVentanaDeResultados.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    {
                        Sumar();
                        break;
                    }
                case "-":
                    {
                        Restar();
                        break;
                    }
                case "*":
                    {
                        Multiplicar();
                        break;
                    }
                case "/":
                    {
                        Dividir();
                        break;
                    }
            }
        }

        private void Sumar()
        {
            numeroDos = int.Parse(txtVentanaDeResultados.Text);
            resultado = numeroUno + numeroDos;
            txtVentanaDeResultados.Text = resultado.ToString();
        }

        private void Restar()
        {
            numeroDos = int.Parse(txtVentanaDeResultados.Text);
            resultado = numeroUno - numeroDos;
            txtVentanaDeResultados.Text = resultado.ToString();
        }

        private void Multiplicar()
        {
            numeroDos = int.Parse(txtVentanaDeResultados.Text);
            resultado = numeroUno * numeroDos;
            txtVentanaDeResultados.Text = resultado.ToString();
        }

        private void Dividir()
        {
            numeroDos = int.Parse(txtVentanaDeResultados.Text);

            if (numeroDos == 0)
            {
                MessageBox.Show("No se puede dividir por cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVentanaDeResultados.Text = "0";
                numeroUno = 0;
                numeroDos = 0;
                resultado = 0;
                operacion = string.Empty;
                return;
            }

            resultado = numeroUno / numeroDos;
            txtVentanaDeResultados.Text = resultado.ToString();
        }
    }
}