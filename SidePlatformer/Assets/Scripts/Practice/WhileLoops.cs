using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    void Start()
    {
        int speed = 1;
        int gasLevel = 10;
        do
        {
            speed= speed*2;
            gasLevel--;
            Console.WriteLine("Car speed is " + speed + " with " + gasLevel + "mL fuel remaining.");
        } 
        while (gasLevel > 1);
    }
}
