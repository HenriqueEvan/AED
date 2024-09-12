using System;
class Program
{
    public static void Main(string[] args)
    {
        //declaração das váriaveis 
        int n = 0, m = 0 , resultado1 = 0, resultado2 = 0, resultado3 = 0, resultado4 = 0;;
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

                        //resultado 2 verificação
                        if (mat[j,i] == 1 && mat[i,j] == 1)
                        {
                            resultado2 += mat[i,j];
                            
                        }
                        if (mat[j,i] == 1 && mat[i,j] == 0)
                        {
                            resultado4 = mat[j,i];
                        }
                        //opção 1 e 2 do caso de teste
                        resultado1 += mat[i,j];

                    }
                }
                        //saída dos dados
                        //verificação dos casos
                        if (resultado1 == 0)
                        {
                            Console.WriteLine(1);
                        }
                        else if (resultado2 <= 3)
                        {
                            Console.WriteLine(2);
                        }
                        else if (resultado4 >= 3)
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