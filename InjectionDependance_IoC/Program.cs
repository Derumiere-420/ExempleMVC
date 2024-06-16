/*using System;
//Exemple avec injection de dependance
namespace ConsoleApp2
{
    public interface IBattery
    {
        String PowerOn();
        String PowerOff();
    }

    public class Radio
    {
        private readonly IBattery _battery;

        public Radio(IBattery battery)
        {
            _battery = battery;
        }

        public void TurnOn()
        {
            Console.WriteLine(_battery.PowerOn());
        }

        public void TurnOff()
        {
            Console.WriteLine(_battery.PowerOff());
        }
    }

    public class AlkalineBattery : IBattery
    {
        public string PowerOn()
        {
            return ($"{this.GetType()} Battery is powering on.");
        }

        public string PowerOff()
        {
            return ($"{this.GetType()} Battery is powering off.");
        }
    }

    public class NickelCadmiumBattery : IBattery
    {
        public int Energie {  get; set; }

        public NickelCadmiumBattery()
        {
            Energie = 100;
        }
        public string PowerOn()
        {
            return ($"{this.GetType()} Battery is powering on.");
        }

        public string PowerOff()
        {
            return ($"{this.GetType()} Battery is powering off.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            AlkalineBattery LithiumBattery = new AlkalineBattery();
            NickelCadmiumBattery NickelCadmiumBattery = new NickelCadmiumBattery();

            Console.WriteLine("Niveau d'énergie : " + NickelCadmiumBattery.Energie);

            Radio radio = new Radio(LithiumBattery);
            Radio radio2 = new Radio(NickelCadmiumBattery);
            
            radio.TurnOn();
            radio2.TurnOn();
            radio.TurnOff();
            radio2.TurnOff();

        }
    }
}*/

//Exemple sans injection de dependance
using System;

namespace ConsoleApp2
{
    public class Radio
    {
        private Battery _battery;

        public Radio()
        {
            _battery = new Battery("Alkaline");
        }

        public void TurnOn()
        {
            Console.WriteLine($"{_battery.PowerOn}");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{_battery.PowerOff}");
        }
    }

    public class Battery
    {
        public string Type { get; set; }

        public Battery(string type)
        {
            Type = type;

        }

        public string PowerOn()
        {
            return ($"{Type} Battery is powering on.");
        }

        public string PowerOff()
        {
            return ($"{Type} Battery is powering off.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Radio radio = new Radio();

            radio.TurnOn();
            radio.TurnOff();
        }
    }
}

