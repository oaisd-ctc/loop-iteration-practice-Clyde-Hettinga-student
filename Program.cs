public class Program
{
    public static void Main()
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);
        Console.WriteLine();

        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);
        Console.WriteLine();

        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);
        Console.WriteLine();

        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);
        Console.WriteLine();

        WriteEvensThrough100();
        Console.WriteLine();

        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);
        Console.WriteLine();

        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);
        Console.WriteLine();

        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);
        Console.WriteLine();

        OutputRightTriangle(4);
        OutputRightTriangle(6);
        OutputRightTriangle(-4);
        OutputRightTriangle(-6);
        OutputRightTriangle(0);
    }

    public static void Write1ThroughN_While(int n)
    {
        if (n >= 1)
        {
            int current = 1;
            while (current < n + 1)
            {
                Console.Write($"{current} ");
                current++;
            }
            Console.WriteLine();
        }
        else
            OutOfRangeMessage(n);
    }

    public static void Write1ThroughN_For(int n)
    {
        if (n >= 1)
        {
            for (int current = 1; current < n + 1; current++)
            {
                Console.Write($"{current} ");
            }
            Console.WriteLine();
        }
        else
            OutOfRangeMessage(n);
    }

    public static void WriteNThrough1_While(int n)
    {
        if (n >= 1)
        {
            int current = n;
            while (current > 0)
            {
                Console.Write($"{current} ");
                current--;
            }
            Console.WriteLine();
        }
        else
            OutOfRangeMessage(n);
    }

    public static void WriteNThrough1_For(int n)
    {
        if (n >= 1)
        {
            for (int current = n; current > 0; current--)
            {
                Console.Write($"{current} ");
            }
            Console.WriteLine();
        }
        else
            OutOfRangeMessage(n);
    }

    public static void WriteEvensThrough100()
    {
        for (int current = 1; current < 101; current++)
        {
            if (current % 2 == 0)
                Console.Write($"{current} ");
        }
        Console.WriteLine();
    }

    public static void FindSum(int n)
    {
        int sum = 0;
        
        if (n > 0)
        {
            for (int current = 1; current < n + 1; current++)
            {
                sum += current;
            }
        }
        else if (n < 0)
        {
            for (int current = n; current < 2; current++)
            {
                sum += current;
            }
        }

        Console.WriteLine(sum);
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        int sum = 0;
        
        if (n > 0)
        {
            for (int current = 1; current < n + 1; current++)
            {
                if (current % 2 == 0)
                    sum += current;
            }
        }
        else if (n < 0)
        {
            for (int current = n; current < 2; current++)
            {
                if (current % 2 == 0)
                    sum += current;
            }
        }
        
        Console.WriteLine(sum);
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int sum = 0;
        
        if (n > 0)
        {
            for (int current = 1; current < n + 1; current++)
            {
                if (current % 2 != 0)
                    sum += current;
            }
        }
        else if (n < 0)
        {
            for (int current = n; current < 2; current++)
            {
                if (current % 2 != 0)
                    sum += current;
            }
        }
        
        Console.WriteLine(sum);
    }

    public static void OutputRightTriangle(int _base)
    {
        if (_base > 0)
        {
            for (int rowLength = 1; rowLength < _base + 1; rowLength++)
            {
                for (int current = rowLength; current > 0; current--)
                    Console.Write("@");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        else if (_base < 0)
        {
            for (int rowLength = -_base; rowLength > 0; rowLength--)
            {
                for (int current = rowLength; current > 0; current--)
                    Console.Write("@");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        else
            OutOfRangeMessage(_base);
    }

    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine($"{n} is out of range.");
    }
}