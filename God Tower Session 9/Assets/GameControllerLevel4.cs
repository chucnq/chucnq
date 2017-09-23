using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerLevel4 : MonoBehaviour {

	// Declare variables
	public string levelAnswer;
	public string levelNumber;
	public string levelHint;
	public string nextScene;
	public string hintScene;
	public List<GameObject> listImage;
	private int hintCurrentIndex = 0;

	// UI Components
	public Text hintText,levelText;
	public Button btnSubmit,btnHint;
	public InputField iptPassword;

	// Use this for initialization
	void Start () {
		hintText.text = levelHint;
		StartCoroutine (ChangeTextLevelCoroutine ());
	}

	IEnumerator ChangeTextLevelCoroutine(){
		while (true) {
			yield return new WaitForSeconds (2f);
			levelText.text = levelNumber;
			yield return new WaitForSeconds (2f);
			levelText.text = "LEVELS";
		}

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

	public void OnHintButtonClick(){
		hintCurrentIndex += 1;

		if (hintCurrentIndex == listImage.Count - 1) {
			btnHint.transform.transform.localScale = new Vector3 (-1, 1, 1);
		} else {
			btnHint.transform.transform.localScale = new Vector3 (1, 1, 1);
		}

		if (hintCurrentIndex == listImage.Count) {
			hintCurrentIndex = 0;
		} 

		for (int i = 0; i < listImage.Count; i++) {

			if (i == hintCurrentIndex) {
				listImage [i].gameObject.SetActive (true);
			} else {
				listImage [i].gameObject.SetActive (false);
			}

		}
	}
		
}
