﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int numberCount;
    public int creditValue = 3;
    public Text counterText;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        numberCount += creditValue;
        counterText.text = numberCount.ToString();
        gameObject.SetActive(false);
    }
}
