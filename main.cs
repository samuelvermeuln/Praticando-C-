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
    Console.WriteLine(" 4 notas bimestrais e mostre a média");

    double num11, num22, num33, num44;
    string a1, b2, c3, d4;
    double result1;

    Console.WriteLine ("Primeira nota: ");
    a1 = Console.ReadLine();
    num11 = double.Parse(a1);

    Console.WriteLine ("Segunda nota: ");
    b2 = Console.ReadLine();
    num22 = double.Parse(b2);

    Console.WriteLine ("Terceira nota: ");
    c3 = Console.ReadLine();
    num33 = double.Parse(c3);

    Console.WriteLine ("Quarta nota: ");
    d4 = Console.ReadLine();
    num44 = double.Parse(d4);

    result1 = (num11 + num22 + num33 + num44) / 4;
    Console.WriteLine ("Sua média foi de : " + result1);

  }

  public static void Main () {
    //ex3(); 
    //ex4();

    /* 
              REMOVA O // PARA CHAMAR A FUNÇÃO DESEJADA 
    */
    Console.WriteLine ("OBRIGADO !!");
  }
}