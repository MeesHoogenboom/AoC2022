static class Day6
{
    static void Day6_1()
    {
        int days = 80;

        string[] input = System.IO.File.ReadAllLines(@"C:\Users\ncim\source\repos\AoC\Day6\data");

        List<string> values = new List<string>(input[0].Split(','));

        List<int> list = values.Select(int.Parse).ToList();
        List<int> NewList = new List<int>(list);

        for (int i = 0; i < days; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                NewList[j] = list[j];

                if (list[j] == 0)
                {
                    NewList.Add(8);
                    NewList[j] = 6;
                }
                else
                {
                    NewList[j]--;
                }
            }
            list = new List<int>(NewList);
            Console.WriteLine("On day "+ (i+1) + " there are "+ list.Count + " fish");   
        }
        Console.WriteLine("\nTotal amount of fish = "+list.Count);
    }

    static void Day6_2()
    {
        int days = 256;

        string[] input = System.IO.File.ReadAllLines(@"C:\Users\ncim\source\repos\AoC\Day6\testdata");
        List<string> values = new List<string>(input[0].Split(','));
        List<int> list = values.Select(int.Parse).ToList();
        int fish;

        for (int i = 0;i < days; i++)
        {

        }

    }

    static void Main()
    {
        Day6_1();
    }
}

