using System.Security.Cryptography;

void ImprimirMatriz(int[,] matriz)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write($"| {matriz[i,j]} | ");
        }
        
        Console.WriteLine();
    }
}

void PreencherMatriz(int[,] matriz)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            matriz[i,j] = RandomNumberGenerator.GetInt32(1, 6);
        }

    }
}

int[,] matriz1 = new int[2, 2];

Console.WriteLine("Criando a matriz...");
Console.WriteLine("Preenchendo...");

Console.WriteLine("MATRIZ: ");

PreencherMatriz(matriz1);

ImprimirMatriz(matriz1);