using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"O veiculo de placa {placa} foi adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida. Por favor, insira uma placa válida.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0; 
                if (int.TryParse(Console.ReadLine(), out horas) && horas > -1)
                {
                   valorTotal = precoInicial + (precoPorHora * horas);
                }
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);
               // Console.WriteLine($"O veículo de placa:{placa} foi removido, o valor devido é de: R$ {valorTotal}");
               Console.WriteLine($"O veículo com placa {placa} foi removido e o preço total a pagar é: R$ {valorTotal:F2}");
            }
             else
             {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                int contadorForeach = 1;
                foreach (string veiculo in veiculos)
                {
                Console.WriteLine($"Na Vaga: {contadorForeach} é o de Placa: {veiculo}");
                contadorForeach++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
