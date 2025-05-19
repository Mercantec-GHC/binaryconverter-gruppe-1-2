using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class BinaryToDecimal
    {
        public static void Run()
        {
            Console.WriteLine("Binary to Decimal Converter"); //it writes a text in the console  
            int[] decital = { 128, 64, 32, 16, 8, 4, 2, 1 }; // Array og decimal numberes to be converted to binary 
            int[] bintal = { 1, 0 }; //define the int "bintal" which make it binary 
            Console.Write("Enter a binary number: "); //den skriver en text i console 
            List<int> decimals = new List<int>();// laver en ny lister som bliver kaldt decimals? 
            while (decimals.Count < 4) //stareten på en loop (den fortæller decimals skal tælle max fire) 
            {

                string binary = Console.ReadLine();
                int number1 = ConvertBinaryToDecimal(binary, decital); // int converting the binary to decimals
                if (number1 == -1) // if statement that tells the user that they made a mistake and the program will go one step back :D
                {
                    Console.Write("Try again please");
                }
                else
                {
                    decimals.Add(number1);
                }
            }

            {
                Console.WriteLine($"Her er din IP-Adresse: {decimals[0]}.{decimals[1]}.{decimals[2]}.{decimals[3]}"); // gives useer an ip adreesse (gives user the answer) and becuase we are fancy there is dots between the decimal int. 

            }
        }





        public static int ConvertBinaryToDecimal(string binary, int[] decital)
        {
            int number = 0; //they give int "number" the value 0

            if (binary.Length != 8) // if binary is not 8 then it will write Console.WriteLine on line 50 :D
            {
                Console.WriteLine("Den indtastede værdi er ikke et binærtal"); //gives error text when you fail (sucker) 
                return -1;
            }
            if (!Binær(binary)) //it checkes if its 0 or 1 that is getting used (binary) 
            {
                return -1;
            }
            if (decital.Length < 256) //if decital its more then 256 it will fail and if its 256 it Continues to for statement. 
            {
                //Console.WriteLine("You made a mistake. Try again");
            }
            for (int i = 0; i < 8; i++) // Making a forloop from 0 index to 7th index.
            {
                number += decital[i] * (binary[i] - '0'); // Decital multiplied by Binary and then "number" is = to decital and binary multiplied then plus the results together
            }
            return number;
        }

        private static bool Binær(string tekst)
        {
            for (int l = 0; l < tekst.Length; l++) //error Handeling. checks that the input from the user is obeying the rules of Binary (0's and 1's)
            {
                if (tekst[l] != '0' && tekst[l] != '1')
                {
                    return false; //if does not obey the rules, it will return one step. 
                }

            }
            return true;
        }

        /*  Console.WriteLine($"Summen er: {number}");
          return number; */



    }

}

