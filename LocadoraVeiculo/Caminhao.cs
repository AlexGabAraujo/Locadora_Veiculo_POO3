using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo
{
    class Caminhao : Veiculo
    {
        public Caminhao(string modelo, string marca, int ano, double aluguelDiario, int dias) : base(modelo, marca, ano, aluguelDiario, dias)
        {
        }

        public override double CalcularAluguel(double aluguelDiario, int dias)
        {
            return (aluguelDiario * dias) * 1.20;
        }

        public void printar(Caminhao caminhao)
        {
                Console.WriteLine($"Marca: {caminhao.marca} | Modelo: {_modelo} | Ano: {_ano}, Valor Diário Aluguel: {_aluguelDiario} | Dias Alugado: {_dias} | Valor Total do Alguel: {CalcularAluguel()}");
        }
}
