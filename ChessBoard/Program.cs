using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv in ett tal");
            Console.OutputEncoding = System.Text.Encoding.Unicode;//Hanterar specialtecken

            int number;

            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0) //En while loop för att ha ett positivt heltal 
            {               
            }
            for (int row = 0; row < number; row++) //Loop som skriver ut rader
            {
                for (int col = 0; col < number; col++) //Loop som skriver ut Kollumner
                {
                    if ((row + col) % 2 == 0) //If sats
                    {
                        Console.Write("◻︎");
                    }
                    else
                    {
                        Console.Write("◼︎");
                    }
                }
                Console.WriteLine();  
            }

            Console.ReadLine();  //Håller konsolen öppen
        }
    }
}
