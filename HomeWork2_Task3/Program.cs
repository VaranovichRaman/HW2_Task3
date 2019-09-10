using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hi, I'm the smartest program! What's your name human?");

            string playersName = Console.ReadLine();

            Console.WriteLine($@"So {playersName}, let's check if you can outwit me! Guess the number
from 1 to 100, just don’t say it out loud! I will guess it in a maximum of 7 attempts, but you will speak
after each attempt, my number is more or less than yours. Let's start!");

            while (true)
            {
                int counter = 0;
                int startNumber = 64;
                int step = 32;
                bool flag = true;

                while (flag)
                {

                    Console.WriteLine($"\nYour number { startNumber}?(type \"=\" if it is your number, \"<\" if your number is less, \">\" if your number is more)\n");
                    string answer = Console.ReadLine();
                    if (answer == "=")
                    {
                        Console.WriteLine($"I'm the smartest program in the world!!!");

                        while (flag)
                        {
                            Console.WriteLine($"You wanna try again? (type y or n):");

                            string repeat = Console.ReadLine().ToLower();

                            if (repeat == "y")
                            {
                                Console.Clear();

                                Console.WriteLine($"Great! Let's start again, {playersName}!");

                                flag = false;
                            }
                            else if (repeat == "n")
                            {

                                Console.WriteLine($"It's a pity. See you next time.");

                                Console.ReadLine();

                                return;

                            }
                            else
                            {

                                Console.WriteLine($"I don't understand you!");

                            }

                        }

                    }
                    else if (answer == "<")
                    {

                        startNumber = startNumber - step;

                        step = step / 2;

                    }
                    else if (answer == ">")
                    {

                        startNumber = startNumber + step;

                        step = step / 2;

                        if (startNumber > 100)
                        {

                            startNumber = 100;

                        }

                    }
                    else
                    {

                        Console.WriteLine($"Wrong answer!!! Please type \"=\" if it is your number, \"<\" if your number is less, \">\" if your number is more)\n");

                        counter--;
                    }

                    counter++;

                    if (counter == 7)
                    {

                        Console.WriteLine($"You are a cheater!!! I don’t want to play with you anymore.");

                        Console.ReadLine();

                        return;

                    }
                }
            }
        }
    }
}
