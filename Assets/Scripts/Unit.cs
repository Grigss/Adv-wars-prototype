using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public MovementType movementType;
    public FireType fireType;
    public ArmorType armorType;

    public int health, maxMovement, lineOfSight;

    public SpriteRenderer spriteRenderer;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public enum MovementType { foot, wheel, fly };
public enum FireType { direct, indirect1To2, indirect3To5 };
public enum ArmorType { none, light, heavy };
