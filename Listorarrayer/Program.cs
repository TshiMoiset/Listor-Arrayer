using System;
using System.Collections.Generic;

namespace Listorarrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] emptyArray = new int[5];
            List<string> emptyList = new List<string>(5);

            emptyArray[2] = "Tesla";
            emptyList[1] = "Audi";

            Console.WriteLine(emptyArray.Length);
            // En array är bra om man ska ha t.ex. 20 fiender i en wave.
            Console.WriteLine(emptyList.Count);
            // En list är bra om man t.ex. slås mot många fiender tills att man dör. Kan vara meningen i ett spels story. 


            Console.ReadLine();
















        }
    }
}
