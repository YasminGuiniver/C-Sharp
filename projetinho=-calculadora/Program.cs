//CALCULADORA DE SOMA
bool opcao = true;
Console.WriteLine("Olá,eu irei realizar a soma dos numeros que você inserir até que você deseje parar");

Console.WriteLine("Digite o valor inicial");
float.TryParse(Console.ReadLine(), out float num1);

while(opcao == true)
{
    Console.WriteLine("Digite o proximo numero da soma");
    float.TryParse(Console.ReadLine(), out float num2);

    num1 = num1 + num2;

    Console.WriteLine("Até agora sua soma está em: {0}", num1);

    Console.WriteLine("Oque deseja fazer? Digite 1 para finalizar e 2 para continuar");
    int.TryParse(Console.ReadLine(), out int resposta);

    switch (resposta)
    {
        case 1:
            Console.WriteLine("Finalizar a soma");
            opcao = false;
            break;
        case 2:
            Console.WriteLine("Continua a soma");
            break;
        default:
            Console.WriteLine("Opção invalida, encerrando o programa");
            opcao = false;
            break;
    }
}

