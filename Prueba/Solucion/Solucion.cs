namespace Weboo.Examen
{
    public static class Solucion
    {//metodo que da respuesta final.
    public static int[] SubarrayDeSumaMaxima(int[] numeros)
    {int[] mayorsuma = SumaMax(numeros);
    int inicio = mayorsuma[0];
    int final = mayorsuma[1];
    int[] subarrayDeSumaMaxima = new int[final-inicio+1];
     for (int m = 0; m <= final-inicio; m++)
   {
   subarrayDeSumaMaxima[m]= numeros[inicio+m];
   }
    return subarrayDeSumaMaxima;
    }
        public static int[] SumaMax(int[] a)
{   int inicio = 0;
    int final = 0;
    int maxSuma = a[0];
    for (int i = 0; i < a.Length; i++)
    { int sumaActual = 0;
        for (int j = i; j < a.Length; j++)
        {   sumaActual += a[j];
            if(sumaActual>=maxSuma)
            {
               maxSuma = sumaActual;
               inicio = i;
               final = j;
            }
            }
        }
    int[] mayorsuma = {inicio,final};
    return mayorsuma;
}
    }
}
    