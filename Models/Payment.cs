
namespace Bank
{
    public abstract class Payment : IPayment
    {
        public Guid ID { get; set; }
        public decimal valor { get; set; }
        public DateTime data_pagamento { get; set;}

        public virtual void pagar()
        {
            Console.WriteLine("O valor pago foi de: {0}, a data do pagamento foi feita em {1}\n \n ID DO PAGAMENTO: {2} \n", valor, data_pagamento, ID);
        }
    }


}