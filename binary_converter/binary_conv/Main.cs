using binary_conv;

namespace programm00{
    public class Binary_Main{
        public static int Main(string[] args){
            Converter number = new Converter("1100");
            if (Converter.check_if_correct_input()){
                System.Console.WriteLine("Is binary");
            }
            else{
                System.Console.WriteLine("isnt binary");
            }
            return 0;
        }
    }
}