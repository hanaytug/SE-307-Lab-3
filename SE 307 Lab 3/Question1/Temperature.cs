using System;

namespace SE_307_Lab_3
{
    public class Temperature
    {
        private double _celsius;
        public double Celsius
        {
            get => _celsius;
            set
            {
                _celsius = value;
                _fahrenheit = CelsiusToFahrenheit(value);
                _kelvin = CelsiusToKelvin(value);
            }
        }
        
        private double _fahrenheit;

        public double Fahrenheit
        {
            get => _fahrenheit;
            set
            {
                _celsius = FahrenheitToCelsius(value);
                _fahrenheit = value;
                _kelvin = FahrenheitToKelvin(value);
            }
        }
        
        private double _kelvin;

        public double Kelvin
        {
            get => _kelvin; 
            set
            {
                _celsius = KelvinToCelsius(value);
                _fahrenheit = KelvinToFahrenheit(value);
                _kelvin = value;
            }
        }
        
        public Temperature()
        {
            Celsius = 0;
        }

        public Temperature(double celsius)
        {
            Celsius = celsius;
        }

        private double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32;
        }
        
        private double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        private double FahrenheitToKelvin(double fahrenheit)
        {
            return CelsiusToKelvin(FahrenheitToCelsius(fahrenheit));
        }

        private double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        private double KelvinToFahrenheit(double kelvin)
        {
            return CelsiusToFahrenheit(KelvinToCelsius(kelvin));
        }

        public void Display()
        {
            Console.WriteLine("Celsius : " + Celsius);
            Console.WriteLine("Fahrenheit : " + Fahrenheit);
            Console.WriteLine("Kelvin : " + Kelvin);
            Console.WriteLine("--------------");
        }
    }
}