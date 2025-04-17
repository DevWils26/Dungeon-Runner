using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Graph
{
    
    private static List<Vector2Int> neighborse4directions = new List<Vector2Int>{

        new Vector2Int(0,1), // UP
        new Vector2Int(1,0), // RIGHT
        new Vector2Int(0,-1), // DOWN
        new Vector2Int(-1,0) // LEFT

    };

    private static List<Vector2Int> neighborse8directions = new List<Vector2Int>{

        new Vector2Int(0,1), // UP
        new Vector2Int(1,0), // RIGHT
        new Vector2Int(0,-1), // DOWN
        new Vector2Int(-1,0), // LEFT
        new Vector2Int(1,1), // Diagonal
        new Vector2Int(1,-1), // Diagonal
        new Vector2Int(-1,1), // Diagonal
        new Vector2Int(-1,-1) // Diagonal

    };

    List<Vector2Int> graph;
    
    public Graph(IEnumerable<Vector2Int> vertices){

        graph = new List<Vector2Int>(vertices);
    }

    public List<Vector2Int> GetNeighbors4Directions(Vector2Int startPosition){

        return GetNeighbors(startPosition, neighborse4directions);

    }

    public List<Vector2Int> GetNeighbors8Directions(Vector2Int startPosition){

        return GetNeighbors(startPosition, neighborse8directions);

    }

    private List<Vector2Int> GetNeighbors(Vector2Int startPosition, List<Vector2Int> neighborsOffsetList){

        List<Vector2Int> neighbors = new List<Vector2Int>();
        foreach (var neighborDirection in neighborsOffsetList){
            Vector2Int potentialNeighbor = startPosition + neighborDirection;
            if (graph.Contains(potentialNeighbor)){
                neighbors.Add(potentialNeighbor);
            }
        }
        return neighbors;
    }

}
