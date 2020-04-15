using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Vertex
    {
        public double Yvalue_ { get; set; }
        public double Xvalue_ { get; set; }

        public Vertex(double Yvalue, double Xvalue)
        {
            Yvalue_ = Yvalue;
            Xvalue_ = Xvalue;
        }
    }
}
