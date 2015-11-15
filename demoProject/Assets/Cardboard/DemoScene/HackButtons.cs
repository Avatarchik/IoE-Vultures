using UnityEngine;
using System;
using UnityEngine.UI;

//[RequireComponent(typeof(Collider))]
public class HackButtons : MonoBehaviour {

	public void SetGazedAt(bool gazedAt) {
		
		Text textObj = GetComponentInChildren<Text>();
		Text answerText = AnswerText();

		if (String.Equals(textObj.text, "January, 1969")) {
			answerText.text = "Correct!";
		} else {
			answerText.text = "Incorrect.";
		}
	}

	public void ResetAnswerText() {
		Text answerText = AnswerText();
		answerText.text = "Choose an answer.";
	}

	public void SelectAnswer() {
		Text answerText = AnswerText();
		answerText.text = "Something clicked!";
	}

	private Text AnswerText() {
		GameObject answerTextObj = GameObject.Find("AnswerText");
		return answerTextObj.GetComponent<Text>();
	}
}
