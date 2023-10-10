//SOMA COM APRESENTAÇÃO SIMPLES
using System.Formats.Asn1;

int num1 = 2;
double num2 = 2.3;
double soma = num1 + num2;
Console.WriteLine(soma);

//AREA COM APRESENTAÇÃO COM TEXTO
int h = 2;
int a = 3;
double area = h * a;
Console.WriteLine("O valor da área é de: "+area);

//CONVERSÃO IMPLICITA DE TIPOS DE VARIAVÉL
int y = 6;
double x = y; //--TROCA IMMPLICITA DO TIPO DE DADO, O Y INT AGORA É DOUBLE 
if(y == x)
{
    Console.WriteLine("Variavies iguais!!");
}
else
{
    Console.WriteLine("Variaveis diferentes");
} //IF VERIFICA SE AS VARIAVIES POSSUEM O MESMO VALOR

//CONVERSÃO EXPLICITA
double nota1 = 8.6;
int nota2 = 9;
int media = ((int)nota1 * nota2) / 2; //o (int) representa a troca explicita de dados
Console.WriteLine("A media do aluno é de: " + media);