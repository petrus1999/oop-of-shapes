using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_of_shapes
{
    class Shape
    {
        public string Nameofshape;
        public string Numberofsides;
        public string Properties;

        class Square : Shape
        {
            public Square(string nameofshape, string numberofsides, string properties)
            {
                Nameofshape = nameofshape;
                Numberofsides = numberofsides;
                Properties = properties;
            }
        }
    }
}
        