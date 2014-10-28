using UnityEngine;
using System.Collections;

public class Pin : MonoBehaviour {
	float maxY;
	float posX;
	
	void Start () {
		posX = transform.position.x;
		maxY = transform.position.y;
	}
	
	void Update () {
		// Pin can never move in the X direction at all
		// Pin has a limit on how far it can fall in the Y direction
		float posY = (transform.position.y < maxY) ? maxY : transform.position.y;
		transform.position = new Vector3(posX, posY, transform.position.z);
	}
}
