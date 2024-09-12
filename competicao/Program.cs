using System;
class Program
{
    public static void Main(string[] args)
    {
        //declaração das váriaveis 
        int n = 0, m = 0 , resultado = 0, diagP = 0, diagS = 0;
        // estrutura de repetição
        do
        {
            //entrada dos dados
            string linha = Console.ReadLine();
            string[] valores = linha.Split(' ');
            n = int.Parse(valores[0]);
            m = int.Parse(valores[1]);

            //condição de inicio de casos de teste que o exercíco pede
            if (n >= 3 && m <= 100)
            {

                //matriz para entrada dos casos
                int[,] mat = new int[n, m];
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    linha = Console.ReadLine();
                    valores = linha.Split(' ');
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                    mat[i, j] = int.Parse(valores[j]);
                    }
                }
                
                //percorrer matriz para verificar
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {

                        //somar diagonais para saber se todos os casos foram resolvidos
                        diagP += mat[i,i];
                        diagS += mat[i, mat.GetLength(1) -1 -i];
                        //opção 1 e 2 do caso de teste
                        resultado += mat[i,j];

                    }
                }
                        //saída dos dados
                        //verificação dos casos
                        if (resultado == 0)
                        {
                            Console.WriteLine(1);
                        }
                        else if (resultado != 0)
                        {
                            Console.WriteLine(2);
                        }
                        else if (diagP == 1 * mat.GetLength(1) && diagS == 1 * mat.GetLength(1))
                        {
                            Console.WriteLine(4);
                        }
                        else
                        {
                            Console.WriteLine(3);
                        }
            }
        } while (n != 0 && m != 0 );


    }
}