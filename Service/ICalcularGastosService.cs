using CalculoGasto.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoGasto.Service
{
    public interface ICalcularGastosService
    {
        CalcularGastosDTO CalcularGastos();
    }

}
