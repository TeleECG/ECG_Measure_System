using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface ICalculator
    {
        double Calculate(List<double> measurements);
    }
}
