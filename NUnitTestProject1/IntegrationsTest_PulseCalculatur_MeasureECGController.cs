using Data_Layer;
using Domain;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Layer;

namespace Test_ECG_Measure_System
{
    [TestFixture]
    class IntegrationsTest_PulseCalculatur_MeasureECGController
    {
        private ICalculator _sut;
        private Model _model;
        private ICalculator _HRV;
        private R_peak _rPeak;
        private IADC _adc;
        private Measure_ECG_Controller _measure_ECG_Controller;

        [SetUp]
        public void Setup()
        {
            _sut = new Pulse_Calculator();
            _model = new Model();
            _HRV = Substitute.For<ICalculator>();
            _rPeak = Substitute.For<R_peak>();
            _adc = Substitute.For<IADC>();
            _measure_ECG_Controller = new Measure_ECG_Controller(_model, _adc, _HRV, _sut, _rPeak);
        }

        [Test]
        public void PulseCalculator_MeasureECGController_BeginCalculate_Calculate()
        {
            var sevenItems = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
            _measure_ECG_Controller.Begin_Calculate(sevenItems);//returnere to int værdier, puls og hrv
            //_sut.Received(1).Returns<int>();
        }
    }
}
