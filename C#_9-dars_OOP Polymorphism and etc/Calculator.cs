using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C__9_dars_OOP_Polymorphism_and_etc
{
     public interface ICalculator<GenericType>
    {
        public GenericType  Qoshish(GenericType x, GenericType y);
        public GenericType Ayirish(GenericType x, GenericType y);
        public GenericType  Kopaytirish(GenericType x, GenericType y);
        public GenericType Bolish(GenericType x, GenericType y);
    }

    public class Hisobla<Gene> : ICalculator<Gene>
       where Gene : INumber<Gene>
    {
        public Gene Ayirish(Gene x, Gene y)
        {
            return x - y;
        }

        public Gene Bolish(Gene x, Gene y)
        {
           return y / x;
        }

        public Gene Kopaytirish(Gene x, Gene y)
        {
            return x * y;
        }

        public Gene Qoshish(Gene x, Gene y)
        {
            return x + y;
        }
    }

}
