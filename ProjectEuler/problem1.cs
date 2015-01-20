using System.IO;
using System;

class Program
{
    static void Main()
    {
        //Sum of multiples of 3 and 5 between 0 and 1000
        int[] multiples = new int[]{3,5};
        int bounds = 1000;
        int result = 0;
        
        for(int i = 0; i < bounds; i++)
        {
            if(IsMultipleOf(multiples, i))
            {
                result += i;
            }
        }
        
        Console.WriteLine(result.ToString());
    }
    
    public static bool IsMultipleOf(int[] multiples, int value)
    {
        foreach(var multiple in multiples)
        {
            if (value % multiple == 0)
            {
                return true;
            }
        }
        
        return false;
    }
}
