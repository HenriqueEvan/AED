﻿using System;

class Program
{
    public static void Main(string[] args) 
    {
        //criação de variavel para determinas quantos paises são
        int n = 0;
        //criação de um vetor de objeto
        n = int.Parse(Console.ReadLine());
        Paises [] paises = new Paises[n];
        //Estrutura de repetição
        for (int i = 0; i < n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            paises[i] = new Paises(valores[0],int.Parse(valores[1]),int.Parse(valores[2]),int.Parse(valores[3]));
           
        }

        //saída dos dados
        foreach (var p in paises)
        {
            p.ExibirPaises();
        }

    }
}