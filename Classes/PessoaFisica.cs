using CadastroPessoaFF12.Interfaces;
namespace CadastroPessoaFF12.Classes

{

    //Herdando Atributos e métodos Da classe Pai "Pessoa" 
    // herdando em segundo A interface IPessoaFisica com A Obrigadotoriedade da Assinatura do método 
    public class PessoaFisica : Pessoa, IPessoaFisica

    {
        public PessoaFisica()
        { //Conceito de método Sobrecarga // Quando tem mais de 1 método costrutor

        }
        public PessoaFisica(string parCpf)
        {// Método COnstrutor com a propiedade cpf 
            this.Cpf = parCpf; //Método Construtor : Ele tem o mesmo nome da classe , Uma classe especial
        }

        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        //Conceito de "OVERRIDE" Vem do fato de o pagamento ser de maneira difereten , Ex: IRpf de 3% para PF E 10% PJ
        // Aqui podemos aplciar o conceito de polimorfismo
        public override float PagarImposto(float rendimento)

        {
            throw new NotImplementedException();
        }
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime DataAtual = DateTime.Today;
            double Idade = (DataAtual - dataNasc).TotalDays / 365;

            if (Idade >= 18)
            {
                return true;
            }
            return false;
        }
        public bool ValidarDataNascimento(string dataNasc)
        {

            DateTime dataConvertida;


            if (DateTime.TryParse(dataNasc, out dataConvertida))//Converte a String Data de Nascimento(dataNasc)
            {                                                   //E armaazenei em dataConvertida
                //Console.WriteLine(dataConvertida);
                DateTime DataAtual = DateTime.Today; // DateTime, Pega a data de hoje e armazena na DataAtual
                double Idade = (DataAtual - dataConvertida).TotalDays / 365; // Idade = Data Atual 
                //Console.WriteLine(DataAtual);
                //Console.WriteLine(idade);

                if (Idade >= 18)
                {
                    return true;
                }
            }
            return false;

        }
    }
}