using System;
using System.Collections.Generic;
using System.Threading;
namespace roshambo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> StandardConditions = new Dictionary<String, int>()
            {
                ["0"] = 2,
                ["1"] = 0,
                ["2"] = 1
            };
            Dictionary<String, string> Names = new Dictionary<String, string>()
            {
                ["0"] = "Rock",
                ["1"] = "Paper",
                ["2"] = "Scissors"
            };
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine(@"
______        _____ _                      ______       
| ___ \      /  ___| |                     | ___ \      
| |_/ /___   \ `--.| |__   __ _ _ __ ___   | |_/ / ___  
|    // _ \   `--. \ '_ \ / _` | '_ ` _ \  | ___ \/ _ \ 
| |\ \ (_) | /\__/ / | | | (_| | | | | | | | |_/ / (_) |
\_| \_\___/  \____/|_| |_|\__,_|_| |_| |_| \____/ \___/ 
                                                        
            ");
                Console.WriteLine(@"
Welcome to Ro Sham Bo
Press the corresponding key to throw:
    //=====[]==================\\
    || Key ||      Throw       ||
    |]=====[]==================[|
    ||   0 || Rock             ||
    ||   1 || Paper            ||
    ||   2 || Scissors         ||
    \\=====[]==================//
    ");
                Random random = new Random();
                int sel = random.Next(2);



                String inp = Console.ReadLine();
                Console.WriteLine("you picked: " + Names[inp]);
                System.Console.WriteLine("computed picked: " + Names[sel.ToString()]);
                if (StandardConditions[inp] == sel)
                {
                    System.Console.WriteLine("You win!");
                    Console.Beep(130, 100);
                    Console.Beep(262, 100);
                    Console.Beep(330, 100);
                    Console.Beep(392, 100);
                    Console.Beep(523, 100);
                    Console.Beep(660, 100);
                    Console.Beep(784, 300);
                    Console.Beep(660, 300);
                    Console.Beep(146, 100);
                    Console.Beep(262, 100);
                    Console.Beep(311, 100);
                    Console.Beep(415, 100);
                    Console.Beep(523, 100);
                    Console.Beep(622, 100);
                    Console.Beep(831, 300);
                    Console.Beep(622, 300);
                    Console.Beep(155, 100);
                    Console.Beep(294, 100);
                    Console.Beep(349, 100);
                    Console.Beep(466, 100);
                    Console.Beep(588, 100);
                    Console.Beep(699, 100);
                    Console.Beep(933, 300);
                    Console.Beep(933, 100);
                    Console.Beep(933, 100);
                    Console.Beep(933, 100);
                    Console.Beep(1047, 400);
                }
                else if (inp == sel.ToString())
                {
                    System.Console.WriteLine("It's a draw!");
                    Console.Beep(392, 200); Console.Beep(392, 200); Console.Beep(392, 200);
                    Console.Beep(311, 800);
                    Console.Beep(349, 200); Console.Beep(349, 200); Console.Beep(349, 200);
                    Console.Beep(294, 800);
                }
                else
                    System.Console.WriteLine("You lose!");
                Console.Beep(987, 150); Console.Beep(1396, 300); Console.Beep(1396, 150);
                Console.Beep(1396, 200); Console.Beep(1318, 200); Console.Beep(1174, 200);
                Console.Beep(1046, 150); Console.Beep(659, 150); Console.Beep(391, 150); Console.Beep(659, 150);
                Console.Beep(523, 600);
                {
                }






                // running = false;
            }



        }
    }
}



