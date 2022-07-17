using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _height, _width;
    [SerializeField] private Tile _normalTile, _endTile;
    [SerializeField] private Transform _cam;
    
    void Start()
    {
        GenerateGrid();
    }
    void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                // Hier nog iets doen met endTile
                var SpawnedTile = Instantiate(_normalTile, new Vector3(x, y), Quaternion.identity);
                SpawnedTile.name = $"Tile {x} {y}";
            
                SpawnedTile.Init(x, y);
            }
        }

        _cam.transform.position = new Vector3((float)_width/2 -0.5f, (float)_height/2 -0.5f, -10);
    }
}
