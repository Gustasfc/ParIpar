double numeroDigitado;
double restoDivisaoPorDois;

Console.Clear();

Console.WriteLine("Digite um número: ");
numeroDigitado = Convert.ToDouble(Console.ReadLine());

restoDivisaoPorDois = numeroDigitado % 2;

if (restoDivisaoPorDois != 0)
{
    Console.WriteLine($"O número {numeroDigitado} é ímpar!");
}
else
{
    Console.WriteLine($"O número {numeroDigitado} é par!");
}
