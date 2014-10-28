using UnityEngine;
using System.Collections;

public class LockPick : MonoBehaviour {
	void Update () {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		// Target point is the right edge of the screen, rotate by inverting Y position
		Vector3 targetDirection = (new Vector3(Screen.width, Screen.height/2-mousePos.y) - (Vector3) mousePos);
		targetDirection.Normalize();
		// Move lockpick with the mouse
		transform.position = mousePos;
		// Rotate lockpick based on target direction
		float rot_z = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg * 100;
		transform.rotation = Quaternion.Euler(0f, 0f, rot_z + 90);
	}
}
