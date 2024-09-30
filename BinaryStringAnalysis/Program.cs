using System;

public class BinaryStringEvaluator
{
    public static bool IsGoodBinaryString(string binaryString)
    {
        int count0 = 0;
        int count1 = 0;

        foreach (char c in binaryString)
        {
            if (c == '0')
            {
                count0++;
            }
            else if (c == '1')
            {
                count1++;
            }
            else
            {
                throw new ArgumentException("Input string only need to contain '0' and '1'.");
            }

            
            if (count1 < count0)
            {
                return false; 
            }
        }

       
        return count0 == count1;
    }

    public static void Main(string[] args)
    {
        
        string[] Example = { "1100", "1010", "1001", "111000", "0101", "0011", "110011", "11100000" };

        foreach (var test in Example)
        {
            Console.WriteLine($"Is '{test}' a good binary string? => {IsGoodBinaryString(test)}");
        }
    }
}
