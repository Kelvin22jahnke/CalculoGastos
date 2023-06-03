using CalculoGasto.Controller;
using CalculoGasto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoGasto
{
    public partial class frmCalculoGastos : Form
    {
        public frmCalculoGastos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                string mensagemErro = string.Empty;

                if (!ValidaCamposTela(ref mensagemErro))
                {
                    MessageBox.Show(mensagemErro);
                    return;
                }

                IGastosController gastosController = new GastosController();
                GastosDTO gastosDTO = new GastosDTO(Convert.ToDouble(txtQuilometragemInicial.Text),
                                                    Convert.ToDouble(txtQuilometragemFinal.Text),
                                                    Convert.ToDouble(txtQuilometroPorLitro.Text),
                                                    Convert.ToDouble(txtPrecoCombustivel.Text));

                MessageBox.Show(gastosController.ObterGastosCalculados(gastosDTO));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {Environment.NewLine} {ex.Message}");
                return;
            }

        }

        private bool ValidaCamposTela(ref string parMensagemErro) 
        {
            if (string.IsNullOrWhiteSpace(txtQuilometragemInicial.Text.Trim())) 
            {
                parMensagemErro = "Informe a quilometragem inicial.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuilometragemFinal.Text.Trim()))
            {
                parMensagemErro = "Informe a quilometragem Final.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecoCombustivel.Text.Trim()))
            {
                parMensagemErro = "Informe o preo do combustível.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuilometroPorLitro.Text.Trim()))
            {
                parMensagemErro = "Informe a quilometragem por litro.";
                return false;
            }

            return true;
        }
    }
}
