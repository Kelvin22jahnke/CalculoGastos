using CalculoGasto.DTO;
using CalculoGasto.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoGasto.Controller
{
    public class GastosController : IGastosController
    {
        public string ObterGastosCalculados(GastosDTO parGastosDTO)
        {
            CalcularGastosDTO calcularGastosDTO;
            ICalcularGastosService calcularGastosService = new CalculaGastosService(parGastosDTO);

            calcularGastosDTO = calcularGastosService.CalcularGastos();

            return MontaRetornoInformacoesGastos(calcularGastosDTO);
        }

        private String MontaRetornoInformacoesGastos(CalcularGastosDTO parCalcularGastosDTO) 
        {
            string retornoInformacoesGastos;

            retornoInformacoesGastos = $"Você teve os seguintes Gastos: {Environment.NewLine}";
            retornoInformacoesGastos += $" - Quilometragem percorrida em KM: {parCalcularGastosDTO.QuilometrosPercorridos}{Environment.NewLine}";
            retornoInformacoesGastos += $" - Valor Gasto na Viagem em R$: {parCalcularGastosDTO.ValorGasto.ToString("0.00")}{Environment.NewLine}";

            return retornoInformacoesGastos;
        }
    }
}
