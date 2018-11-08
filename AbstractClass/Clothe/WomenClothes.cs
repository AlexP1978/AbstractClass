using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Clothe
{
    public class WomenClothes : Clothes
    {
        private string type;
        private string color;
        private string [] size = {"S", "M", "L", "XL", "XXL"};
        private int idx;
        private string sex;
        private int age;
        private double height;


        public override string Type
        {
            get { return type; }
            set { type = value; }
        }
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
        public string Size => size[idx];
       
        public override double Height
        {
            get { return height; }
            set { height = value; }
        }

        public WomenClothes(string type, string color, string sex, int age, double height)
        {
            Type = type;
            Color = color;
            Sex = sex;
            Age = age;
            Height = height;
        }

        /// <summary>
        /// image information about clothe
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"{Type} clothes.\nColor is {Color}.\n{Sex} clothes.\nClothes for > {Age} years.");
        }

        /// <summary>
        /// defenition of size
        /// </summary>
        public override string SizeOfClothes(double chest_girth, double waist_girth, double hip_girth)
        {

            if (height < 164 && (chest_girth >= 88 && chest_girth < 92) && (waist_girth >= 67 && waist_girth < 72)
                && (hip_girth >= 96 && hip_girth < 100))
                idx = 0;
            else if ((164 <= height && height < 170) && (chest_girth >= 92 && chest_girth < 100) && (waist_girth >= 72 && waist_girth < 80)
                && (hip_girth >= 100 && hip_girth < 108))
                idx = 1;
            else if ((170 <= height && height < 176) && (chest_girth >= 100 && chest_girth < 108) && (waist_girth >= 80 && waist_girth < 89)
                && (hip_girth >= 108 && hip_girth < 120))
                idx = 2;
            else if ((176 <= height && height < 182) && (chest_girth >= 108 && chest_girth < 117) && (waist_girth >= 89 && waist_girth < 99)
                && (hip_girth >= 116 && hip_girth < 124))
                idx = 3;
            else if (height > 182 && chest_girth == 117 && waist_girth == 99 && hip_girth == 124)
                idx = 4;

            return Size;
        }

    }
}
