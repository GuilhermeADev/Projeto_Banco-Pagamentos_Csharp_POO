namespace Bank{
    public interface IPayment{
        public Guid ID { get; set; }
        public decimal valor { get; set; }
        public DateTime data_pagamento { get; set; }

        public void pagar();
    }
}