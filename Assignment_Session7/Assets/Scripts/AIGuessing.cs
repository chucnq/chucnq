using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIGuessing : MonoBehaviour {

	// UI Components
	public InputField iptmaxNumber,iptminNumber;
	public Button btnYes, btnHigher, btnLower,btnPlayAgain;
	public Text txtTitle,txtDisplay,txtChoose;

	// Khai báo biến float.Parse (iptminNumber.text) float.Parse (iptmaxNumber.text)
	float minNumber;
	float maxNumber;
	float numberGuessing;

	// Use this for initialization
	void Start () {
		
		playAgain ();
	}

	public float numberHandler(){
		float result = Mathf.RoundToInt ((maxNumber + minNumber) / 2);
		return result;
	}

	public void playAgain(){
		chooseNumber (true);
		enableButton (false);
		btnPlayAgain.gameObject.SetActive (false);
	}

	public void checkYes(){
		txtDisplay.text = "It's not difficult! Try another Number!";
		btnPlayAgain.gameObject.SetActive (true);
	}

	public void checkLower(){
		maxNumber = numberHandler ();
		numberGuessing = numberHandler ();
		txtDisplay.text = "Is your number " + numberGuessing + "?";
	}

	public void checkHigher(){
		minNumber = numberHandler ();
		numberGuessing = numberHandler ();
		txtDisplay.text = "Is your number " + numberGuessing + "?";
	}

	public void playGame(){
		this.minNumber = float.Parse (iptminNumber.text);
		this.maxNumber = float.Parse (iptmaxNumber.text);
		chooseNumber (false);
		enableButton (true);
	}
		

	public void enableButton(bool check){
		txtDisplay.gameObject.SetActive (check);
		numberGuessing = Mathf.RoundToInt ((maxNumber + minNumber) / 2);
		txtDisplay.text = "Pick a Number between " + minNumber + " and " + maxNumber + " but keep it in your mind. Now! Let me guess, Is your number " + numberGuessing + " ?";
		btnYes.gameObject.SetActive (check);
		btnLower.gameObject.SetActive (check);
		btnHigher.gameObject.SetActive (check);
	}

	public void chooseNumber(bool check){
		txtChoose.gameObject.SetActive (check);
		iptmaxNumber.gameObject.SetActive (check);
		iptminNumber.gameObject.SetActive (check);
	}

}
