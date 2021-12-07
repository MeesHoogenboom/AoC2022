class day2_1
{
    static void NotMain()
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ncim\source\repos\AoC\day2\data");

        string direction;
        int distance = 0;
        int horizontal = 0;
        int depth = 0;

        foreach (string line in lines)
        {
            string[] bearing = line.Split(' ');

            direction = bearing[0];
            distance = Int32.Parse(bearing[1]);

            switch (direction)
            {
                case "forward":
                    horizontal += distance;
                    break;

                case "down":
                    depth += distance;
                    break;

                case "up":
                    depth -= distance;
                    break;

                default:
                    break;
            }
        }
        int position = depth * horizontal;
        Console.WriteLine(position);
    }
}