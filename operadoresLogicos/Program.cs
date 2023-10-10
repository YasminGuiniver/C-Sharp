//OPERADORES ARITIMÉTICOS

int num1 = 1;
int num2 = 1;

//SOMA
int soma = num1 + num2;

//SUBTRAÇÃO
int sub = num1 - num2;

//MULTIPLICAÇÃO
int mult = num1 * num2;

//DIVISÃO
int div = num1 / num2;

//RESTO DA DIVISÃO

int divResto = 8 % 3;

//QUADRADO DE UM NUMERO

double quadrado = Math.Pow(2, 3); //O PRIMEIRO NUMERO SERÁ MULTIPLICADO O TANTO DE VEZES DO SEGUNDO, NO CASO 2x2 = 4, 4x2 = 8

Console.WriteLine(soma);
Console.WriteLine(sub);
Console.WriteLine(mult);
Console.WriteLine(div);
Console.WriteLine(divResto);
Console.WriteLine(quadrado);

//RELACIONAIS
double nota1 = 9.0;
Console.WriteLine("Nota maior que 7? {0}", nota1 > 7); //VAU REETORNAR VERDADEIRO
Console.WriteLine("Nota é 10? {0}", nota1 == 10.0); //VAI RETORNAR FALSO

Console.WriteLine("Digite sua nota: ");
double.TryParse(Console.ReadLine(), out double nota);
Console.WriteLine("Nota maior que 5? {0}", nota > 5);

//CONTROLE, LOGICOS E UNÁRIOS
//CONTROLE -- IF, ELSE, SWITCH CASE
//LOGICOS -- ||, &&, !
//UNÁRIO -- ++ OU --
int numero = 9;
int antecessor = numero--; //NUMERO MENOS 1 -- UNÁRIO
int sucessor = numero++; //NUMERO MAIS 1 -- UNÁRIO

if (antecessor < 10 && numero < 10) // IF -- CONTROLE , && -- LOOGICO
{
    Console.WriteLine("Verdadeiro, os dois são menor do que 10");
}
else if (sucessor < numero) // ELSE IF -- CONTROLE , < -- RELACIONAL 
{
    Console.WriteLine("Sim, sucessor é menor do que numero");

else //ELSE -- CONTROLE
    {
        Console.WriteLine("AAAAAAAAAAA");
    }
    Console.WriteLine("Qual a nota que  você dá? 0 ou 10");
int.TryParse(Console.ReadLine(), out int notinha);
switch (notinha)
{
    case 0:
        Console.WriteLine("CREDO");
        break;
    case 10:
        Console.WriteLine("MUITO BOOM");
        break;
    default:
        Console.WriteLine("Por favor tente inserir uma nota novamente");
        break;
}