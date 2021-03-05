using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public int ovenSetting = 4;
    public int ovenTemperature;
    void Start()
    {
        switch (ovenSetting)
        {
            case 1:
                Console.WriteLine("Temperature Setting 1");
                ovenTemperature = 250;
                break;
            case 2:
                Console.WriteLine("Temperature Setting 2");
                ovenTemperature = 275;
                break;
            case 3:
                Console.WriteLine("Temperature Setting 3");
                ovenTemperature = 300;
                break;
            case 4:
                Console.WriteLine("Temperature Setting 4");
                ovenTemperature = 325;
                break;
            case 5:
                Console.WriteLine("Temperature Setting 5");
                ovenTemperature = 350;
                break;
            case 6:
                Console.WriteLine("Temperature Setting 6");
                ovenTemperature = 375;
                break;
            case 7:
                Console.WriteLine("Temperature Setting 7");
                ovenTemperature = 400;
                break;
        }
    }
}
