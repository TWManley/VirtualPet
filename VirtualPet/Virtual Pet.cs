using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class virtualpet
    {   //fields
        //
        public string petsName;
        public string petType;
        public int hunger;
        public int thirst;
        public int releive;
        public int energyLevel;
        public int needs;


        //constructor
        public virtualpet()

        {


        }
        
        //loaded constructor
        public virtualpet( string petType, string petsName)
        {
            
            this.petType = petType;
            this.petsName = petsName;

        }
        public virtualpet(int hunger, int thirst, int releive, int energyLevel, int needs)
        {
            this.hunger = hunger;
            this.thirst = thirst;
            this.releive = releive;
            this.energyLevel = energyLevel;
            this.needs = needs;

        }
        public string userInput
        {
            get { return this.userInput; }
            set { this.userInput = value; }

        }
        public void feed()
        {
            this.hunger = 0;
            Console.WriteLine("you have fed your pet");
        }
        public void water()
        {
            this.thirst = 0;
            Console.WriteLine("you have given your pet water");
        }
        public void takeout()
        {
            this.releive = 0;
            Console.WriteLine("you have taken you pet out!!!");
        }
        public void train()
        {
            this.hunger = -5;
            this.energyLevel = +5;
            Console.WriteLine("you have played with the virtualpet but you have also made it hungry");

        }
        public void fulfill()
        {
            this.needs = +10;
            Console.WriteLine("you helped the pet fulfill their needs");
            
        }
        
        public void status()//this is used to create the random generation of needs for the pet
        {
            Random randomGen = new Random();
            int randomHunger = randomGen.Next(1, 11);
            int randomThirst = randomGen.Next(1, 11);
            int randomReleive = randomGen.Next(1, 11);
            int randomEnergyLevel = randomGen.Next(1, 11);
            int randomNeeds = randomGen.Next(1, 11);
            this.needs += randomNeeds;
            this.energyLevel += randomEnergyLevel;
            this.hunger += randomHunger;
            this.thirst += randomThirst;
            Console.WriteLine("Current needs are {0} the current energy level is {1}current hunger level is {2} the level of thirst is{3} the need for releif is {4}  ", this.needs, this.energyLevel, this.hunger,
            this.thirst, this.releive);

        }
        
        
            
            public void Hunger() 
        {
            if (hunger < 10)
            {
                Console.WriteLine("Would you like to feed your pet?");

            }
        }
    }
}
