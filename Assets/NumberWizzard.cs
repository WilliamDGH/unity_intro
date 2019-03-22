using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizzard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
        int guess = 500;

        Debug.Log("Welcome to number wizard.");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max + ".");
        Debug.Log("The lowest number you can pick is: " + min + ".");
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct.");


    }

    // Update is called once per frame
    void Update()
    {
        int guess = 500;
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Up Arrow key was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Down Arrow key was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Enter key was pressed");
        }

    }
}
