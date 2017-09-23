using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerPassLevel1 : MonoBehaviour {

	public string nextScenes;
	public Button btnNext;

	// Use this for initialization
	void Start () {


	}

	public void Next(){
		SceneManager.LoadScene (nextScenes);
	}

}
