using UnityEngine;
using System.Collections;

public class LockPick : MonoBehaviour {
	void Update () {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		// Target point is the right edge of the screen, rotate by inverting Y position
		// Move lockpick with the mouse
		transform.position = mousePos;
		// Rotate lockpick based on Y position
		float rot_z = Mathf.Atan2((Input.mousePosition.y - Screen.height/2)/(Screen.height/2), Vector2.right.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rot_z);
	}
}
