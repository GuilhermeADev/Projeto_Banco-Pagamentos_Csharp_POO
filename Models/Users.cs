using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Bank{
    public class Users : IUsers
    {
        public Guid ID { get; set; }
        public string Nome { get ;   set;  }
        public int Idade { get ; set;  }
        public string CPF { get ; set ; }

        public List<Users> ListUsers { get; set; }

        public void criarUsuario(){
            Console.WriteLine("Digite seu nome");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu CPF");
            CPF = Console.ReadLine();

            ID = Guid.NewGuid(); 
        }
    }
}