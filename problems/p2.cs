public class p2
{
    public static int id = 2;
    public static string title = "Even Fibonacci Numbers";

    public static int run()
    {
        int result = 0;
        for (int a = 1, b = 1 ;a < 4000000; (a,b) = (a+b,a))
        {
            if (a % 2 == 0)
            {
                result+=a;
            }
        }
        return result;
    }
}