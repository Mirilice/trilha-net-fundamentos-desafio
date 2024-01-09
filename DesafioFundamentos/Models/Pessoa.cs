
using System.Reflection.Metadata;

namespace DesafioFundamentos.Models
{
    public class Pessoa
    {
        private int idade;
        private bool estudante;
        private string nome;
        public Pessoa(int idade, bool estudante, string nome){
            this.idade = idade;
            this.estudante = estudante;
            this.nome=nome;
        }
        public decimal Preco(int idade, bool estudante){
            if(idade <= 5 || idade>=65) return 0M;
            else if (idade>5 && idade<=10) return 2M;
         else if((idade >= 60 && idade < 65) || estudante) return 5M;
           else return 10M;
        }
        }
    }
