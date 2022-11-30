using CadastroPessoaFF12.Classes;




Endereco endfpf1 = new Endereco();// Instanciando Classe endereço New Endereço()
endfpf1.Logradouro = "Endereço 1";
endfpf1.Numero = 47;
endfpf1.Comercial = false;

PessoaFisica pf1 = new PessoaFisica(); //Instancia a classe pessoa Fisica e cria um objeto 
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
//DateTime data = new DateTime(2000, 5 , 14);

//Console.WriteLine( data.ValidarDataNascimento(data));

