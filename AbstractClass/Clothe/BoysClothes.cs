using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Clothe
{
    public class BoysClothes : ChildrenClothes
    {

        private string[] size = { "56", "62", "66", "70", "78" };
        private int idx;

        public string Size => size[idx];
        private string sex;
        private int age;
        private double height;
        private string type;
        private string color;

        public override string Color
        {
            get { return color; }
            set { color = value; }
        }
        public override string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public override int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override double Height
        {
            get { return height; }
            set { height = value; }
        }



        public override string Type
        {
            get { return type; }
            set { type = value; }
        }

        public BoysClothes(string type, string color, string sex, int age, double height)
        {
            Type = type;
            Color = color;
            Sex = sex;
            Age = age;
            Height = height;
        }

        public override string SizeOfClothes(double chest_girth, double waist_girth, double hip_girth)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// image information about clothe
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"{Type} clothes.\nColor is {Color}.\n{Sex} clothes.\nClothes for = {Age} years.");
        }

        public override string SizeOfClothesChild(double height, double weight, double year)
        {



            return Size;
        }
    }
}
