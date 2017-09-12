using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Unit {

	// Use this for initialization
	void Start ()
    {
        movementType = MovementType.wheel;
        fireType = FireType.indirect3To5;
        armorType = ArmorType.heavy;
        health = 10;
        maxMovement = 6;
        lineOfSight = 8;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
