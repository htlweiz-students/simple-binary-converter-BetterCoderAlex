using System.Numerics;

namespace binary_conv{
    public class Converter{
        private string[] possible_input ={"0", "1"};
        private string Binary_input;
        public Converter(string binary_number){
            Binary_input = binary_number;
        }

        public void check_if_correct_input(){
            for (int count = 0; count<Binary_input.Length; count++){
                if (Binary_input != "1"|| Binary_input != "0"){
                    Console.WriteLine($"Error: incorrect input in {Binary_input}");
                }
            }
        }

    }
}