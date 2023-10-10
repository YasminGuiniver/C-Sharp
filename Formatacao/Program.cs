//OUTRO EXEMPLO DE CONVERSÃO
double num = 20.878;
Console.WriteLine(num.ToString("F1")); //ARREDONDA PARA 20,9
Console.WriteLine(num.ToString("C")); //APRESENTA O VALOR FORMATADO EM DINHEIRO -- R$20,88
Console.WriteLine(num.ToString("P")); //APRESENTA EM % -- 2.087,80%

//LEITURA DE DADOS
Console.WriteLine("Qual seu nome");
String nome = Console.ReadLine();
Console.WriteLine("Quantos anos você tem?");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Seu nome é {0} e sua idade é de {1}", nome, idade);

//INFERENCIA -- QUANDO O PROGRAMA RECONHECE SOZINHO O VALOR DA VARIAVEL
var idade2 = 17;
var salario = 1200.32;

Console.WriteLine("Idade {0}, Salario {1}", idade2, salario);
