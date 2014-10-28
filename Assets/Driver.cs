using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {
	public DriverPinManager driverPinManager;
	public bool current = false;

	float stuck = -1f;

	void Update () {
		if(stuck != -1f && transform.position.y < stuck) {
			transform.position = new Vector3(transform.position.x, stuck, transform.position.z);
		}

		RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 0.01f, 1 << LayerMask.NameToLayer("Tumbler"));
		if (hit && current) {
			stuck = transform.position.y;
			driverPinManager.StickPin(this);
		}

		if(current) {
			renderer.material.color = Color.red;
		} else {
			renderer.material.color = Color.white;
		}
	}

	void OnCollisionEnter2D (Collision2D col) {
		if(col.gameObject.GetComponent<Pin>() != null && stuck != -1f) {
			// This is a collision with a pin when the driver was stuck - unstick driver
			stuck = -1f;
			driverPinManager.UnstickPin(this);
		}
	}

	public void SetCurrentOnDrop () {
		// When the pin falls, it becomes current pin
		StartCoroutine("DropSetsCurrent");
	}

	IEnumerator DropSetsCurrent () {
		while(!current) {
			if(transform.position.y <= GetComponent<Pin>().maxY) {
				current = true;
			}
			yield return null;
		}
	}
}
