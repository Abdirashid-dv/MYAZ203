namespace IntLib;

public static class IntOpetation
{
    public static string UntilNumber(this int number)
    {
        string s = string.Empty;
        for (int i = 0; i < number; i++)
        {
            s += (i + 1) + " ";
        }
        return s;
    }

}
