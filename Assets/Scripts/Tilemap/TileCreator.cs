using UnityEngine;
using UnityEngine.Tilemaps;

public class TileCreator : MonoBehaviour
{
	public static TileCreator instance;

	public TileData selectedTile;

	private void Awake()
	{
		if (instance == null)
			instance = this;
		else Destroy(gameObject);
	}

	public void SetTile(Tilemap _tilemap, Vector3Int changePos)
	{
		TileBase _newTile = Instantiate<TileBase>(selectedTile.tile);
		_tilemap.SetTile(changePos, _newTile);
	}
}
