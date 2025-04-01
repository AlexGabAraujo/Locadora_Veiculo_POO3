using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo
{
    class Moto : Veiculo
    {
        public Moto(string placa, string modelo, string marca, int ano, double aluguelDiario) : base(placa, modelo, marca, ano, aluguelDiario)
        {
        }

        public override double CalcularAluguel(double aluguelDiario,int dias)
        {
            return (aluguelDiario * dias) * 0.90;
        }
    }
}
