using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {

        static void Main(string[] args)
        {
            
            





                virtualpet virtualpet = new virtualpet();


                string textToEnter = "Welcome to Virtual Pet ";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));




                Console.WriteLine("What type of pet do you want options include Phaserbeast,RazorBeast,Goldfish");
                string pettype = Console.ReadLine();
                Console.ReadLine().ToLower();

                if


                    (pettype == "PhaserBeast")
                    Console.WriteLine("You are the proud owner of a PhaserBeast");

                else if

                    (pettype == "LaserBeast")
                    Console.WriteLine("You are the proud owner of a LaserBeast");

                else if

                    (pettype == "Goldfish")
                    Console.WriteLine("You got a gold fish");


                Console.WriteLine("What is your new pets name?");

                Console.ReadLine();

                Console.WriteLine("What would you like to do options include status,feed,water,takeout,train,fulfill");
                string userInput = Console.ReadLine();
                if (userInput == "status")
                {
                    virtualpet.status();
                }
                else if (userInput == "feed")
                {
                    virtualpet.feed();
                }
                else if (userInput == "water")
                {
                    virtualpet.water();
                }
                else if (userInput == "takeout")
                {
                    virtualpet.takeout();

                }
                else if (userInput == "train")
                {
                    virtualpet.train();
                }
                Console.WriteLine("What would you like to do next?");
                userInput = Console.ReadLine();
                
                
                

                
            
            
























        }   
    }
}
