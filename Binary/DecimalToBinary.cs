using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BinaryConverter
{
    public static class DecimalToBinary
    {
        public static void Run()
        {
            Console.WriteLine("Decimal to Binary Converter");
            string randomnumber = Console.ReadLine();

            Console.WriteLine("Enter decimal here: ");
            string[] oktetter = randomnumber.Split('.'); // Opdeler oktetter med et ".".
            Console.Write(ConvertDecimalToBinary(int.Parse(oktetter[0]))); //Outputs "oktteter" and converts string to integer
            Console.Write("."); // Splits oktteter with a "."
            Console.Write(ConvertDecimalToBinary(int.Parse(oktetter[1])));
            Console.Write(".");
            Console.Write(ConvertDecimalToBinary(int.Parse(oktetter[2])));
            Console.Write(".");
            Console.Write(ConvertDecimalToBinary(int.Parse(oktetter[3])));

        }

        public static string ConvertDecimalToBinary(int decimalIP)
        {
            string binarycontainer = ""; //An empty string to contain a binary number 


            int[] decimaltal = { 128, 64, 32, 16, 8, 4, 2, 1 }; //Array of decimal numbers to be converted to binary


            for (int i = 0; i < decimaltal.Length; i++) // the loop starts with i  set to 0 and runs until i is less than the length of the array,
                                                        // After each loop iteration, i is increased by 1
            {

            if (decimaltal[i]<= decimalIP) //cheks if the decimal number is less than or equal to the decimalIP
                {
                decimalIP -= decimaltal[i]; //If the condition is true, the decimalIP is decrease by the value of the current element in the array
                    binarycontainer = binarycontainer + "1"; //If conditions are met binarycontainer + 1
            }
            else
            {
                binarycontainer = binarycontainer + "0"; // If conditions are not met, it will post 0
            }

                 
            }
            return binarycontainer;




        }
    }
}
