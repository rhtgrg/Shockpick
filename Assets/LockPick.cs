using UnityEngine;
using System.Collections;

public class LockPick : MonoBehaviour {
	Vector2 shakeOffset = Vector2.zero;

	void Start () {
		StartCoroutine("RandomShake");
	}

	void Update () {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		// Target point is the right edge of the screen, rotate by inverting Y position
		// Move lockpick with the mouse, also add shake offset
		transform.position = mousePos + shakeOffset;
		// Rotate lockpick based on Y position
		float rot_z = Mathf.Atan2((Input.mousePosition.y - Screen.height/2)/(Screen.height/2), Vector2.right.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rot_z);
	}

	IEnumerator RandomShake () {
		// Shakes the lockpick randomly every 2-4 seconds for 1-2 seconds
		while (true) {
			yield return new WaitForSeconds(Random.Range(2f,4f));
			float time = 0f;
			float duration = Random.Range(1f,2f);
			while(time <= duration) {
				shakeOffset = new Vector2(Random.Range(5f,12f), Random.Range(5f,12f))/Constants.UNITS_PER_PIXEL;
				time += Time.deltaTime;
				yield return null;
			}
			yield return null;
		}
	}
}
