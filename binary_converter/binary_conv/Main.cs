using binary_conv;

namespace programm00{
    public class Binary_Main{
        public static int Main(string[] args){
            Converter binary_to_decimal = new();
            binary_to_decimal.convert_to_decimal();
            return 0;
        }
    }
}