using System;

namespace Lesson_07
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Set console properties
                Console.Title = "Anton Bielov Lesson 07 part 1";
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();

                //init Wehicles
                Wehicle Ferrary = new Wehicle();
                Wehicle Zapor = new Wehicle("Yellow", 66, 20, false, true);
                Wehicle Honda = new Wehicle("White", 200);
                Wehicle Lada = new Wehicle("Violet", 90, 60, false, false);
                Wehicle Tesla = new Wehicle("Navi Blue", 100);

                Wehicle[] car = new Wehicle[5];
                car[0] = Ferrary;
                car[1] = Tesla;
                car[2] = Honda;
                car[3] = Lada;
                car[4] = Zapor;

                BubSorter<Wehicle> CarSorter = new BubSorter<Wehicle>();
                CarSorter.inputArray = car;
                Wehicle[] sortedCars = CarSorter.Sort();
                CarSorter.Print();// sortedCars);
                Console.WriteLine("Sorted by bubble, press any  key to continue");
                Console.ReadKey(false);
                Console.WriteLine("Now sorting by insertion");

                 //Reorder wehicles
                car[1] = Ferrary;
                car[3] = Tesla;
                car[0] = Honda;
                car[2] = Lada;
                car[4] = Zapor;

                insSorter<Wehicle> CarInSorter = new insSorter<Wehicle>();
                CarInSorter.inputArray = car;
                sortedCars = CarInSorter.Sort();
                CarInSorter.Print();

                Console.ReadKey(false);
            }
        }
    }
}