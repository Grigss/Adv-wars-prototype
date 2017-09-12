using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turns : MonoBehaviour {
    
    //Ammount of turns that have passed (one team moved)
    int turn;
    //Ammount of rounds that have passed (All the teams have moved)
    int round;

    Text text;

    bool playerTurn;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {

    }

    void RoundEnd()
    {
        turn++;
        round++;

        if (!playerTurn)
        {
            playerTurn = true;
        }
        else
        {
            playerTurn = false;
        }
        
        text.text = "Round: " + round;
    }

    void NewRound()
    {
        //Tells a team to begin a new round
    }
}
