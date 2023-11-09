namespace Bank{
    public class PaymentTicket : Payment{
        public PaymentTicket(decimal valor)
        {
            ID = Guid.NewGuid();
            data_pagamento = DateTime.Now;
            this.valor = valor; 
        }
    }
}