using Exercice01;

namespace Exercice01Test;

[TestClass]
public sealed class GradingCalculatorTest
{



    private GradingCalculator gradingCalculator;

    private void SetUp(int score, int attendancePercentage)
    {
        gradingCalculator = new GradingCalculator()
        {
            Score = score,
            AttendancePercentage = attendancePercentage
        };
    }

    [TestMethod]
    [DataRow(95, 90, 'A')]
    [DataRow(85, 90, 'B')]
    [DataRow(65, 90, 'C')]
    [DataRow(95, 65, 'B')]
    [DataRow(95, 55, 'F')]
    [DataRow(65, 55, 'F')]
    [DataRow(50, 90, 'F')]
    public void WhenGetGrade(int score, int attendance, char result)
    {
        SetUp(score, attendance);
        char c = gradingCalculator.GetGrade();
        Assert.AreEqual(result, c);
    }


}
