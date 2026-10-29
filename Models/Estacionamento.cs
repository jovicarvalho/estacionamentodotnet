using System;

namespace Models
{
    /// <summary>
    /// Cria a representação de um estacionamento, com métodos para adicionar, remover e listar veículos.
    /// </summary>
    public class Estacionamento
    {
        public required decimal PrecoInicial { get; set; }

        public required decimal PrecoPorHora { get; set; }

        private List<string> Veiculos { get; set; } = new List<string>();

        public void AdicionarVeiculo(string placa)
        {
            Veiculos.Add(placa);
        }

        public void RemoverVeiculo(string placa)
        {
            if (Veiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos estacionados.");
                return;
            }
            Console.WriteLine("Digite a placa do seu veiculo para verificação:");
            string placaDigitada = Console.ReadLine();
            if (Veiculos.Any(placa => placa.ToUpper() == placaDigitada.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                decimal precoFinal = PrecoInicial + (PrecoPorHora * Convert.ToDecimal(Console.ReadLine()));
                Console.WriteLine($"O valor total a ser pago é: {precoFinal}");
                Veiculos.Remove(placaDigitada);
                Console.WriteLine($"O veículo {placaDigitada} foi removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

        }

        public void ListarVeiculos()
        {
            if (Veiculos.Count > 0)
            {
                foreach (var veiculo in Veiculos)
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