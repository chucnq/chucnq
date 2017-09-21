using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlllerLevel2 : MonoBehaviour {

	// Declare normal variables
	public string levelAnswer;
	public string levelNumber;
	public string levelHint;
	public string nextScene;

	// UI Components
	public Text hintText,levelText;
	public Button btnSubmit, btnNext;
	public InputField iptPassword;

	// Use this for initialization
	void Start () {
		hintText.text = levelHint;
		btnNext.gameObject.SetActive (false);
	}

	public void checkAnswer(){

		if (iptPassword.text == levelAnswer) {
			// TODO: Change Scene
			hintText.text = "Congrats!!!";
			hintText.color = Color.green;
			btnNext.gameObject.SetActive (true);
		} else {

			hintText.text = "Access Denied!!!";
			hintText.color = Color.red;
			iptPassword.text = "";
			iptPassword.ActivateInputField ();

		}

	}

	public void changeScenes(){
		SceneManager.LoadScene (nextScene);
	}

}
