using System;

class Program
{
    public static void Main(string[] args)
    {
        //criação de variavel para determinas quantos paises são
        int n = 0;
        //criação de um vetor de objeto
        n = int.Parse(Console.ReadLine());
        Paises[] paises = new Paises[n];
        //Estrutura de repetição
        for (int i = 0; i < n; i++)
        {
            //entrada dos dados
            string[] valores = Console.ReadLine().Split(' ');
            paises[i] = new Paises(valores[0], int.Parse(valores[1]), int.Parse(valores[2]), int.Parse(valores[3]));

        }
        //condições de ordenação
        for (int i = 1; i < n; i++)
        {
            Paises aux = paises[i];
            int j = i - 1;
            //condição para ordenação medalha de ouro
            while (j >= 0 && aux.Ouro > paises[j].Ouro)
            {
                paises[j + 1] = paises[j];
                j--;
            }
            paises[j + 1] = aux;
            //condição para ordenação medalha de prata
            while (j >= 0 && aux.Ouro == paises[j].Ouro && aux.Prata > paises[j].Prata)
            {
                paises[j + 1] = paises[j];
                j--;
            }
            paises[j + 1] = aux;
            //condição para ordenação medalha de bronze
            while (j >= 0 && aux.Ouro == paises[j].Ouro && aux.Prata == paises[j].Prata && aux.Bronze > paises[j].Bronze)
            {
                paises[j + 1] = paises[j];
                j--;
            }
            paises[j + 1] = aux;
            //condição para ordenação por nome
            while (j >= 0 && aux.Ouro == paises[j].Ouro && aux.Prata == paises[j].Prata && aux.Bronze == paises[j].Bronze && aux.Nome.CompareTo(paises[j].Nome) < 0)
            {
                paises[j + 1] = paises[j];
                j--;
            }
            paises[j + 1] = aux;

        }
        //saída dos dados
        for (int i = 0; i < n; i++)
        {
            paises[i].ExibirPaises();
        }
        /*
        foreach (var p in paises)
        {
            p.ExibirPaises();
        }*/

    }
}

//classe para criar vetor de objetos
public class Paises
{
    public string Nome
    {
        get;
        set;
    }
    public int Ouro
    {
        get;
        set;
    }
    public int Prata
    {
        get;
        set;
    }
    public int Bronze
    {
        get;
        set;
    }


    public Paises(string nome, int ouro, int prata, int bronze)
    {
        Nome = nome;
        Ouro = ouro;
        Prata = prata;
        Bronze = bronze;
    }

    public int MedalhasOuro()
    {
        return Ouro;
    }
    public int MedalhasPrata()
    {
        return Prata;
    }
    public int MedalhasBronze()
    {
        return Bronze;
    }

    public void ExibirPaises()
    {
        Console.WriteLine(Nome + " " + Ouro + " " + Prata + " " + Bronze);
    }

}