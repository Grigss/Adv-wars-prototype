using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
    public int size = 5;
    private ArrayList map;

    void Start(){
        for(int i = 0; i < size; i++){
            map.Add(Random.Range(0,1));
        }

        Create();
    }

    void Create()
    {
        // create the tiles map
        float[map] tilesmap = new float[size, size];
        // set values here....
        // every float in the array represent the cost of passing the tile at that position.
        // use 0.0f for blocking tiles.

        // create a grid
        PathFind.Grid grid = new PathFind.Grid(size, size, tilesmap);

        // create source and target points
        PathFind.Point _from = new PathFind.Point(1, 1);
        PathFind.Point _to = new PathFind.Point(10, 10);

        // get path
        // path will either be a list of Points (x, y), or an empty list if no path is found.
        List<PathFind.Point> path = PathFind.Pathfinding.FindPath(grid, _from, _to);
    }
}
