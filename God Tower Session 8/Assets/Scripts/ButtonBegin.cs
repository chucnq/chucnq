using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonBegin : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler{

	public Text txtBegin;

	#region IPointerEnterHandler implementation

	public void OnPointerEnter (PointerEventData eventData)
	{
		StartCoroutine (BlinkText ());
	}

	#endregion

	#region IPointerExitHandler implementation

	public void OnPointerExit (PointerEventData eventData)
	{	
		StartCoroutine (StopBlinkText ());
	}

	#endregion

	public IEnumerator BlinkText(){

		while(true){
			txtBegin.text = "";
			yield return new WaitForSeconds (.1f);
			txtBegin.text = "Begin";
			yield return new WaitForSeconds (.1f);
		}
	}

	public IEnumerator StopBlinkText(){
		while (true) {
			txtBegin.text = "Begin";
			yield return new WaitForSeconds (0);
		}
			
						
	}
}
