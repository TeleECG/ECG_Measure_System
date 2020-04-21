using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Pulse_Calculator : ICalculator
    {
                        
        public double Calculate(List<double> measurements)//Denne metode skal kaldes i controller-klassen og have en liste med toppunkter som parameter
        {
            int pulsPrMin_ = measurements.Count * 6;//Hvis listen indeholder 10 sekunders data
            return pulsPrMin_;
        }
    }
}
