using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapInput : MonoBehaviour
{
	[SerializeField] private Transform onTileFeedback;

	private TileCreator creator;
	private Tilemap tilemap;

	private void Start()
	{
		tilemap = GetComponent<Tilemap>();
		creator = TileCreator.instance;
	}

	private void OnMouseOver()
	{
		Vector3Int tilePos = tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
		tilePos.z = 0;
		onTileFeedback.position = new Vector3(tilePos.x, tilePos.y / 2, 0f);
		if (Input.GetMouseButton(0))
			creator.SetTile(tilemap, tilePos);
	}
}
