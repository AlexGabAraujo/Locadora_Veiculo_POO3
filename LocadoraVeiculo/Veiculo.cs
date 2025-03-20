using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo
{
    class Veiculo : IVeiculo
    {
        private string _modelo;
        private string _marca;
        private int _ano;
        private double _aluguelDiario;
        private int _dias;

        public Veiculo(string modelo, string marca, int ano, double aluguelDiario, int dias)
        {
            _modelo = modelo;
            _marca = marca;
            _ano = ano;
            _aluguelDiario = aluguelDiario;
            _dias = dias;
        }

        public virtual double CalcularAluguel(double aluguelDiario ,int dias)
        {
            throw new NotImplementedException();
        }

        public void printar(Veiculo veiculo) {
        {
            
        }
    }
}
