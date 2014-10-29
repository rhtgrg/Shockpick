using UnityEngine;
using System.Collections;

public class App : MonoBehaviour {
	void Start () {
		Screen.showCursor = true;
	}

	public void LoadGame () {
		Application.LoadLevel(1);
	}
}
