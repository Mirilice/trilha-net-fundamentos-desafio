
using System.Collections;

namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        private string placa;

        private string[] tipo = { "Passeio", "PickUpFurgaoKombiVans", "Caminhonete", "Caminhao", "Carreta", "Bitrem", "Reboque", "Microonibus", "Onibus", "PaCarregadeira", "Trator", "RetroEscavadeira", "Cavalinho", "Quadriciclo", "Moto", "Guindaste", "Patrol"};

        public Veiculo(string placa){
            this.placa = placa;
        }
       
        public void Enumerar(){
        
            Console.WriteLine("\nPara prosseguir ao pagamento, informe o tipo de veículo:");

            for (int i = 0; i < tipo.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {tipo[i]}");
            }
            Console.WriteLine("\nAtenção: caso o número da opção não correponda a nenhum dos tipos de veículos registrados, será cobrada uma taxa fixa R$112,50.");
        }
        public decimal Preco(string i){
            switch(i){
                case "1":
                    return 107.5M;
                case "2":
                    return 130M;
               case "3":
                    return 150M;
                case "4":
                    return 265.2M;
                case "5":
                    return 660M;
                case "6":
                    return 865M;
                case "7":
                    return 155M;
                case "8":
                    return 220M;
                case "9":
                    return 350M;
                case "10":
                    return 690M;
                case "11":
                    return 515M;
                case "12":
                    return 285M;
                case "13":
                    return 235M;
                case "14":
                    return 75M;
                 case "15":
                    return 30M;
                 case "16":
                    return 1500M;
                 case "17":
                    return 1200M;
                default:
                    return 112.5M;

            }
        }
    }
}