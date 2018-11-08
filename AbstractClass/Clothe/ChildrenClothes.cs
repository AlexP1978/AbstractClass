using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Clothe
{
    public abstract class ChildrenClothes : Clothes
    {

        public abstract string SizeOfClothesChild(double height, double weight, double year);
    }
}
