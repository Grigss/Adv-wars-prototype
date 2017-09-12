using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infantry : Unit {

    
	// Use this for initialization
	void Start () {
        movementType = MovementType.foot;
        fireType = FireType.indirect1To2;
        armorType = ArmorType.light;
        health = 5;
        maxMovement = 3;
        lineOfSight = 4;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load("Sprites/Units_0", typeof(Sprite)) as Sprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
