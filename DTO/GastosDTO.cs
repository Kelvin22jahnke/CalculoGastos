using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoGasto.DTO
{
    public class GastosDTO
    {
        public double QuilometragemInicial { get; set; }
        public double QuilometragemFinal { get; set; }
        public double QuilometrosPorLitro { get; set; }
        public double PrecoDoCombustivel { get; set; }

        public GastosDTO(double parQuilometragemInicial, 
                         double parQuilometragemFinal,
                         double parQuilometragemPorLitro,
                         double parPrecoDoCombustivel) 
        {
            QuilometragemInicial = parQuilometragemInicial;
            QuilometragemFinal = parQuilometragemFinal;
            QuilometrosPorLitro = parQuilometragemPorLitro;
            PrecoDoCombustivel = parPrecoDoCombustivel;
        }

    }
}
