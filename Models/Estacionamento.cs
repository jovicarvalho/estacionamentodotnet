using System;

namespace Models
{
    public class Estacionamento
    {
        private decimal precoInicial { get; set; }

        private decimal precoPorHora { get; set; }

        private List<string> veiculos { get; set; }

        public void AdicionarVeiculo(string placa)
        {
            veiculos.Add(placa);
        }

        public void RemoverVeiculo(string placa)
        {
            veiculos.Remove(placa);
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }


    }
}