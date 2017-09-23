using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerLevel1 : MonoBehaviour {

	// UI Components
	public Text hintText,levelText;
	public InputField iptPassword;

	public Button btnSubmit;

	// Declare variables
	public string levelAnswer;
	public string levelNumber;
	public string levelHint;
	public string nextScene;


	// Use this for initialization
	void Start () {

		hintText.text = levelHint;

	}


	public void checkAnswer(){

		if (iptPassword.text == levelAnswer) {
			//TODO: Change Scene
			hintText.text = "Congrats!!!";
			hintText.color = Color.green;

			SceneManager.LoadScene (nextScene);

		} else {
			hintText.text = "Access Denied!!!";
			hintText.color = Color.red;
			iptPassword.text = "";
			iptPassword.ActivateInputField ();
		}

	}
}
