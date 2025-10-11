using iCalculadora.Library;

var calc = new Calculadora();

Console.WriteLine("--------------- TESTE ---------------\n");
Console.WriteLine("Informe as operações a testar (ex: + - * /).");
Console.WriteLine("Deixe em branco para rodar todos:\n");

var input = Console.ReadLine()?.Trim().ToUpper() ?? string.Empty;

bool rodarTudo = string.IsNullOrWhiteSpace(input);

if (rodarTudo || input.Contains("+"))
{
    TestarSoma(calc);
}

if (rodarTudo || input.Contains("-"))
{
    TestarSubtracao(calc);
}

if (rodarTudo || input.Contains("*") || input.Contains("X"))
{
    TestarMultiplicacao(calc);
}

if (rodarTudo || input.Contains("/"))
{
    TestarDivisao(calc);
}

Console.WriteLine("\n-------------------------------------");
Console.ReadLine();


// ---------------- Rotinas de Teste ----------------

static void TestarSoma(Calculadora calc)
{
    Console.WriteLine("[TESTES DE SOMA]");
    Testar("2 + 3", calc.Somar(2, 3), 5);
    Testar("-1 + 4", calc.Somar(-1, 4), 3);
    Console.WriteLine();
}

static void TestarSubtracao(Calculadora calc)
{
    Console.WriteLine("[TESTES DE SUBTRAÇÃO]");
    Testar("10 - 4", calc.Subtrair(10, 4), 6);
    Testar("5 - 9", calc.Subtrair(5, 9), -4);
    Console.WriteLine();
}

static void TestarMultiplicacao(Calculadora calc)
{
    Console.WriteLine("[TESTES DE MULTIPLICAÇÃO]");
    Testar("3 × 7", calc.Multiplicar(3, 7), 21);
    Testar("-2 × 5", calc.Multiplicar(-2, 5), -10);
    Console.WriteLine();
}

static void TestarDivisao(Calculadora calc)
{
    Console.WriteLine("[TESTES DE DIVISÃO]");
    Testar("20 ÷ 5", calc.Dividir(20, 5), 4);
    Testar("10 ÷ 0", calc.Dividir(10, 0), double.NaN);
    Console.WriteLine();
}

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
