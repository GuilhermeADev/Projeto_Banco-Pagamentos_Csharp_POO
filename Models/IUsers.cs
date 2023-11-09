using Microsoft.VisualBasic;

namespace Bank{
    public interface IUsers{
        
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
    }
}