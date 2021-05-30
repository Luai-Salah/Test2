using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "NewTile", menuName = "Tilemap/Create A New Tile")]
public class TileData : ScriptableObject
{
    public TileType type;
    public Tile tile;
}
