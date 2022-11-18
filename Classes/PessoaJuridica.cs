using CadastroPessoaFF12.Interfaces;
namespace CadastroPessoaFF12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica 
    {
        public string ?Cnpj {get; set; }
         public string ?RazaoSocial {get; set; }
        public bool ValidarCnpj (bool ValidarCnpj) // Método que foi herdado da "INTERFACE" 
        { 
         throw new NotImplementedException(); //Não retorna nada
        }

        //Conceito de "OVERRIDE" Vem do fato de o pagamento ser de maneira difereten , Ex: IRpf de 3% para PF E 10% PJ
        // Aqui podemos aplciar o conceito de polimorfismo
        public override float PagarImposto(float rendiemento) 
        {
            throw new NotImplementedException();
        }
    }
}