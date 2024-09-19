using System;

class Program
{
    public static void Main(string[] args) 
    {
        //criação das variáveis
        int n = 0, bem = 0, mal = 0 ;
        
            n = int.Parse(Console.ReadLine());
            String[] nomes = new string [n];
            for (int i = 0; i < n; i++)
            {
            string sinal = "";
            string[] valores = Console.ReadLine().Split(' ');
            sinal = valores[0];
            nomes[i] = valores[1];
            //comparação para saber quantos se comportaram ou não
            if (sinal == "+")
            {
                bem++;
            }
            else
            {
                mal++;
            }
                
            }
            //estrutura de repetição para comparação
            for (int i = 0; i < n -1; i++)
            {
                for (int j = 0; j < n -i -1; j++)
                {
                //condição para efetuar a ordenação
                if (nomes[j].CompareTo(nomes[j+1]) > 0)
                {
                    string aux = nomes[j];
                    nomes[j] = nomes[j+1];
                    nomes[j+1] = aux;
                }
                    
                }
            }
            //saída da lista dos nomes em ordem alfabética
                foreach (string s in nomes)
                {
                    Console.WriteLine(s);
                }
            
            //saída dos dados de quantos se comportaram ou não 
            Console.WriteLine("Se comportaram: "+ bem + " | Não se comportaram: "+ mal );
        

    }
}