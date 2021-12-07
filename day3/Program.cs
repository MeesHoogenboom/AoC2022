class day3
{
    static void day3_1()
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ncim\source\repos\AoC\day3\data");

        int[] gammaArray = new int[12] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int[] epsilonArray = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


        foreach (string line in lines)
        {
            int i = 0;

            foreach (char value in line)
            {

                switch (value)
                {
                    case '0':
                        gammaArray[i]--;
                        epsilonArray[i]++;

                        break;
                    case '1':
                        gammaArray[i]++;
                        epsilonArray[i]--;
                        break;
                }
                i++;
            }
        }

        for (int i = 0; i < 12; i++)
        {
            if (gammaArray[i] > 0)
            {
                gammaArray[i] = 1;
            } else if (gammaArray[i] < 0)
            {
                gammaArray[i] = 0;
            }

            if (epsilonArray[i] > 0)
            {
                epsilonArray[i] = 1;
            }
            else if (epsilonArray[i] < 0)
            {
                epsilonArray[i] = 0;
            }

            
        }
        int gamma = Convert.ToInt32(string.Join("", gammaArray), 2);
        int epsilon = Convert.ToInt32(string.Join("", epsilonArray), 2);

        int powerConsumption = gamma * epsilon;

        Console.WriteLine("Power consumption = gamma * epsilon =  " + gamma + " * "+ epsilon+ " = " + powerConsumption);

    }

    static void day3_2()
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ncim\source\repos\AoC\day3\data");

        int[] gammaArray = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] epsilonArray = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        

        foreach (string line in lines)
        {
            int i = 0;

            foreach (char value in line)
            {

                switch (value)
                {
                    case '0':
                        gammaArray[i]--;
                        epsilonArray[i]++;

                        break;
                    case '1':
                        gammaArray[i]++;
                        epsilonArray[i]--;
                        break;
                }
                i++;
            }
        }

        for (int i = 0; i < 12; i++)
        {
            if (gammaArray[i] > 0)
            {
                gammaArray[i] = 1;
            }
            else
            {
                gammaArray[i] = 0;
            }

            if (epsilonArray[i] > 0)
            {
                epsilonArray[i] = 1;
            }
            else
            {
                epsilonArray[i] = 0;
            }

        

        }
        int gamma = Convert.ToInt32(string.Join("", gammaArray), 2);
        int epsilon = Convert.ToInt32(string.Join("", epsilonArray), 2);

        int powerConsumption = gamma * epsilon;

        Console.WriteLine("Power consumption = gamma * epsilon =  " + gamma + " * " + epsilon + " = " + powerConsumption);

    }

    static void Main()
    {
        day3_1();
    }
}