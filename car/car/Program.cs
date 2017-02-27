using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // olio on luokan instanssi/ilmentymä/toteutus/
            var carClass = new CarClass("Volvo"); // constructorissa parametrissa mukana, joten asettaa volvoksi tässä
            // carClass.Brand = "Honda"; // setillä asettaa uuden arvon. mutta ei enää mahdollista.
            Console.WriteLine("Brand: " + carClass.Brand); // kutsuu get funktioa. jos halutaan käyttää set niin yllä
            Console.WriteLine("Default speed: " + carClass.Speed);
            // carClass.Speed = 100; muutttui readonlyksi eikä toimi enää
            carClass.Accelerate(20);
            carClass.Accelerate(10);
            Console.WriteLine("New speed: " + carClass.Speed);
            carClass.Break();
            Console.WriteLine("Speed after break: " + carClass.Speed);
            Console.WriteLine(carClass); // käyttää automaattisesti tostringia ilman erillistä kutsua
            Console.ReadKey();
        }
    }
}
