public class ProperFractionsSolution
{
    public static void Main()
    {
        // Test
        var t = ProperFractions(15);
        // ...should return 8
    }

    public static long ProperFractions(long n)
    {
        if (n < 2)
            return 0;

        long result = n;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                while (n % i == 0)
                    n /= i;

                result -= result / i;
            }
        }

        if (n > 1)
            result -= result / n;

        return result;
    }
}