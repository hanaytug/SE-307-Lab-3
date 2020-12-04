namespace SE_307_Lab_3
{
    public class TemperatureTest
    {
        public void TemperatureTestScenario()
        {
            Temperature temperature = new Temperature(0);
            
            temperature.Display();

            temperature.Fahrenheit = 86;
            temperature.Display();
            
            temperature.Kelvin = 288.15;
            temperature.Display();

            temperature.Celsius = 5;
            temperature.Display();
        }
    }
}