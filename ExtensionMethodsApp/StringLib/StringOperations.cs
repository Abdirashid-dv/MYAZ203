namespace StringLib;

public static class StringOperations
{

    public static int NumOfSpaces(this string expressions)
    {
        int n = 0;

        foreach (char c in expressions)
        {
            if (c.Equals(' '))
            {
                n += 1;
            }
        }

        return n;
    }

}
