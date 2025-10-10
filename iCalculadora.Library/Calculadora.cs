namespace iCalculadora.Library
{
    public class Calculadora
    {
        public double Somar(double a, double b) => a + b;
        public double Subtrair(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;
        public double Dividir(double a, double b) => b == 0 ? double.NaN : a / b;
    }
}
