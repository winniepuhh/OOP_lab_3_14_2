using System;
using System.IO;

namespace OOP_lab_3_14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sport = new StreamReader("D:/sport.txt");

            string results = sport.ReadToEnd();

            sport.Close();

            StreamWriter sportNew = new StreamWriter("D:/sport.txt", true);

            Console.Write("Iм'я голови журi: ");

            sportNew.Write("\nIм'я голови журi: {0}", Console.ReadLine());

            sportNew.Close();
        }
    }
}
