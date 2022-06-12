using System;
using System.Collections.Generic;

namespace Laba_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Створення Зоряної системи! Введiть кiлькiсть планет, кiлькiсть супутникiв та назву зiрки через пробiли");
            string input = Console.ReadLine();
            string[] buff = input.Split(" ");
            int Planet_amount = 0, Satellite_amount = 0; string star = "";
            try
            {
                Planet_amount = Convert.ToInt32(buff[0]);
                Satellite_amount = Convert.ToInt32(buff[1]);
                star = buff[2];
            }
            catch
            {
                Console.WriteLine("Введенi не коректнi данi!");
            }
            Star star_ex = new Star(star);
            Planet planet_ex = new Planet(Planet_amount);
            Satellite satellite_ex = new Satellite(Satellite_amount);
            StarSystem starsystem_ex = new StarSystem(star_ex, planet_ex.Amount, satellite_ex.Amount);
            Console.WriteLine(starsystem_ex.ToString());
            Console.WriteLine("Перевiрка Equals!");
            Star star_test = new Star("Sun");
            Planet planet_test = new Planet(8);
            Satellite satellite_test = new Satellite(39);
            StarSystem starsystem_test = new StarSystem(star_test,planet_test.Amount,satellite_test.Amount);
            Console.WriteLine(starsystem_test.ToString());
            Console.WriteLine(starsystem_ex.Equals(starsystem_test));
            Console.WriteLine("Перевiрку завершено!");
            Console.WriteLine("Ви хочете побачити назву зiрки?(1 - так, 2 - нi)");
            input = Console.ReadLine();
            int a = 0;
            try
            {
                a = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Введенi не коректнi данi!");
            }
            if (a == 1) Console.WriteLine(starsystem_ex.Star.GetStar());
            for (int i = 0; i < 5; i++){
                Console.WriteLine("Додати планету?(1 - так, 2 - нi)");
                input = Console.ReadLine();
                try
                {
                    a = Convert.ToInt32(input);
                }
                catch
                {
                    Console.WriteLine("Введенi не коректнi данi!");
                }
                if (a == 1) {
                    planet_ex.Amount++;
                    starsystem_ex = new StarSystem(star_ex, planet_ex.Amount, satellite_ex.Amount);
                    Console.WriteLine(starsystem_ex.ToString());
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(starsystem_ex.ToString());
        }
    }
}
