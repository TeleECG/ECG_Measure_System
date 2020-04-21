using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Pulse_Calculator : ICalculator
    {
        private R_peak r_peaks_;

        
        public double Calculate(List<double> measurements)
        {
            r_peaks_ = new R_peak(measurements);
            int pulsPrMin_ = measurements.Count * 6;//Hvis listen indeholder 10 sekunders data
            return pulsPrMin_;
        }
    }
}
