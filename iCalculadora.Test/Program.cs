using iCalculadora.Library;

var calc = new Calculadora();

Console.WriteLine("--------------- TESTE ---------------\n");

Testar("Soma 2 + 3", calc.Somar(2, 3), 5);
Testar("Soma -1 + 4", calc.Somar(-1, 4), 3);

Testar("Subtração 10 - 4", calc.Subtrair(10, 4), 6);
Testar("Subtração 5 - 9", calc.Subtrair(5, 9), -4);

Testar("Multiplicação 3 × 7", calc.Multiplicar(3, 7), 21);
Testar("Multiplicação -2 × 5", calc.Multiplicar(-2, 5), -10);

Testar("Divisão 20 ÷ 5", calc.Dividir(20, 5), 4);
Testar("Divisão 10 ÷ 0", calc.Dividir(10, 0), double.NaN);

Console.WriteLine("\n-------------------------------------");
Console.ReadLine();

static void Testar(string descricao, double resultado, double esperado)
{
    if (resultado == esperado || (double.IsNaN(resultado) && double.IsNaN(esperado)))
    {
        Console.WriteLine($"[OK] {descricao}");
    }
    else
    {
        Console.WriteLine($"[NOT OK] {descricao} - esperado {esperado}, obtido {resultado}");
    }
}
