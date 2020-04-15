using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class HRV_Calculator : ICalculator
    {
               
        private double RRinterval_;
        private R_peak r_peaks_;
        private List<double> listOfRRintervals_;

        public double Calculate(List<double> measurements)
        {
            r_peaks_ = new R_peak(measurements);
            listOfRRintervals_ = new List<double>();
            int topCount = r_peaks_.ReturnVertex().Count;

            for (int i = 1; i < topCount; i++)
            {
                listOfRRintervals_.Add(r_peaks_.ReturnVertex()[i].Xvalue_ - r_peaks_.ReturnVertex()[i - 1].Xvalue_);
            }

            for (int i = 0; i < listOfRRintervals_.Count - 1; i++)
            {
                RRinterval_ += Math.Pow((listOfRRintervals_[i] - listOfRRintervals_[i + 1]), 2);
            }
            return Math.Sqrt(RRinterval_ / listOfRRintervals_.Count);
        }
        
    }
}
