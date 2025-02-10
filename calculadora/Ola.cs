namespace Calculadora
{
   class Operacoes
   {
    public static void RealizarAdicao()
    {
        Console.WriteLine("Primeiro Número:");
        decimal num1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Primeiro Número:");
        decimal num2 = decimal.Parse(Console.ReadLine());

        decimal resultado = (num1 + num2);

        Console.WriteLine($"Resultado: {resultado}");
    }
   }
}