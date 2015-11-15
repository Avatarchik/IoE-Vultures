using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class HackButtons : MonoBehaviour {

	public void SetGazedAt(bool gazedAt) {
	}

	public void ResetAnswerText() {

		Text answerText = AnswerText();
		answerText.text = "Choose an answer.";

		Button button = GetComponent<Button>();
		ColorBlock colors = button.colors;
		colors.highlightedColor = new Color(150.0F / 255.0F, 240.0F / 255.0F, 240.0F / 255.0F, 1.0F);
		button.colors = colors;
	}

	public void SelectAnswer() {

		Text textObj = GetComponentInChildren<Text>();
		Text answerText = AnswerText();

		Button button = GetComponent<Button>();
		ColorBlock colors = button.colors;

		if (String.Equals(textObj.text, "January, 1969")) {

			colors.highlightedColor = Color.green;
			answerText.text = "Correct!";
			StartCoroutine(ExecuteAfterTime(2.0F)); // jump to new sphere.

		} else {

			answerText.text = "Incorrect.";
			colors.highlightedColor = Color.red;
		}

		button.colors = colors;
	}

	IEnumerator ExecuteAfterTime(float time) {
   		yield return new WaitForSeconds(time);
 
 		Vector3 newPosition = new Vector3(100.0F, 0.0F, 0.0F);
 		GameObject cameraObj = GameObject.Find("CardboardMain");
 		cameraObj.transform.position = newPosition;
 	}

	private Text AnswerText() {
		GameObject answerTextObj = GameObject.Find("AnswerText");
		return answerTextObj.GetComponent<Text>();
	}
}
