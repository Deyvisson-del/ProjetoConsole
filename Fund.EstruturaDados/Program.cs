   public class Program
   {
      static void Main(string[] args)
      {
         int[] A = { 5, 2, 8, 1, 9 };
         int n = A.Length;
         int menor = CalcularMenor(A, n);
        Console.WriteLine("O menor valor é: " + menor);
      }

    public static int CalcularMenor(int[] A, int n)
    {
        int menor, i;
        menor = A[0];
        for (i = 1; i < n; i++)
        {
            if (A[i] < menor)
            {
                menor = A[i];
            }
        }
        return menor;
    }
   }
