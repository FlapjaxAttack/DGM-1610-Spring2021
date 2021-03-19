using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopswithArray : MonoBehaviour
{
    void Start()
    {
        string[] foodStuffs = {"pizza", "bagels", "pasta", "salad"};
        
        foreach (string i in foodStuffs) 
        {
            Console.WriteLine(i);
        }
    }
}
