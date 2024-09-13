using System;
using System.Dynamic;
class Program
{
    public static void Main(string[] args)
    {
        //declaração das váriaveis 
        int n = 0, m = 0, totalResultados = 0;
        
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
                //variáveis de casos
                bool resultado1 = true, resultado2 = true, resultado3 = true, resultado4 = true ;
                
                //verifica resultado 1 e 4
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    bool todos = true;
                    bool nenhum = true;
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {

                        if (mat[i,j] == 1)
                        {
                            nenhum = false;
                        }
                        else
                        {
                            todos = false;
                        }
                    }

                    if (todos)
                    {
                        resultado1 = false;
                    }
                    if (nenhum)
                    {
                        resultado4 = false;
                    }
                }

                //resultado 2 e 3
                for (int i = 0; i < mat.GetLength(1); i++)
                {
                    bool alguem = false;
                    bool porTodos = true;
                    for (int j = 0; j < mat.GetLength(0); j++)
                    {

                        if (mat[j,i] == 1)
                        {
                            alguem = true;
                        }
                        else
                        {
                            porTodos = false;
                        }
                    }

                    if (!alguem)
                    {
                        resultado2 = false;
                    }
                    if (porTodos)
                    {
                        resultado3 = false;
                    }
                }

                    //verificação dos casos
                     if (resultado1)
                     {
                        totalResultados++;
                     }  
                     if (resultado2)
                     {
                        totalResultados++;
                     }  
                     if (resultado3)
                     {
                        totalResultados++;
                     }  
                     if (resultado4)
                     {
                        totalResultados++;
                     }  
                    //saída dos dados
                    Console.WriteLine(totalResultados);
                    totalResultados = 0;
            }
        } while (n != 0 && m != 0 );


    }
}