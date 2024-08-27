using AulasPOO.uteis;
using System.Collections.Generic;
using System.Formats.Tar;

int opcao = 0, num1, num2;

do
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Somar\n2 - Multiplicar\n0 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Você escolheu sair.");
            break;
        case 1:
            LerDoisNumerosinteiros();
            var calc = new Calculadora();
            int resultado = calc.Soma(num1, num2);
            Console.WriteLine($"O resultado é {resultado}");
            break;
        case 2:
            LerDoisNumerosinteiros();
            Console.WriteLine($"O resultado é {Calculadora.Mult(num1, num2)}");
            break;
        default:
            Console.WriteLine("Opção invalida.");
            break;
    }
} while (opcao != 0);

void LerDoisNumerosinteiros()
{
    Console.WriteLine("Digite o primeiro numero: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    num2 = int.Parse(Console.ReadLine()); ;

}

/*Na Pasta úteis crie uma classe chamada Sorteador que será capaz de sortear os nomes existentes em um vetor de nomes. 
 * A cada nome sorteado ele será armazenado em uma lista de nomes sorteados.
 * Ao final imprimir a Lista Original e a Lista com os nomes Sorteados
 */

var Sorter = new Sorteador();

List<string> Names = new List<string>();
bool ind = true;
do
{
    Console.Write("Adicione um nome: ");
    Names.Add(Console.ReadLine());
    Console.Write("Deseja continuar?: ");
    var opt = Console.ReadLine();
    if (opt == "não")
    {
        ind = false;
    }
    else
    {
        ind = true;
    }

} while(ind == true);

var Sorteados = Sorter.Sorter(Names);
string final = string.Join(", ", Sorteados);
Console.WriteLine(final);