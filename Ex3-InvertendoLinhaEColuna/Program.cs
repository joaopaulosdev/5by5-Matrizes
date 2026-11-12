using System.Security.Cryptography;
using System.Xml;
void PreencherMatriz(int linha, int coluna, int[,] matriz)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 9);
        }

    }
}

void PreencherTranspondo(int linha, int coluna, int[,] matrizOrigem, int[,] matrizDestino)
{
    linha--;
    coluna--;

    for (int i = linha; i >= 0; i--)
    {
        for (int j = coluna; j >= 0; j--)
        {
            matrizDestino[i, j] = matrizOrigem[j, i];
        }

        Console.WriteLine();
    }
}

void ImprimirMatriz(int linha, int coluna, int[,] matriz)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"| {matriz[i, j]} | ");
        }

        Console.WriteLine();
    }
}

int linha = 3;
int coluna = 5;

int[,] matriz3x5 = new int[linha, coluna];

PreencherMatriz(linha, coluna, matriz3x5);
Console.WriteLine("IMPRIMINDO MATRIZ ORIGINAL: ");
ImprimirMatriz(linha, coluna, matriz3x5);
Console.WriteLine();


int[,] matrizTransposta5x3 = new int[coluna, linha];
PreencherTranspondo(coluna, linha, matriz3x5, matrizTransposta5x3);
Console.WriteLine("IMPRIMINDO MATRIZ TRANSPOSTA: ");
ImprimirMatriz(coluna, linha, matrizTransposta5x3);
