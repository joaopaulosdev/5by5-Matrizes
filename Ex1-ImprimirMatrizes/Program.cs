
using System.Security.Cryptography;

void PreencherMatriz(int linha, int coluna, int[,] matriz)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 6);
        }

    }
}

void ImprimirMatriz(int linha, int coluna, int[,] matriz)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"Posição: [{i},{j}] | Dado: {matriz[i, j]} | ");
        }

        Console.WriteLine();
    }

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"| {matriz[i, j]} | ");
        }

        Console.WriteLine();
    }
}

void ImprimirMatrizInversa(int linha, int coluna, int[,] matriz)
{
    linha--;
    coluna--;

    for (int i = linha; i >= 0; i--)
    {
        for (int j = coluna; j >= 0; j--)
        {
            Console.Write($"Posição: {i},{j}| Dado: {matriz[i, j]} | ");
        }

        Console.WriteLine();
    }


    for (int i = linha; i >= 0; i--)
    {
        for (int j = coluna; j >= 0; j--)
        {
            Console.Write($"| {matriz[i, j]} | ");
        }

        Console.WriteLine();
    }
}

int linha, coluna;

Console.WriteLine("Escreva os valores de coluna e linha: ");
Console.Write("Linha: ");
linha = int.Parse(Console.ReadLine()!);

Console.Write("Coluna: ");
coluna = int.Parse(Console.ReadLine()!);

int[,] matriz1 = new int[linha, coluna];
Console.WriteLine("Matriz Criada!");
PreencherMatriz(linha, coluna, matriz1);

Console.WriteLine("Imprimindo matriz normal!\n");
ImprimirMatriz(linha, coluna, matriz1);
Console.WriteLine();

Console.WriteLine("Imprimindo a nova matriz!\n");
ImprimirMatrizInversa(linha, coluna, matriz1);



