using UnityEngine;
using System.Collections;

public class LockPick : MonoBehaviour {
	void Update () {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = mousePos;	
	}
}
