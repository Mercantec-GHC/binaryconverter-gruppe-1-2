using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class BinaryToDecimal
    {
        public static void Run()
        {
            Console.WriteLine("Binary to Decimal Converter");
            int[] decital = { 128, 64, 32, 16, 8, 4, 2, 1 };
            int[] bintal = { 1, 0 };
            Console.Write("Enter a binary number: ");
            List<int> decimals = new List<int>();
            while (decimals.Count < 4)
            {

                string binary = Console.ReadLine();
                int number1 = ConvertBinaryToDecimal(binary, decital);
                if (number1 == -1)
                {

                }
                else
                {
                    decimals.Add(number1);
                }
            }
           
            {
            Console.WriteLine($"Her er din IP-Adresse: {decimals[0]}.{decimals[1]}.{decimals[2]}.{decimals[3]}");

            }
            }





        public static int ConvertBinaryToDecimal(string binary, int[] decital)
        {
            int number = 0;

            if (binary.Length != 8)
            {
                Console.WriteLine("Den indtastede værdi er ikke et binærtal");
                return -1;
            }
            if (Binær(binary))
            {
                return -1;
            }
            if (decital.Length < 256)
            {

            }
            for (int i = 0; i < 8; i++)
            {
                number += decital[i] * (binary[i] - '0');
            }
            return number;
        }
           
        private static bool Binær (string tekst)
        {
            for (int l = 0; l < tekst.Length; l++)
            {
                if (tekst[l] != '0' && tekst[l] != '1')
                {
                    return false;
                }
                
            }
            return true;
        }

          /*  Console.WriteLine($"Summen er: {number}");
            return number; */
            


        }

    }

