using Exercice01;

namespace Exercice01Test
{
    [TestClass]
    public sealed class GradingCalculatorTest
    {
        [TestMethod]
        public void WhenGetGrade_95_90_Then_A()
        {
            GradingCalculator gradingCalculator = new GradingCalculator()
            {
                Score = 95,
                AttendancePercentage = 90
            };

            var result = gradingCalculator.GetGrade();

            Assert.AreEqual('A', result);
        }

        [TestMethod]
        public void WhenGetGrade_85_90_Then_B()
        {
            GradingCalculator gradingCalculator = new GradingCalculator()
            {
                Score = 85,
                AttendancePercentage = 90
            };

            var result = gradingCalculator.GetGrade();

            Assert.AreEqual('B', result);
        }

        [TestMethod]
        public void WhenGetGrade_65_90_Then_C()
        {
            GradingCalculator gradingCalculator = new GradingCalculator()
            {
                Score = 65,
                AttendancePercentage = 90
            };


            var result = gradingCalculator.GetGrade();

            Assert.AreEqual('C', result);
        }

        [TestMethod]
        public void WhenGetGrade_95_65_Then_B()
        {
            GradingCalculator gradingCalculator = new GradingCalculator()
            {
                Score = 95,
                AttendancePercentage = 65
            };                       

            var result = gradingCalculator.GetGrade();
            Assert.AreEqual('B', result);
        }

        [TestMethod]
        public void WhenGetGrade_95_55_Then_F()
        {
            GradingCalculator gradingCalculator = new GradingCalculator()
            {
                Score = 95,
                AttendancePercentage = 55
            };                      
            var result = gradingCalculator.GetGrade();
            Assert.AreEqual('F', result);
        }

        [TestMethod]
        public void WhenGetGrade_65_55_Then_F()
        {
            GradingCalculator gradingCalculator = new GradingCalculator()
            {
                Score = 65,
                AttendancePercentage = 55
            };

            var result = gradingCalculator.GetGrade();

            Assert.AreEqual('F', result);
        }

        [TestMethod]
        public void WhenGetGrade_50_90_Then_F()
        {
            GradingCalculator gradingCalculator = new GradingCalculator()
            {
                Score = 50,
                AttendancePercentage = 90
            };
            
            var result = gradingCalculator.GetGrade();
            Assert.AreEqual('F', result);
        }

    }
}
