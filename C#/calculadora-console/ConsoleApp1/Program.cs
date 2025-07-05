double num1, num2, resultado;
int opcao, retorno;


do
{
    Console.WriteLine("Insira o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    do
    {
        Console.WriteLine("Qual operação deseja fazer ?");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");


        opcao = Convert.ToInt32(Console.ReadLine());


        switch (opcao)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("O resultado é: " + resultado);
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine("O resultado é: " + resultado);
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine("O resultado é: " + resultado);
                break;
            case 4:
                resultado = num1 / num2;
                Console.WriteLine("O resultado é: " + resultado);
                break;

            default:
                Console.WriteLine("Opção inválida. Tente novamente!");
                break;


        }
    } while (opcao > 4 || opcao < 1);

    Console.WriteLine("Deseja fazer outra operação? \n(1) SIM \n(0) NÃO");
    retorno = Convert.ToInt32(Console.ReadLine());

} while (retorno == 1);