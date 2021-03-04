using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int age = 18;
    public bool DriversLicense;
    void Start()
    {
        if (age >= 16)
        {
            DriversLicense = true;
            Console.WriteLine("Age Verified!");
        }
        else
        {
            DriversLicense = false;
            Console.WriteLine("Age declined.");
        }
    }
}
