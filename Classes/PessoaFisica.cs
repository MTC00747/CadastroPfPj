using  CadastroPessoaFF12.Interfaces;
namespace CadastroPessoaFF12.Classes

{
    
    //Herdando Atributos e métodos Da classe Pai "Pessoa" 
    // herdando em segundo A interface IPessoaFisica com A Obrigadotoriedade da Assinatura do método 
    public class PessoaFisica : Pessoa, IPessoaFisica 
    
    {
        public string ?cpf {get;set;}
        public DateTime ?dataNascimento {get; set;}
        
        //Conceito de "OVERRIDE" Vem do fato de o pagamento ser de maneira difereten , Ex: IRpf de 3% para PF E 10% PJ
        // Aqui podemos aplciar o conceito de polimorfismo
        public override float PagarImposto (float rendimento)
        
        {
            throw new NotImplementedException();
        }
        public bool ValidarDataNascimento (DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}