using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Logic_Layer;
using Data_Layer;
using NSubstitute;
using Domain;
using NSubstitute.ReceivedExtensions;
using System.Net.Http;
using Microsoft.VisualBasic.CompilerServices;
using NUnit.Framework.Constraints;

namespace Test_ECG_Measure_System
{
    [TestFixture]
    class IntegrationTest_ADC_Measure_Controller
    {
        private Measure_ECG_Controller _measure_ECG_Controller;
        private Model _model;
        private ICalculator _HRV;
        private ICalculator _puls;
        private R_peak _rPeak;
        private IADC _sut;//System Under Test

        [SetUp]
        public void Setup()
        {
            _model = new Model();
            _HRV = Substitute.For<HRV_Calculator>();
            _puls = Substitute.For<Pulse_Calculator>();
            _rPeak = Substitute.For<R_peak>();
            _sut = new ADC();
            _measure_ECG_Controller = new Measure_ECG_Controller(_model,_sut,_HRV,_puls,_rPeak);

        }

       
        [Test]
        public void Test_ADC_MeasureECGController_MeasureECG_ReadCSVLead1()
        {
            int measureNumber = 1;
            _measure_ECG_Controller.Measure_ECG(measureNumber);
            //Assert.That(_sut.Received(1).ReadCsvLead1(),);
          
           
            
        }

        
    }
}
