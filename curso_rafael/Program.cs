using System;


namespace curso_rafael
{
    class Program
    {
        static void Main(string[] args)
        {
           int primeiroNumero;
           primeiroNumero = 27;
           Console.WriteLine($"primeiroNumeo: {primeiroNumero}");
           int segundoNumero = 12;
           Console.WriteLine($"segundoNumero: {segundoNumero}");
           Console.WriteLine($"a soma dos dois numeros é: {primeiroNumero+segundoNumero}");        
           Console.WriteLine($"a subtração de primeiroNumero pelo segundoNumero e igual a: {primeiroNumero-segundoNumero}");
           Console.WriteLine($"a multiplicação de segundoNumero por três e igual a: {segundoNumero*3}");
           Console.WriteLine($"a divisão de primeiroNumero por 3 e igual a: {primeiroNumero/3}");
           
           // criando uma variavel do tipo float
           float primeiroFloat;
           Console.WriteLine("escreva um numero com casas decimais");
           primeiroFloat = float.Parse(Console.ReadLine());
           Console.WriteLine($"multiplicando primeiro float por 4.7: {primeiroFloat*4.7}");

            /* criando uma variavel do tipo
            */
            double primeiro_double;
            Console.WriteLine("escreva outro numero com casas decimais");
            primeiro_double  = double.Parse(Console.ReadLine());
            Console.WriteLine($"multiplique primeiro_double por 1.4: {primeiro_double*1.4}");  
         } 
    }
}
