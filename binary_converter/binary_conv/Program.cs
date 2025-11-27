
namespace binary_conv
{
    public class Converter
    {
        bool is_it_binary = true;
        string read_console;
        int count = 0;

        public void convert_to_decimal()
        {
            int total = 0;

            while (is_it_binary == true)
            {
                Console.WriteLine($"binary number {count} (bit {count}): ");
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
                    is_it_binary = false;
                }
            }
        }
    }
}
