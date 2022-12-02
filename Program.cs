using CadastroPessoaFF12.Classes;
using System.Text.RegularExpressions; //Import da classe Regex
Console.WriteLine();
Console.WriteLine(@"********* Pessoa Física**********");
//***********Cadastro de Pessoa Fisica************\\
Console.WriteLine();
Endereco endfpf1 = new Endereco();// Instanciando Classe endereço New Endereço()
endfpf1.Logradouro = "Endereço 1";
endfpf1.Numero = 47;
endfpf1.Comercial = false;

PessoaFisica pf1 = new PessoaFisica(); //Instancia a classe pessoa Fisica e cria um objeto 
PessoaFisica MetodosPf =  new PessoaFisica();// Instanciando um obejto para chamar os métodos.

pf1.Nome ="Matheus"; //declara o valor do objeto 
pf1.Cpf = "1111.1111.111-21";//declara o valor do objeto(Atributo )
pf1.DataNascimento = new DateTime(2000,05,14);
pf1.Rendimento= 1111;
pf1.Endereco = endfpf1;// Indicando que endereço  é igual a instanacia e endpf1 da classe Endereco



Console.WriteLine($"Nome: {pf1.Nome}");// objetos e seus valores
Console.WriteLine($"CPF: {pf1.Cpf}");// objetos e seus valores
Console.WriteLine($"Data de nascimento: {pf1.DataNascimento}");// objetos e seus valores
Console.WriteLine($"Rendimento: {pf1.Rendimento}");// objetos e seus valores
Console.WriteLine($"Logradouro: {pf1.Endereco.Logradouro}");// objetos e seus valores
Console.WriteLine($"Número: {pf1.Endereco.Numero}");// objetos e seus valores
Console.WriteLine($"Endereço comercial ? {pf1.Endereco.Comercial}");// objetos e seus valores
Console.WriteLine($"Maior de Idade? {pf1.ValidarDataNascimento(pf1.DataNascimento)}");// Pega a data de nascimento Usa o método para calcular e retorna se é maior de idade.
//Console.WriteLine($"Maior de Idade? {pf1.ValidarDataNascimento(14/05/2000)}") // Do método String de ValidarDataDeNascimento
DateTime data = new DateTime(2000, 5 , 14);

//Console.WriteLine( data.ValidarDataNascimento(data));

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(@"********* Pessoa Júridica**********");

//************Cadastro de pessoa Júridica**********\\ 



/// Instanciando classse (que é uma composição) endereço e colocando valor nas variaveis. 
Endereco endPj = new Endereco(); /// Instanciando a classe Endereço//
endPj.Logradouro = "Rua albertino";
endPj.Numero = 47;
endPj.Comercial= true;

// Instanciano classe PessoaJuridica e colocando valor em sua variaveis.
PessoaJuridica novaPj = new PessoaJuridica();
PessoaJuridica MetodosPj = new PessoaJuridica(); // Instanciando um obejto para chamar os métodos.

novaPj.Nome = "Matheus Cavalcanti";
novaPj.Endereco = endPj;
novaPj.Rendimento = 1000;
novaPj.Cnpj = "02.023.134/0001-31";
// novaPj.Cnpj = "020231340001331";
novaPj.RazaoSocial = "Matheus Soluções LTDA";
novaPj.NomeFantasia = "MTCS";

//*****Exemplo De caixa de pergunta(INPUT)****\\
// Console.WriteLine("Qual o rendimento?"); // Pergunta QUAL É O RENDIMENTO
// novaPj.Rendimento = float.Parse(Console.ReadLine()); Pega o que o usuario digitar, O  "float.parse" Pega o tipo de dado e transforma em caracteres.

//*******Exibir dados*******\\

// / Para aceitar Quebra de linha e Caracteres especias devemos colocar "@$"
Console.WriteLine(@$" 
Empresa : {novaPj.RazaoSocial}
Nome Fantasia : {novaPj.NomeFantasia}
Representante : {novaPj.Nome}
CNPJ é Válido? : {MetodosPj.ValidarCnpj(novaPj.Cnpj)} 
Redimento Anual  : {novaPj.Rendimento}
Endereço : {novaPj.Endereco.Logradouro}
Número : {novaPj.Endereco.Numero}
É comercial ? {novaPj.Endereco.Comercial}
");
///
/// /CNPJ é Válido? : {novaPj.ValidarCnpj(novaPj.Cnpj)}  : Verifica se o cnpj é valido, Armazendo como valor Cnpj.











//***************** Estudos De caso**************\\
///Sub-String\\

// string nome ="Matheuswww";

// Console.WriteLine(nome.Substring(3));// Pega os dados a partir do caracter 3;
// Console.WriteLine(nome.Substring(03, 04)); /// Começa do caracter 03 e puxa mais 4 caracteres contando a partir dp 04.

////Expressões Regulares\\\\

// String  Data = "02/02/19900";
// bool  dataValue = Regex.IsMatch(Data, @"^\d{2}/\d{2}/\d{4}$" ); //O método Regex recebe a string e identifica um padrão. Não pode ter espaço no começo. E inicia com "^" termina com "$'

// Console.WriteLine(dataValue);

