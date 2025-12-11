using binary_converter;

namespace programm00{
    public class Binary_Main{
        public static int Main(string[] args){
            int[] array = {9, 1, 5, 6, 2, 6, 1};
            Converter sort = new();
            sort.Bubble_sort(array);
            for(int i = 0; i<array.Length; i++){
                System.Console.WriteLine(array[i]);
            }
            Converter binary_to_decimal = new();
            binary_to_decimal.Convert_to_decimal();

            Converter decimal_to_binary = new();
            decimal_to_binary.Convert_to_binary();
            return 0;
        }
    }
}