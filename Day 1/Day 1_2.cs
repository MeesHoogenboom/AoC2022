class day1_2
{
    static void Main()
    {
        string[] strings = System.IO.File.ReadAllLines(@"C:\Users\ncim\source\repos\Day 1\Advent of Code\data");
        int[] lines = Array.ConvertAll(strings, s => int.Parse(s));

        int newValue = 0;
        int oldValue = 0;
        int increases = 0;


        for (int i = 0; i < strings.Length; i++)
        {

            if (strings.Length - i > 3)
            {
                int value_1 = lines[i];
                int value_2 = lines[i + 1];
                int value_3 = lines[i + 2];

                newValue = value_1 + value_2 + value_3;
            }
            else
            {
                break;
            }

            if (i != 0)
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
