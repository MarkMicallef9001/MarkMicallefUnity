using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    int max;
    int min;
    int guess;

    void NextGuess()
    {
        print("Is Number bigger or smaller than"+guess + "?");
        print("Press Up if number is bigger");
        print("Press Down if number is smaller");
        print("Press Enter if number is guessed");
    }

    void Startgame()
    {

        min = 1;
        max = 1001;
        guess = 500;
        //output to the Console
        print("Welcome to Number Wizard");
        //adding min and max to the String
        Debug.Log("Please choose a number from " + min + " to " + max);
        NextGuess();
    }
	// Use this for initialization
	void Start ()
    {
        Startgame();
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Pressed");
            min = guess;
            guess = (max + min) / 2;
            NextGuess();

        }
		else

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Pressed");
            max = guess;
            guess = (max + min) / 2;
            NextGuess();

        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter arrow Pressed");
            Debug.Log("Number Guessed. PROSET!");
            print("(P)lay Again or (Q)uit");

            if (Input.GetKeyDown(KeyCode.Q))
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }

            else
                if (Input.GetKeyDown(KeyCode.P))

            {
                Startgame();
            }
        }

    }
}
