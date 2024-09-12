using System;

class Program {
  public static void Main (string[] args) {
    //Variavel para os times
    int t1, t2; 
    //Saldo de gols
    int s1= 0, s2= 0, m1, v1, m2, v2;
    //Verificar os números de partidas
    int n = int.Parse(Console.ReadLine());
    //for pra pegar o número de partidas
    for(int i = 0; i < n; i++){
      //Zerar as váriaveis
      s1 = 0;
      s2 = 0;
      t1 = 0;
      t2 = 0;
      //for para preencher o vetor
      string [] placar1 = Console.ReadLine().Split('x');
      string [] placar2 = Console.ReadLine().Split('x');
      m1 = int.Parse(placar1[0]);
      v1 = int.Parse(placar1[1]);
      m2 = int.Parse(placar2[0]);
      v2 = int.Parse(placar2[1]);
      //pontos por vitória e empate
        if(m1 > v1){
          s1 += 3;
        }
      else if(v1 > m1){
          s2 += 3;
        }
      else if(m1 == v1){
          s1 += 1;
          s2 += 1;
        }
      if(m2 > v2){
          s2 += 3;
        }
      else if(m2 < v2){
          s1 += 3;
        }
      else{
          s1 += 1;
          s2 += 1;
        }
      //saldo de goals
          t1 = m1 + v2;
          t2 = v1 + m2;
          t1 = t1-t2;
          t2 = (t2-t1) - t2;
          if(s2>s1){Console.WriteLine("Time 2");}
          else if(s1>s2){Console.WriteLine("Time 1");}
          else if(t1>t2){Console.WriteLine("Time 1");}
          else if(t2>t1){ Console.WriteLine("Time 2");}
      //gols na casa do adversário
      else if(v1>v2){Console.WriteLine("Time 2");}
      else if(v1<v2){Console.WriteLine("Time 1");}
      // se nenhuma penalti
      else{Console.WriteLine("Penaltis");}
    }
  }
}