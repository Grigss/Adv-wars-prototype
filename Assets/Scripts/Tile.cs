using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {


    public TerrainType terrainType;
    private bool isOccupied, attackableByTeam1, attackableByTeam2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public enum TerrainType { Grass, Road, Mountain, Water };
