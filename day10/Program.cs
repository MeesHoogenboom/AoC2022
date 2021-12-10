static class Day10
{
    static void Day10_1()
    {
        string[] input = System.IO.File.ReadAllLines(@"C:\Users\ncim\source\repos\AoC\Day10\testdata");

        int points = 0;

        foreach (string line in input)
        {
            Stack<char> ts = new Stack<char>();
            bool Corrupted = false;

            for (int i = 0; i < line.Length; i++)
            {

                if (i > 0)
                {
                    switch (line[i])
                    {
                        case ')':
                            if (ts.Peek() == '(')
                            {
                                ts.Pop();
                            } else if (!Corrupted)
                            {
                                points += 3;
                                Corrupted = true;
                            }
                            break;
                        case ']':
                            if (ts.Peek() == '[')
                            {
                                ts.Pop();
                            } else if (!Corrupted)
                            {
                                points += 57;
                                Corrupted = true;
                            }
                            break;
                        case '}':
                            if (ts.Peek() == '{')
                            {
                                ts.Pop();
                            } else if (!Corrupted)
                            {
                                points += 1197;
                                Corrupted = true;
                            }
                            break;
                        case '>':
                            if (ts.Peek() == '<')
                            {
                                ts.Pop();
                            } else if (!Corrupted)
                            {
                                points += 25137;
                                Corrupted = true;
                            }
                            break;
                        default:
                            ts.Push(line[i]);
                            break;
                    }
                } else if (i == 0)
                {
                    ts.Push(line[i]);
                }
            }

            
        }
        Console.WriteLine(points);
    }

    static void Day10_2()
    {
        string[] input = System.IO.File.ReadAllLines(@"C:\Users\ncim\source\repos\AoC\Day10\testdata");
        List<long> PointsList = new List<long>();


        foreach (string line in input)
        {
            Stack<char> ts = new Stack<char>();
            bool Corrupted = false;

            for (int i = 0; i < line.Length; i++)
            {
                if (i > 0)
                {
                    switch (line[i])
                    {
                        case ')':
                            if (ts.Peek() == '(')
                            {
                                ts.Pop();
                            }
                            else if (!Corrupted)
                            {

                                Corrupted = true;
                            }
                            break;
                        case ']':
                            if (ts.Peek() == '[')
                            {
                                ts.Pop();
                            }
                            else if (!Corrupted)
                            {
                                Corrupted = true;
                            }
                            break;
                        case '}':
                            if (ts.Peek() == '{')
                            {
                                ts.Pop();
                            }
                            else if (!Corrupted)
                            {
                                Corrupted = true;
                            }
                            break;
                        case '>':
                            if (ts.Peek() == '<')
                            {
                                ts.Pop();
                            }
                            else if (!Corrupted)
                            {
                                Corrupted = true;
                            }
                            break;
                        default:
                            ts.Push(line[i]);
                            break;
                    }
                }
                else if (i == 0)
                {
                    ts.Push(line[i]);
                }
            }

            
            if (!Corrupted)
            {
                long points = 0;
                

                foreach (char bracket in ts)
                {
                    switch (bracket)
                    {
                        case '(':
                            points = points * 5 + 1;
                            break;
                        case '[':
                            points = points * 5 + 2;
                            break;
                        case '{':
                            points = points * 5 + 3;
                            break;
                        case '<':
                            points = points * 5 + 4;
                            break;

                    }

                }
                PointsList.Add(points);

            }


        }
        PointsList.Sort();

        int median = ((PointsList.Count()) - 1) / 2;
        Console.WriteLine($"Total values in PointsList = {PointsList.Count()} with { PointsList[median]} as median (index {median})");
    }

    static void Main()
    {
        Day10_2();
    }
}
