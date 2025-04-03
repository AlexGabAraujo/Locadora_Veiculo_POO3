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
        protected string _placa;
        protected string _modelo;
        protected string _marca;
        protected int _ano;
        protected decimal _aluguelDiario;
        protected int _dias;
        protected bool _alugado;

        public Veiculo(string placa, string modelo, string marca, int ano, decimal aluguelDiario)
        {
            _placa = placa;
            _modelo = modelo;
            _marca = marca;
            _ano = ano;
            _aluguelDiario = aluguelDiario;
        }

        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }
        public bool Alugado
        {
            get { return _alugado; }
            set { _alugado = value; }
        }
        public int Dias
        {
            get { return _dias; }
            set { _dias = value; }
        }

        public virtual decimal CalcularAluguel(decimal aluguelDiario, int dias)
        {
            throw new NotImplementedException();
        }

        public void printar()
        {
            string tipo;
            if (this is Moto)
                tipo = "Moto";
            else if (this is Carro)
                tipo = "Carro";
            else
                tipo = "Caminhão";
            
            Console.WriteLine($"\nTipo: {tipo} | Placa: {_placa} | Marca: {_marca} | Modelo: {_modelo} | Ano: {_ano} | Valor Diário Aluguel: {_aluguelDiario} | Dias Alugado: {_dias} | Valor Total do Aluguel: {CalcularAluguel(_aluguelDiario, _dias)} | Alugado: {_alugado}");
        }
    }
}
