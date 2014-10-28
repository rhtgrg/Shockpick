using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial : MonoBehaviour {
	public Text tutorialText;
	public GameObject lockPick;

	void Start () {
		StartCoroutine("TutorialText");
	}

	IEnumerator TutorialText () {
		tutorialText.text = "THESE ARE THE PINS >>";
		yield return new WaitForSeconds(2f);
		tutorialText.text = "PUSH THE CURRENT PIN";
		yield return new WaitForSeconds(2f);
		tutorialText.text = "THE CURRENT PIN IS <color='brown'>BROWN</color>";
		yield return new WaitForSeconds(3f);
		tutorialText.text = "";
		yield return new WaitForSeconds(2.7f);
		lockPick.SetActive(true);
		yield return null;
	}
}
