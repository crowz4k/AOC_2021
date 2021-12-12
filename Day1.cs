namespace AOC_2021
{
    public class Day1
    {

        public static async Task Part1()
        {
            var fileLines = await File.ReadAllLinesAsync("./input_1.txt");

            var prefValue = int.Parse(fileLines[0]);
            var counter = 0;

            foreach (var input_n in fileLines)
            {
                var val = int.Parse(input_n);

                if (val > prefValue)
                {
                    counter++;
                }

                prefValue = val;
            }

            Console.WriteLine($"Counter -> {counter}");
        }


        public static async Task Part2()
        {
            var fileLines = await File.ReadAllLinesAsync("./input_1.txt");

            var s_l = 3;

            var currentSum = int.MaxValue;
            var counter = 0;

            for (var i = 0; i < fileLines.Length; i++)
            {
                var tempSum = 0;

                for (var j = i; j < (i + s_l) && (i + s_l <= fileLines.Length); j++)
                {
                    tempSum += int.Parse(fileLines[j]);
                }

                if (tempSum > currentSum) counter++;

                currentSum = tempSum;
            }

            Console.WriteLine($"Counter -> {counter}");
        }
    }
}
