using Tyuiu.IstominNM.Lab1.Review.V2.Lib;

namespace Tyuiu.IstominNM.Lab1.Review.V2.Test;

public class UnitTest1
{
    [Fact]
    public void CheckCalc()
        {
            double x = 0.5;
            double y = 0.2;

            DataService ds = new DataService();

            double res = ds.Calc(x, y);

            double true_value = 0.216;

            Assert.Equal(true_value, res);
        }
}