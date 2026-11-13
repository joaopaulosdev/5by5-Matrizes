using System.Security.Cryptography;

void ImprimirMatrizQ(int tamanho, int[,] matriz)
{
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            Console.Write($"| {matriz[i, j]} | ");
        }

        Console.WriteLine();
    }
}
void PreencherMatrizQ(int tamanho, int[,] matriz)
{
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 5);
        }

    }
}
void SomarLinhaMatrizQ(int tamanhoMatriz, int[,] matriz)
{

    int resultadoSomaL = 0;
    int posicaoLinha = 0;
    for (int i = 0; i < tamanhoMatriz; i++)
    {
        resultadoSomaL = 0;
        for (int j = 0; j < tamanhoMatriz; j++)
        {
            resultadoSomaL += matriz[i, j];
        }
        Console.WriteLine($"Resultado Linha {posicaoLinha + 1} = {resultadoSomaL}");
        posicaoLinha++;
    }

}
void SomarColunaMatrizQ(int tamanhoMatriz, int[,] matriz)
{

    int resultadoSomaC = 0;
    int posicaoColuna = 0;
    for (int i = 0; i < tamanhoMatriz; i++)
    {
        resultadoSomaC = 0;
        for (int j = 0; j < tamanhoMatriz; j++)
        {
            resultadoSomaC += matriz[j, i];
        }
        Console.WriteLine($"Resultado Coluna {posicaoColuna + 1} = {resultadoSomaC}");
        posicaoColuna++;
    }

}
void SomarDiagonaisMQuad(int tamanhoMatriz, int[,] matriz)
{

    int resultadoSomaDiag = 0;
    int linha = 0;
    for (int i = 0; i < tamanhoMatriz; i++)
    {
        linha = i;
        resultadoSomaDiag += matriz[linha, i];
        
    }

    Console.WriteLine($"Resultado Diagonal Principal = {resultadoSomaDiag}");

    //SOMA DIAGONAL INVERSA
    resultadoSomaDiag = 0;
    int coluna = (tamanhoMatriz - 1);

    for (int i = 0; i < tamanhoMatriz; i++)
    {
        resultadoSomaDiag += matriz[i, coluna];
        coluna--;
    }
    Console.WriteLine($"Resultado Diagonal Secundária = {resultadoSomaDiag}");


}

int tamanhoMatriz;
Console.Write("Insira um tamanho para a matriz quadrática: ");
tamanhoMatriz = int.Parse(Console.ReadLine()!);

int[,] matrizQ = new int[tamanhoMatriz, tamanhoMatriz];

PreencherMatrizQ(tamanhoMatriz, matrizQ);
Console.WriteLine("\n");

ImprimirMatrizQ(tamanhoMatriz, matrizQ);
Console.WriteLine("\n");

SomarLinhaMatrizQ(tamanhoMatriz, matrizQ);
Console.WriteLine("\n");

SomarColunaMatrizQ(tamanhoMatriz, matrizQ);
Console.WriteLine("\n");

SomarDiagonaisMQuad(tamanhoMatriz, matrizQ);


