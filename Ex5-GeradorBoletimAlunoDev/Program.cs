using System.Diagnostics;
using System.Security.Cryptography;

Console.WriteLine("===== BOLETIM DO DEV =====");

double[,] matrizNotas = new double[5, 5];
string[] materias = {
    "Arte do Ctrl+C e Ctrl+V".PadRight(40),
    "Prog. Orient. a Stack Overflow".PadRight(40),
    "Debugging Emocional".PadRight(40),
    "Arquit. de Softw. Feita na Pressa".PadRight(40),
    "Gestão Estratégica de Madrugadas".PadRight(40)
};

string[] situacaoMaterias = new string[5];

void PreencherBoletim(int qtdMaterias, int qtdNotas, double[,] matrizNotas)
{
    Random random = new Random();
    for (int i = 0; i < qtdMaterias; i++)
    {
        for (int j = 0; j < qtdNotas; j++)
        {
            matrizNotas[i, j] = (random.NextDouble() * 10);
        }

    }
}

void CalcularMedia(int qtdMaterias, int qtdNotas, double[,] matrizNotas)
{
    
    double media;

    for (int i = 0; i < qtdMaterias; i++)
    {   
        double somaNotas = 0;
        for (int j = 0; j < qtdNotas; j++)
        {
            somaNotas += matrizNotas[i, j];
        }
        media = somaNotas / qtdNotas;
        matrizNotas[i, 4] = media;
    }

}

void CalcularSituacao(int qtdMaterias, int qtdNotas, double[,] matrizNotas, string[] situacaoMaterias)
{
    for(int i = 0;i < qtdMaterias; i++)
    {
        //qtdNotas vai apontar a posição da média na matriz.
        if (matrizNotas[i,qtdNotas] <= 5)
        {
            situacaoMaterias[i] = "Reprovado";
        } else if(matrizNotas[i, qtdNotas] > 5 && matrizNotas[i, qtdNotas] < 7)
        {
            situacaoMaterias[i] = "Recuperação";
        }
        else
        {
            situacaoMaterias[i] = "Aprovado";
        }
    }
}

void ImprimirBoletim(int qtdNotas, string[] materias, double[,] matrizNotas, string[] situacaoMaterias)
{

    Console.Write("");
    Console.WriteLine("=========================== BOLETIM DO ALUNO DESENVOLVEDOR ===========================\n");
    //Títulos
    Console.Write("MATÉRIAS".PadRight(41));
    Console.WriteLine($"| P 1 | P 2 | P 3 | P 4 |MÉDIA| SITUAÇÃO \n");

    //Todos possuem a mesma quantidade de linhas
    for ( int i = 0; i < materias.Length; i++ )
    {
        Console.Write($"{materias[i]} ");
        for(int j = 0; j < qtdNotas; j++)
        {
            Console.Write($"| {matrizNotas[i,j]:F1} ");
        }
        Console.Write($"| {matrizNotas[i,qtdNotas]:F1} ");
        Console.WriteLine($"| {situacaoMaterias[i]}");
    }
    Console.WriteLine("\n ======================================================================================\n");
}

int opcao;

do
{
    Console.WriteLine("\n===== MENU PRINCIPAL =====");
    Console.WriteLine("1 - Gerar boletim");
    Console.WriteLine("2 - Sair");
    Console.Write("\nEscolha uma opção: ");

    opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.Clear();

            PreencherBoletim(5, 4, matrizNotas);
            CalcularMedia(5, 4, matrizNotas);
            CalcularSituacao(5, 4, matrizNotas, situacaoMaterias);
            ImprimirBoletim(4, materias, matrizNotas, situacaoMaterias);

            break;

        case 2:
            Console.WriteLine("\nEncerrando o sistema...");
            break;

        default:
            Console.WriteLine("\nOpção inválida! Tente novamente.");
            break;
    }

} while (opcao != 2);