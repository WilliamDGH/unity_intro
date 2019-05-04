﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizzard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartInscruction();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            UpdateGuess();
       }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Yes!!!!! The answer is " + guess + "!!!");
            StartInscruction();
        }

    }

    void StartInscruction()
    {
        max = 1000;
        min = 1;
        guess = 1001 / 2;

        Debug.Log("Welcome to number wizard!!!!");
        Debug.Log("Pick a number, don't tell me what it is..");
        Debug.Log("The highest number you can pick is: " + max + ".");
        Debug.Log("The lowest number you can pick is: " + min + ".");
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up Arrow = higher, Push Down Arrow = lower, Push Enter = Correct.");
        max++;
    }

    void UpdateGuess ()
    {
        guess = (max + min) / 2;
        Debug.Log("Is is higher or lower than " + guess + "?");
    }
}
