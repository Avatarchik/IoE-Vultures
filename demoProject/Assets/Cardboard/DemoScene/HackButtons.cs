using UnityEngine;
using System;
using UnityEngine.UI;

//[RequireComponent(typeof(Collider))]
public class HackButtons : MonoBehaviour {

	public void SetGazedAt(bool gazedAt) {
		
		Text textObj = GetComponentInChildren<Text>();

		GameObject answerTextObj = GameObject.Find("AnswerText");
		Text answerText = answerTextObj.GetComponent<Text>();

		if (String.Equals(textObj.text, "Answer A")) {
			answerText.text = "A";
		} else if (String.Equals(textObj.text, "Answer B")) {
			answerText.text = "B";
		} else if (String.Equals(textObj.text, "Answer C")) {
			answerText.text = "C";
		}
	}

	public void ResetAnswerText() {
		GameObject answerTextObj = GameObject.Find("AnswerText");
		Text answerText = answerTextObj.GetComponent<Text>();
		answerText.text = "Choose an answer.";
	}

	public void SelectAnswer() {
		GameObject answerTextObj = GameObject.Find("AnswerText");
		Text answerText = answerTextObj.GetComponent<Text>();

		answerText.text = "Something clicked!";
	}
}
