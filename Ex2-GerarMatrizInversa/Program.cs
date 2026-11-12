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
            Console.Write($"| {matriz[i, j]} | ");
        }

        Console.WriteLine();
    }
}

void CriarMatrizInversa(int linha, int coluna, int[,] matrizOrigem, int[,] matrizDestino)
{
    linha--;
    coluna--;
    int novaLinha = 0;
    int novaColuna = 0;

    for (int i = linha; i >= 0; i--)
    {
        novaColuna = 0;

        for (int j = coluna; j >= 0; j--)
        {
            matrizDestino[novaLinha, novaColuna] = matrizOrigem[i, j];
            
            novaColuna++;
        }

        novaLinha++;

        Console.WriteLine();
    }
}

int linha, coluna;

Console.WriteLine("Escreva a quantidade de linhas e colunas: ");
Console.Write("Linha: ");
linha = int.Parse(Console.ReadLine()!);

Console.Write("Coluna: ");
coluna = int.Parse(Console.ReadLine()!);

int[,] matriz1 = new int[linha, coluna];
Console.WriteLine("Matriz Criada!");
PreencherMatriz(linha, coluna, matriz1);

Console.WriteLine("Imprimindo Matriz normal!");
ImprimirMatriz(linha, coluna, matriz1);
Console.WriteLine();

int[,] matrizInversa = new int[linha, coluna];
CriarMatrizInversa(linha, coluna, matriz1, matrizInversa);
Console.WriteLine("Imprimindo Matriz Inversa!");
ImprimirMatriz(linha, coluna, matrizInversa);
