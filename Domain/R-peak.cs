﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class R_peak
    {
        private double threshold = 2.1;//Denne skal vi selv undersøge hvad er
        private List<double> dataList_;
        private List<Vertex> vertexValues_;

        public R_peak(List<double> measurements)
        {
            dataList_ = new List<double>();
            vertexValues_ = new List<Vertex>();

            dataList_ = measurements;
        }

        public List<Vertex> ReturnVertex()
        {
            for (int i = 0; i < dataList_.Count; i++)
            {
                if (dataList_[i] < threshold)
                {
                    dataList_[i] = 0;
                }
            }

            double peakYvalue = 0;
            double peakXValue = 0;
            Vertex myVertex = new Vertex(peakYvalue, peakXValue);
            for (int i = 1; i < dataList_.Count; i++)
            {
                if (dataList_[i] != 0)
                {
                    if (peakYvalue < dataList_[i])
                    {
                        peakYvalue = dataList_[i];
                        peakXValue = i * 0.005;//Undersøg denne
                        myVertex = new Vertex(peakYvalue, peakXValue);
                    }
                }
                if (dataList_[i - 1] != 0 && dataList_[i] == 0)
                {
                    vertexValues_.Add(myVertex);
                    peakYvalue = dataList_[0];
                    peakXValue = 0;
                    myVertex = new Vertex(peakYvalue, peakXValue);
                }
            }
            if (peakYvalue != 0 && peakXValue != 0)
            {
                vertexValues_.Add(myVertex);
            }

            return vertexValues_;
        }
    }
}
