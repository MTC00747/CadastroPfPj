using CadastroPessoaFF12.Classes;

PessoaFisica obj_Pf = new PessoaFisica(); //Instancia a classe pessoa Fisica e cria um objeto 
PessoaFisica obj_Pf2 = new PessoaFisica();//Instancia a classe pessoa Fisica Com um segundo objeto 
PessoaJuridica ObjPj = new PessoaJuridica();//Instancia a classe pessoa Juridica  e cria um objeto

obj_Pf.nome ="Matheus"; //declara o valor do objeto 
obj_Pf.cpf = "1111.1111.111-21";//declara o valor do objeto(Atributo )

obj_Pf2.nome = "Júlia";
obj_Pf2.cpf ="11111.1.1111-21";

//Pessoa Juridica
ObjPj.RazaoSocial = "Empresa1";//declara o valor do objeto 
ObjPj.Cnpj = "22222-2222--222";//declara o valor do objeto(Atributo )


Console.WriteLine($"Nome: {obj_Pf.nome} com o CPF : {obj_Pf.cpf}");//Imprime na tela Os objetos e seus valores
Console.WriteLine($"Nome: {obj_Pf2.nome} com o CPF : {obj_Pf2.cpf}");
Console.WriteLine($"Razão Social: {ObjPj.RazaoSocial} com o CNPJ : {ObjPj.Cnpj}");


