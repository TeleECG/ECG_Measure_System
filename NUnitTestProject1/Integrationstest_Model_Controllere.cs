using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Layer;
using Data_Layer;
using Domain;
using NSubstitute;
using Data_Layer.Data;

namespace Test_ECG_Measure_System
{
    [TestFixture]
    class Integrationstest_Model_Controllere
    {
        private Model _sut;
        private Enter_Patient_Data_Controller _enter_Patient_Data_Controller;
        private Measure_ECG_Controller _measure_ECG_Controller;
        private IADC _adc;
        private ICalculator _HRV;
        private ICalculator _puls;
        private R_peak _rPeak;


        [SetUp]
        public void Setup()
        {
            _sut = new Model();
            _enter_Patient_Data_Controller = new Enter_Patient_Data_Controller(_sut);
            _adc = Substitute.For<IADC>();
            _HRV = Substitute.For<ICalculator>();
            _puls = Substitute.For<ICalculator>();
            _rPeak = new R_peak();
            _measure_ECG_Controller = new Measure_ECG_Controller(_sut, _adc, _HRV, _puls, _rPeak);
            
        }

        [Test]
        public void Model_EnterPatientDataController_SavePatientData()
        {
            string cprNumber = "1234567890";
            string name = "Jytte";
            string address = "Nuuk";
            _enter_Patient_Data_Controller.SavePatientData(cprNumber, name, address);
            Assert.That(_sut._CPRNumber, Is.EqualTo(cprNumber));
            Assert.That(_sut._Name, Is.EqualTo(name));
            Assert.That(_sut._Address, Is.EqualTo(address));

        }

        [Test]      
        public void Model_MeasureECGController_DeleteECG_number1()
        {
            int deleteNumber = 1;
            _measure_ECG_Controller.Delete_ECG(deleteNumber);
            Assert.That(_sut.ECGLeadValues1_1, Is.EqualTo(null));
            Assert.That(_sut.ECGLeadValues1_2, Is.EqualTo(null));
            Assert.That(_sut.ECGLeadValues1_3, Is.EqualTo(null));
        }

        [Test]
        public void Model_MeasureECGController_DeleteECG_number2()
        {
            int deleteNumber = 2;
            _measure_ECG_Controller.Delete_ECG(deleteNumber);
            Assert.That(_sut.ECGLeadValues2_1, Is.EqualTo(null));
            Assert.That(_sut.ECGLeadValues2_2, Is.EqualTo(null));
            Assert.That(_sut.ECGLeadValues2_3, Is.EqualTo(null));
        }

        [Test]
        public void Model_MeasureECGController_DeleteECG_number3()
        {
            int deleteNumber = 3;
            _measure_ECG_Controller.Delete_ECG(deleteNumber);
            Assert.That(_sut.ECGLeadValues3_1, Is.EqualTo(null));
            Assert.That(_sut.ECGLeadValues3_2, Is.EqualTo(null));
            Assert.That(_sut.ECGLeadValues3_3, Is.EqualTo(null));
        }

        


    }
}
