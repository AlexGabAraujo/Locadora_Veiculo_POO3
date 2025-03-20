using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo
{
    class Carro : Veiculo
    {
        public Carro(string modelo, string marca, int ano, double aluguelDiario) : base(modelo, marca, ano, aluguelDiario)
        {
        }

        public override double CalcularAluguel(double aluguelDiario, int dias)
        {
            return aluguelDiario * dias;
        }
    }
}
