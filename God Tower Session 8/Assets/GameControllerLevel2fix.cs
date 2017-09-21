using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerLevel2fix : MonoBehaviour {

	// Declare normal variables
	public string levelAnswer;
	public string levelNumber;
	public string levelHint;
	public string nextScene;

	// UI Components
	public Text hintText,levelText;
	public Button btnSubmit;
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

			new WaitForSeconds (1.5f);
			SceneManager.LoadScene (nextScene);

		} else {

			hintText.text = "Access Denied!!!";
			hintText.color = Color.red;
			iptPassword.text = "";
			iptPassword.ActivateInputField ();

		}

	}
		
}
