using Logic_Layer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ECG_Measure_System
{
    class Enter_Patient_Data_Controller_SavePatientData_unit_test
    {
        private Enter_Patient_Data_Controller _uut;
        private Model _Model;

        [SetUp]
        public void Setup()
        {
            _Model = new Model();
            _uut = new Enter_Patient_Data_Controller(_Model);
        }

        [TestCase("3010621657","Per","Møllevej")]
        [TestCase("1405008765","Lærke", "Ringgade")]
        [TestCase("1909093071", "Josefine", "Carlsvej")]
        [TestCase("1201900030", "Gertrud", "Hovedgaden")]
        public void SavePatientData_test_CPR(string CPR, string Name, string Address)
        {
            _uut.SavePatientData(CPR, Name, Address);

            Assert.That(CPR, Is.EqualTo(_Model._CPRNumber));

        }

        [TestCase("3010621657", "Per", "Møllevej")]
        [TestCase("1405008765", "Lærke", "Ringgade")]
        [TestCase("1909093071", "Josefine", "Carlsvej")]
        [TestCase("1201900030", "Gertrud", "Hovedgaden")]
        public void SavePatientData_test_Name(string CPR, string Name, string Address)
        {
            _uut.SavePatientData(CPR, Name, Address);

            Assert.That(Name, Is.EqualTo(_Model._Name));

        }

        [TestCase("3010621657", "Per", "Møllevej")]
        [TestCase("1405008765", "Lærke", "Ringgade")]
        [TestCase("1909093071", "Josefine", "Carlsvej")]
        [TestCase("1201900030", "Gertrud", "Hovedgaden")]
        public void SavePatientData_test_Address(string CPR, string Name, string Address)
        {
            _uut.SavePatientData(CPR, Name, Address);

            Assert.That(Address, Is.EqualTo(_Model._Address));

        }
    }
}

