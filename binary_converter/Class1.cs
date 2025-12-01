namespace binary_converter
{
    public class Converter
    {
        string? read_console;
        int count = 0;

        public void Convert_to_decimal()
        {
            int total = 0;

            while (true)
            {
                Console.WriteLine($"binary number {count + 1} (bit {count + 1}): ");
                read_console = Console.ReadLine();

                if (read_console == "0" || read_console == "1")
                {
                    total = total * 2;
                    if (read_console == "1")
                        total++;

                    count++;
                }
                else
                {
                    Console.WriteLine($"Decimal value: {total}");
                    break;
                }
            }
        }
        public void Convert_to_binary()
        {
            int input;
            string[] arr = [];
            System.Console.WriteLine("Enter a decimal number:");
            read_console = Console.ReadLine();
            if (!int.TryParse(read_console, out input))
            {
                System.Console.WriteLine("Invalid input");
            }
            int.TryParse(read_console, out input);
            if (input == 0)
            {
                System.Console.WriteLine("Binary number: 0");
            }


            while (input > 0)
            {
                if (input % 2 == 0)
                {
                    arr = arr.Append("0").ToArray();
                }
                else
                {
                    arr = arr.Append("1").ToArray();
                }

                input = input / 2;
            }
            Array.Reverse(arr);
            System.Console.WriteLine("Binary number:");
            foreach (var bit in arr)
            {
                System.Console.Write(bit);
            }
            System.Console.WriteLine();
        }
    }
}
