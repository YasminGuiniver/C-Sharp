using System.Net.Http.Headers;

Console.WriteLine("Olá, eu irei te ajudar a calcular a média do seu aluno");

Console.WriteLine("Insira abaixo a 1° nota do seu aluno");
double.TryParse(Console.ReadLine(), out double nota1);

Console.WriteLine("Insira abaixo a 1° nota do seu aluno");
double.TryParse(Console.ReadLine(), out double nota2);

Console.WriteLine("Insira abaixo a 1° nota do seu aluno");
double.TryParse(Console.ReadLine(), out double nota3);

double media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("A média do seu aluno é de: " + media);

if(media > 7)
{
    Console.WriteLine("Parabéns seu aluno está aprovado");
}else
{
    Console.WriteLine("Que pena, seu aluno está reprovado");
}