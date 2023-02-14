using System;

class Program {
  public static void Main (string[] args) {
    int n=0, maior=0;
    Console.WriteLine("Determina o maior valor de 10 numeros");
    Console.Write("Informe o primeiro numero: ");
    n = int.Parse(Console.ReadLine());
    maior = n;
    Console.Write("Iforme o segundo valor: ");
    n = int.Parse(Console.ReadLine());
    if (n>maior){
      maior = n;
    }
    Console.Write("Iforme o terceiro valor: ");
    n = int.Parse(Console.ReadLine());
    if (n>maior){
      maior = n;
  }
    Console.Write("Iforme o quarto valor: ");
    n = int.Parse(Console.ReadLine());
    if (n>maior){
      maior = n;
}
    Console.Write("Iforme o quinto valor: ");
    n = int.Parse(Console.ReadLine());
    if (n>maior){
      maior = n;
    }
    Console.Write("Iforme o sexto valor: ");
    n = int.Parse(Console.ReadLine());
    if (n>maior){
      maior = n;
    }
    Console.Write("Iforme o setimo valor: ");
    n = int.Parse(Console.ReadLine());
    if (n>maior){
      maior = n;
    }
    Console.Write("Iforme o oitavo valor: ");
    n = int.Parse(Console.ReadLine());
    if (n>maior){
      maior = n;
    }
    Console.Write("Iforme o nono valor: ");
    n = int.Parse(Console.ReadLine());
    if (n>maior){
      maior = n;
    }
    Console.Write("Iforme o decimo valor: ");
    n = int.Parse(Console.ReadLine());
    if (n>maior){
      maior = n;
    }
    Console.WriteLine("O maior valor e: " + maior);
  }
}