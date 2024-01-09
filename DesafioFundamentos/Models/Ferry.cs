

namespace DesafioFundamentos.Models
{
    public class Ferry
    {
        
        private List<string> veiculos = new List<string>();

        private List<string> pessoas = new List<string>();

      
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }
        public void AdicionarPessoa(){
            Console.WriteLine("Digite o nome da pessoa:");
            string nome = Console.ReadLine();
            pessoas.Add(nome);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            { 
                veiculos.Remove(placa);
                Veiculo veiculo = new Veiculo(placa);
                veiculo.Enumerar();
                string opcao = Console.ReadLine();
                Console.WriteLine($"O veículo {placa} foi removido, ficando no valor de {veiculo.Preco(opcao)} reais");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está aqui. Confira se digitou a placa corretamente");
            }
        }
          public void RemoverPessoa()
        {
            bool estudante = false;
            Console.WriteLine("Digite o nome da pessoa para remover:");

            string nome = Console.ReadLine();

            // Verifica se o veículo existe
            if (pessoas.Any(x => x.ToUpper() == nome.ToUpper()))
            { 
                Console.WriteLine("Informe a idade do passageiro:");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("O passageiro é estudante?(sim/nao)");
                string resp = Console.ReadLine();
                if(resp=="Sim" || resp=="sim") estudante = true;
                Pessoa pessoa = new Pessoa(idade, estudante, nome);
                Console.WriteLine($"{nome} desembarcou, ficando no valor de {pessoa.Preco(idade, estudante)} reais");
                pessoas.Remove(nome);
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada.");
            }
        }
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach(string veiculo in veiculos){
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
        public void ListarPessoas()
        {
            if (pessoas.Any())
            {
                Console.WriteLine("As pessoas a bordo são:");

                foreach(string pessoa in pessoas){
                    Console.WriteLine(pessoa);
                }
            }
            else
            {
                Console.WriteLine("Não há pessoas embarcadas.");
            }
        }
    }
}
