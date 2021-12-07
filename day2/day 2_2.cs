class day2_2
{
    static void Main()
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ncim\source\repos\AoC\day2\data");

        int horizontal = 0;
        int depth = 0;
        int aim = 0;

        foreach (string line in lines)
        {
            string[] bearing = line.Split(' ');

            string direction = bearing[0];
            int distance = Int32.Parse(bearing[1]);

            switch (direction)
            {
                case "forward":
                    horizontal += distance;
                    depth += aim * distance;
                    break;

                case "down":
                    aim += distance;
                    break;

                case "up":
                    aim -= distance;
                    break;

                default:
                    break;
            }
        }
        int position = depth * horizontal;
        Console.WriteLine(position);
    }
}