using UnityEngine;
using System.Collections;

public class CamSize : MonoBehaviour {
	void Start () {
		Screen.showCursor = false;
		Camera.main.orthographicSize = (Screen.height/2)/Constants.UNITS_PER_PIXEL;
	}
}
