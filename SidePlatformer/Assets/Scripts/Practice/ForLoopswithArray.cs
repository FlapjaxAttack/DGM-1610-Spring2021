using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopswithArray : MonoBehaviour
{
    void Start()
    {
        int[] channels = { 0, 3, 2, 5,};
        
        for (int marbles = 0; marbles < 10; marbles++)
        {
            channels[0]++;
            channels[1]++;
            channels[2]++;
            channels[3]++;
            Console.WriteLine(channels);
        }
    }
}
