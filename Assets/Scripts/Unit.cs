using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public MovementType movementType;
    public FireType fireType;
    public ArmorType armorType;

    public int health, damage, maxMovement, lineOfSight;

    public SpriteRenderer spriteRenderer;
}

public enum MovementType { foot, wheel, fly };
public enum FireType { direct, indirect1To2, indirect3To5 };
public enum ArmorType { none, light, heavy };
