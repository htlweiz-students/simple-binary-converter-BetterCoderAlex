using binary_converter;

namespace programm00{
    public class Binary_Main{
        public static int Main(string[] args){
            Converter binary_to_decimal = new();
            binary_to_decimal.Convert_to_decimal();

            Converter decimal_to_binary = new();
            decimal_to_binary.Convert_to_binary();
            return 0;
        }
    }
}