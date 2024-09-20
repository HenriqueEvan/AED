using System;

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

    public void ExibirPaises()
    {
        Console.WriteLine(Nome + " " + Ouro + " " + Prata + " " + Bronze);
    }

}
