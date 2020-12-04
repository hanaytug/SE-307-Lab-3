namespace SE_307_Lab_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TemperatureTest temperatureTest = new TemperatureTest();
            temperatureTest.TemperatureTestScenario();
            
            HardwareTest hardwareTest = new HardwareTest();
            hardwareTest.HardwareTestScenario();
            
            Question3.Question3_Main();
        }
    }
}