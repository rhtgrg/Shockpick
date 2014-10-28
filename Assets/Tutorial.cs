using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial : MonoBehaviour {
	public Text tutorialText;

	void Start () {
		StartCoroutine("TutorialText");
	}

	IEnumerator TutorialText () {
		yield return new WaitForSeconds(1f);
		tutorialText.text = "THESE ARE THE PINS >>";
		yield return new WaitForSeconds(1f);
		tutorialText.text = "PUSH THE CURRENT PIN";
		yield return new WaitForSeconds(1f);
		tutorialText.text = "THE CURRENT PIN IS <color='red'>RED</color>";
		yield return new WaitForSeconds(1f);
		tutorialText.text = "";
		yield return null;
	}
}
