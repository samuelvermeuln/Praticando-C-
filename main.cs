using System;
// 3. Faça um Programa que peça dois números e imprima a soma.
// 4. Faça um Programa que peça as 4 notas bimestrais e mostre a média.

class MainClass {

  public static void ex3 () {
    Console.WriteLine ("SOMA DE DOIS VALORES");
    double num1, num2;
    string a, b;
    double result;

    Console.WriteLine ("Primeiro valor: ");
    a = Console.ReadLine();
    num1 = double.Parse(a);

    Console.WriteLine ("Segundo valor: ");
    b = Console.ReadLine();
    num2 = double.Parse(b);

    result = num1 + num2;
    Console.WriteLine ("Resultado da Soma: " + result);    
    
  }

  public static void ex4 () {     
    
  }

  public static void Main () {
    ex3();
  }
}