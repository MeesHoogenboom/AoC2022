class day1_1
{
    static void Main()
    {
        string[] strings = System.IO.File.ReadAllLines(@"C:\Users\ncim\source\repos\AoC\Day 1\data");
        int[] lines = Array.ConvertAll(strings, s => int.Parse(s));

        int counter = 0;
        int oldValue = 0;
        int increases = 0;

        foreach (int line in lines)
        {
            counter++;
            int newValue = line;

            if (counter != 1)
            {
                if (oldValue < newValue)
                {
                    increases++;
                }
                oldValue = newValue;
            }
        }
        Console.WriteLine(increases);
    }
}

