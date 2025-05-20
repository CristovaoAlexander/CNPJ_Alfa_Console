// See https://aka.ms/new-console-template for more information
using Projeto_Zero;
using Projeto_Zero.Controllres;

Console.WriteLine("Hello, World!");

var controller = new Controller();
controller.Processo();

Console.WriteLine("calculo DV CNPJ");
Console.Write("informe 12 digitos CNPJ : ");
var cnpj = Console.ReadLine();
controller.RetornoCNPJ(cnpj);



