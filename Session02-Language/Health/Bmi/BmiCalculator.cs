namespace Bmi
{
    /// <summary>
    /// This class offers methods for evaluating the healthy status based on weight and height
    /// Scenario #1: Mr. An wants to create an order
    /// </summary>
    public class BmiCalculator
    {
        /// <summary>
        /// Returns the BMI indicator of someone
        /// Hàm trả về chỉ số BMI của ai đó
        /// </summary>
        /// <param name="weight">Weight is under kg</param>
        /// <param name="height">Height is under m</param>
        /// <returns></returns>
        public static double GetBmi(double weight, double height) => weight / Math.Pow(height, 2);
    }
}
