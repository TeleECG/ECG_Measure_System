using Logic_Layer;
using NSubstitute;
using NUnit.Framework;
using Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ECG_Measure_System
{
    [TestFixture]
    class Patient_Display_CheckCPR_unit_test
    {
        Patient_Display _uut;

        [SetUp]
        public void Setup()
        {
            
            _uut = new Patient_Display();
        }

        [TestCase("3010621657")]
        [TestCase("1405008765")]
        [TestCase("1909093071")]
        [TestCase("1201900030")]
        public void Check_CPR_True(string testCPR)
        {
            //Then
            Assert.That(_uut.checkCPR(testCPR)==true);
        }

        [TestCase("1111111111")]
        [TestCase("2323232323")]
        [TestCase("4564564566")]
        [TestCase("1010101010")]
        public void Check_CPR_False(string testCPR)
        {
            //Then
            Assert.That(_uut.checkCPR(testCPR) == false);
        }

    }
}

