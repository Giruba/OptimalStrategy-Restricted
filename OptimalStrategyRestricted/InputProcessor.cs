using System;
using System.Collections.Generic;
using System.Text;

namespace OptimalStrategyRestricted
{
    class InputProcessor
    {
        public static int[] GetArrayFromInput() {
            Console.WriteLine("Enter the number of elements in the array");
            int[] array = null;
            try{
                int sizeOfArray = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space, " +
                    "comma or semi-colon");
                String[] elements = Console.ReadLine().Split(' ',',',';');
                array = new int[sizeOfArray];
                for (int index = 0; index < sizeOfArray; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return array;
        }

        public static int GetWinnerAmount(int[] array) {
            int[,] table = new int[array.Length, array.Length];

            for (int index = 0; index < array.Length; index++) {
                for (int startIndex = 0, endIndex = index; endIndex < array.Length;
                    startIndex++, endIndex++) {
                    //Winner takes startIndex, rest of min left by opponent will be Min{startIndex+2, endIndex}
                    if (startIndex + 2 < endIndex)
                    {
                        table[startIndex, endIndex] = array[startIndex] + table[startIndex + 2, endIndex];
                    }
                    else {
                        table[startIndex, endIndex] = array[startIndex];
                    }
                    
                }
            }

            return table[0, array.Length - 1];
        }
    }
}
