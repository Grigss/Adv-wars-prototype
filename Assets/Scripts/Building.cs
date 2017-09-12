using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : Unit {

	// Use this for initialization
	void Start () {
        movementType = MovementType.foot;
        fireType = FireType.direct;
        armorType = ArmorType.heavy;
        health = 20;
        maxMovement = 3;
        lineOfSight = 4;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load("Sprites/Units_111", typeof(Sprite)) as Sprite;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
