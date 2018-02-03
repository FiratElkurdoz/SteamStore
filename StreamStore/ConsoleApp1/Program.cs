using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.AddNewGame("Night in the Woods", 15, 0);
            store.AddNewGame("The Longest Journey", 9.9f, 1);
            store.AddNewGame("Breath of the wild", 60, 2);
            store.AddNewGame("The Witcher 3", 50, 3);
            store.showcase.PrintGamesOnDisplay();
            //Console.ReadLine();

            //input loop
            while (true)
            {
                Console.WriteLine("Insert command (print/add/buy/quit)");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "print":
                        store.showcase.PrintGamesOnDisplay();
                        break;

                    case "add":
                        Console.WriteLine("Insert name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Insert price");
                        float price = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Insert position in showcase");
                        int position = Convert.ToInt32(Console.ReadLine());
                        //should include some checks to be sure that the user can't input wrong values
                        store.AddNewGame(name, price, position);
                        break;

                    case "buy":
                        Console.WriteLine("Which game do you want to buy? [Insert number]");
                        store.showcase.PrintGamesOnDisplay();
                        int index = Convert.ToInt32(Console.ReadLine());
                        if (index >= 0 && index < store.showcase.NumberOfSpots())
                            store.SellGame(index);
                        else
                            Console.WriteLine("Error: invalid index");
                        break;

                    case "quit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Error: command not recognised: " + command);
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
