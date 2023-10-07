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

        public void AdicionarVeiculo(string placa)
        {
            veiculos.Add(placa);
            Console.WriteLine($"Veículo de placa {placa} manobrado");
        }

        public void RemoverVeiculo(string placa)
        {
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horasEstacionadas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoPorHora * horasEstacionadas + precoInicial; 
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi retirado e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                int index = 1;
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    
                    Console.WriteLine($"{index}- Veículo de placa {veiculo}");
                    index++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
