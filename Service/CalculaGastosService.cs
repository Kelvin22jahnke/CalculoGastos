using CalculoGasto.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoGasto.Service
{
    public class CalculaGastosService : ICalcularGastosService
    {

        GastosDTO glbGastosDTO;
        public CalculaGastosService(GastosDTO parGastosDTO) 
        {
            glbGastosDTO = parGastosDTO;
        }

        public CalcularGastosDTO CalcularGastos()
        {
            CalcularGastosDTO calcularGastosDTO = new CalcularGastosDTO();

            calcularGastosDTO.QuilometrosPercorridos = CalcularQuilometragemPercorrida();
            calcularGastosDTO.ValorGasto = CalcularValorGasto();

            return calcularGastosDTO;
        }

        private double CalcularQuilometragemPercorrida()
        {
            return (glbGastosDTO.QuilometragemFinal - glbGastosDTO.QuilometragemInicial);
        }

        private double CalcularValorGasto()
        {
  
            return (CalcularQuilometragemPercorrida() / glbGastosDTO.QuilometrosPorLitro) * glbGastosDTO.PrecoDoCombustivel;
        }
    }
}
