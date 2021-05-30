using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraController : MonoBehaviour
{
	[SerializeField] private float panBoarder = 10;
	[SerializeField] private float panSpeed = 20;

	private void Update()
    {
		/*if (Input.GetButton("Fire1"))
		{
			Vector2 mousePos = Input.mousePosition;
			mousePos.x -= Screen.width / 2;
			mousePos.y -= Screen.height / 2;
			Vector3 direction = mousePos - (Vector2)transform.position;
			float dist = Vector3.Distance(mousePos, transform.position);
			direction.Normalize();
			transform.Translate(direction * Time.deltaTime * dist / 100);
		}
		else
		{*/
			Vector3 pos = transform.position;

			float hori = Input.GetAxisRaw("Horizontal");
			float vert = Input.GetAxisRaw("Vertical");

			if (Input.mousePosition.y >= Screen.height - panBoarder)
			{
				pos.y += panSpeed * Time.deltaTime;
			}
			if (Input.mousePosition.y <= panBoarder)
			{
				pos.y -= panSpeed * Time.deltaTime;
			}
			if (Input.mousePosition.x >= Screen.width - panBoarder)
			{
				pos.x += panSpeed * Time.deltaTime;
			}
			if (Input.mousePosition.x <= panBoarder)
			{
				pos.x -=  panSpeed * Time.deltaTime;
			}
			if (vert > 0.01f)
			{
				pos.y += vert * panSpeed * Time.deltaTime;
			}
			if (vert < -0.01)
			{
				pos.y += vert * panSpeed * Time.deltaTime;
			}
			if (hori > 0.01f)
			{
				pos.x += hori * panSpeed * Time.deltaTime;
			}
			if (hori < -0.01f)
			{
				pos.x += hori * panSpeed * Time.deltaTime;
			}

			transform.position = pos;
		//}
    }
}
