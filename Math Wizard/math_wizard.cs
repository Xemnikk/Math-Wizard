using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();      
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("I am the almighty Number Wizard!");
        Debug.Log("Pick a number!");
        Debug.Log("No need to tell me what it is...");
        Debug.Log("The highest number you can choose is: " + max + ".");
        Debug.Log("Trust me, I'll figure it out.");
        Debug.Log("The lowest number you can choose is: " + min + ".");
        Debug.Log("That's pretty much all I can do. ;)");
        Debug.Log("Tell me if your number is higher or lower than: " + guess + ".");
        Debug.Log("Up arrow = Higher, Down arrow = Lower, Enter key = Correct.");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            min = guess;
            NextGuess();
           
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {  
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I told you I would figure it out. :)");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than: " + guess + ".");
    }
}
