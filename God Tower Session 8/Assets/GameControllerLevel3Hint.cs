using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerLevel3Hint : MonoBehaviour {

	// Normal variables
	public string nextScenes;

	// UI Components
	public Button btnBack;

	// Use this for initialization
	void Start () {
		
	}
	
	public void changeScenes(){
		SceneManager.LoadScene (nextScenes);
	}
}
