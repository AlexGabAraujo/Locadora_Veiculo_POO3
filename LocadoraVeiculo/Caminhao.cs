using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo
{
    class Caminhao : Veiculo
    {
        public Caminhao(string placa, string modelo, string marca, int ano, decimal aluguelDiario) : base(placa, modelo, marca, ano, aluguelDiario)
        {
        }

        public override decimal CalcularAluguel(decimal aluguelDiario, int dias)
        {
            return (aluguelDiario * dias) * 1.20m;
        }
    }
}
