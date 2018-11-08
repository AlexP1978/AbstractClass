using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClass.Clothe;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {

            WomenClothes womenclothes = new WomenClothes("trousers","red","famele",30,172);
            womenclothes.Display();
            Console.WriteLine(womenclothes.SizeOfClothes(92,72,100));

            MenClothes menclothes = new MenClothes ("Coat","black","male",40,180 );
            menclothes.Display();

            BoysClothes boysclothes = new BoysClothes("Jacket","White","Male",3,80);
            boysclothes.Display();


            Console.Read();
        }
    }
}
