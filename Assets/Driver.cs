using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {
	float stuck = -1f;
	public bool current = false;

	void Update () {
		if(stuck != -1f && transform.position.y < stuck) {
			transform.position = new Vector3(transform.position.x, stuck, transform.position.z);
		}

		RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 0.01f, 1 << LayerMask.NameToLayer("Tumbler"));
		if (hit && current) {
			stuck = transform.position.y;
		}
	}
}
