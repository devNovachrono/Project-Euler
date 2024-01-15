public class p1
{
    public static int id = 1;
    public static string title = "Multiples of 3 or 5";
    public static int run()
    {
        int result = 0;
        for (int i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                result += i;
            }
        }
        return result;
    }
}