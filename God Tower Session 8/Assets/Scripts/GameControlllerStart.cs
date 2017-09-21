using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameControlllerStart : MonoBehaviour{

	// Declare normal variables
	public string nextScenes;

	// UI Components
	public Button btnBegin,btnContinue;
	public Text txtBegin,txtContinue;

	// Use this for initialization
	void Start () {
		
	}
		

	public void Begin(){
		SceneManager.LoadScene (nextScenes);
	}
}
