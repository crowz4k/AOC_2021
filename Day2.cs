namespace AOC_2021
{
    public class Day2
    {
        public static async Task Part1()
        {
            var lines = await File.ReadAllLinesAsync("./input_2.txt");

            var h_p = 0;
            var v_p = 0;

            foreach (var line in lines)
            {
                var parsedLine = line.Split(" ");
                var (command, value) = (Enum.Parse<Position>(parsedLine[0]), int.Parse(parsedLine[1]));


                switch (command)
                {
                    case Position.forward:
                        v_p += value;
                        break;
                    case Position.down:
                        h_p += value;
                        break;
                    case Position.up:
                        h_p -= value;
                        break;
                }
            }


            Console.WriteLine($"Horizontal position is -> {h_p}");
            Console.WriteLine($"Vertical position is -> {v_p}");
            Console.WriteLine($"Solution -> {h_p * v_p}");
            Console.ReadKey();
        }


        public static async Task Part2()
        {
            var lines = await File.ReadAllLinesAsync("./input_2.txt");

            var h_p = 0;
            var v_p = 0;
            var aim = 0;

            foreach (var line in lines)
            {
                var parsedLine = line.Split(" ");
                var (command, value) = (Enum.Parse<Position>(parsedLine[0]), int.Parse(parsedLine[1]));

                switch (command)
                {
                    case Position.forward:
                        v_p += value;
                        if (aim != 0)
                        {
                            h_p += aim * value;
                        }
                        break;
                    case Position.down:
                        aim += value;
                        break;
                    case Position.up:
                        aim -= value;
                        break;
                }
            }


            Console.WriteLine($"Horizontal position is -> {h_p}");
            Console.WriteLine($"Vertical position is -> {v_p}");
            Console.WriteLine($"Solution -> {h_p * v_p}");
            Console.ReadKey();
        }
    }

    public enum Position
    {
        forward,
        down,
        up,
    }
}
