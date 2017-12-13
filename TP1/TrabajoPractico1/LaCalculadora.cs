using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1;

namespace TrabajoPractico1
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (Operar(txtNumero1.Text, txtNumero2.Text, cmbOperacion.Text)).ToString();
        }

        private void Limpiar()
        {
            txtNumero1.ResetText();
            txtNumero2.ResetText();
            cmbOperacion.ResetText();
            lblResultado.ResetText();
        }

        private double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.operar(new Numero(numero1), new Numero(numero2), operador);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text.Length > 0)
            {
                lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text.Length > 0)
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            }
        }
    }
}
