namespace Weboo.Examen
{
    class Program
    {
        static void Main(string[] args)
        {
             Case1();
        }

        static void Case1()
        {
            Console.WriteLine("Case 1");
            int[] numeros = new int[] {-7,-6,-5};
            int[] solucionEsperada = new int[] { 2, 7 };
            Test(numeros, solucionEsperada);
        }

        static void Test(int[] numeros, int[] solucionEsperada)
        {
            int[] solucionObtenida = Solucion.SubarrayDeSumaMaxima(numeros);
            if (solucionEsperada.SequenceEqual(solucionObtenida))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("OK");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Console.WriteLine($"Se esperaba: {{ {string.Join(", ", solucionEsperada)} }}");
                Console.WriteLine($"Se obtuvo: {{ {string.Join(", ", solucionObtenida)} }}");
                Console.ResetColor();
            }
        }
    }
}