﻿using ServiceRadioFactory.Services.Interfaces;

namespace ServiceRadioFactory.Services.Implementations
{
    public class AlkalineBattery : IBattery
    {
        public string PowerOn()
        {
           return("Alkaline Battery is powering on.");
        }

        public string PowerOff()
        {
            return("Alkaline Battery is powering off.");
        }
    }

}
