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
           
         }
    }
}
