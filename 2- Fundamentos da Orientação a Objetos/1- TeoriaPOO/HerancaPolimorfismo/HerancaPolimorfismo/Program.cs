using System.Diagnostics;

namespace POOHerancaPolimorfismo
{
    class Program
    {
        public static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "12345";

            var pagamento = new Pagamento();
            pagamento.ToString();
        }
    }

    class Pagamento
    {
        //propriedade
        public DateTime Vencimento;

        //Método
        public virtual void Pagar() // Virtual informa que ela pode ser sobrescrevida. Sempre está na estrutura pai
        {}

        public override string ToString()
        {
            return Vencimento.ToString("dd/mm/aaaa");
        }
    }

    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;

        public override void Pagar() // Override diz que será sobrescrevido pela nova forma de fazer/pagar. Sempre na estrutura filho
        {
            base.Pagar(); // base = Voce consegue acessar um item da estrutura pai
        }
    }

    class PagamentoCredito : Pagamento
    {
        public string NumeroCredito;

        public override void Pagar()
        {
            base.Pagar();
        }
    }
}