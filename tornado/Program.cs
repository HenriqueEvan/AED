using System;

class Program
{
    public static void Main(string[] args)
    {
        //declaração das variáveis
        int n = 0, cont = 0;

        //estrutura de repetição
        do
        {
            n = int.Parse(Console.ReadLine());
            if (n >= 5 && n <= 5000)
            {
                int[] vet = new int[n];
                string[] valores = new string[n];
                string linha = Console.ReadLine();
                valores = linha.Split(' ');
                //estrutura para saber quais são os postes
                for (int i = 0; i < n; i++)
                {
                    vet[i] = int.Parse(valores[i]);
                }
                if (vet[n - 1] == 0 && vet[0] == 0)
                {
                    cont++;
                    vet[0] = 1;
                }
                for (int i = 0; i < n - 1; i++)
                {
                    if (vet[i] == 0 && vet[i + 1] == 0)
                    {
                        cont++;
                        vet[i + 1] = 1;
                    }
                }
                //saída dos dados
                Console.WriteLine(cont);
                cont = 0;
            }
        } while (n != 0);

    }
}