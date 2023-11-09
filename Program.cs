using System;
using System.ComponentModel.Design;

namespace Bank{
    public class Program{
        public static void Main(String[] args){
            Menu();
        }

        public static void Menu(){
            Console.WriteLine("Selecione uma opção.\n 1. Pagar fatura pelo Boleto\n 2. Pagar no Credito\n 3. Pagar fatura no Debito.\n 4. Pagar fatura no Credito.\n 5. Abrir conta no banco. \n 6. Depositar dinheiro no banco.\n 9. Sair ");
            string x = Console.ReadLine();
            switch(x)
            {
                case "1":
                    Menu();
                break;

                case "2":
                    Menu();
                break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Digite o valor que deseja pagar");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    var PagamentoBoleto = new PaymentTicket(valor);
                    PagamentoBoleto.pagar();
                    Menu();
                break;

                case "4":
                    Menu();
                break;

                case "5":
                    Menu();
                break;

                case "6":
                    Menu();
                break;

                case "7":
                    Menu();
                break;

                case "8":
                    Menu();
                break;

                case "9" :
                Console.Clear();
                Console.WriteLine("Saindo...");
                break;

                default:
                    Console.Clear();
                    Console.WriteLine("Digite uma opção valida\n ");
                    Menu();
                break;
            }
        }
    }
}