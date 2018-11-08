using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Clothe
{
    public abstract class Clothes
    {
        public abstract string Type { get; set;}
        public abstract string Color { get; set; }
        public abstract string Sex { get; set; }
        public abstract int Age { get; set;}
        public abstract double Height { get; set; }

        /// <summary>
        /// image information about clothe
        /// </summary>
        public virtual void Display() { }

        /// <summary>
        /// defenition of size
        /// </summary>
        public abstract string SizeOfClothes(double chest_girth, double waist_girth, double hip_girth);


    }
}
