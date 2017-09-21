using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerLevel3 : MonoBehaviour {

	// Declare variables
	public string levelAnswer;
	public string levelNumber;
	public string levelHint;
	public string nextScene;
	public string hintScene;

	// UI Components
	public Text hintText,levelText;
	public Button btnSubmit,btnHint;
	public InputField iptPassword;

	// Use this for initialization
	void Start () {
		hintText.text = levelHint;
	}

	public void checkAnswer(){

		if (iptPassword.text == levelAnswer) {
			// TODO: Change Scene
			hintText.text = "Congrats!!!";
			hintText.color = Color.green;
		} else {

			hintText.text = "Access Denied!!!";
			hintText.color = Color.red;
			iptPassword.text = "";
			iptPassword.ActivateInputField ();

		}

	}
	
	public void changeHintScenes(){
		SceneManager.LoadScene (hintScene);
	}

}
