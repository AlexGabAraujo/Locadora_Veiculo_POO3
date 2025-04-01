using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo
{
    interface IVeiculo
    {
        double CalcularAluguel(double aluguelDiario, int dias);
    }
}
