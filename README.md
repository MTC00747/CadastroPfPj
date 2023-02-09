#README
# Cadastro de Pessoas Físicas E Juridicas 

## **Descrição :**
### Esse software tem como objetivo estar cadastrando clientes pessoas físicas e juridicas além do cadastro é possível também consultar ambas as classe.

--------------------------------------------------------------------------------------------------------------------------------------------------------

## **Features :**

+ Cadastrar pessoas fisicas e juiricas
+ Consultar pessoas cadastradas
+ Gravar um arquivo CSV
+ Gravar um arquivo TXT 

---------------------------------------------------------------------------------------------------------------------------------------------------------

## **Tecnologias utilizadas :**

* Microsoft Visual Studio Code
* .Net 6.0

----------------------------------------------------------------------------------------------------------------------------------------------------------

## **Organização do projeto :**

### **Classes**

* Edereco.cs (Classe referene ao endereço, onde se encontram as variaves relacionadas a endereço , tais como : Logradoouro, Numero e Comercial)
* Pessoa.cs (Classe refente a pessoas, As variaveis e métodos podem ser herdados tanto em pessoa fisica como júridica)
* PessoaFisica.cs (Variaveis e metodos referente a pessoas fisica)
* PessoaJuridica (Variaveis e métodos referente a pessoa Juridica)
* Utils.cs (Referente a métodos e variaveis utils podem ser utilizadas em todo o projeto pois são publicas)

### DataBase (Onde fica armazenado os arquivos csv , apesar de não se considerado Um Banco de dados)

### Interfaces ( Métodos que vão ser utilizados obrigatoriamente se a interface for herdada , Pois há um "contrato" 

### Progam.cs (Escopo do projeto)

-----------------------------------------------------------------------------------------------------------------------------------------------------------

## **Pré-Requisitos de instalação**

### Não há pré-requisitos de instalação, porém é necessário ter a extensão C# e o .NET Instalado.

--------------------------------------------------------------------------------------------------------------------------------------------------------

## **Execução**

### Estando no Diretório correto executar comando **Dotnet run** no terminal

--------------------------------------------------------------------------------------------------------------------------------------------------------
## **Erros comuns** 

*  Não ter .NET instalado
*  Não estar no diretŕoio correto 
*  Estar executando o comando errado Terminal 

