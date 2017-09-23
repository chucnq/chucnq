using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Level5ImageController : EventTrigger {

	Vector3 distance;

	void Start(){

		// Gioi han anh xuat hien ngau nhien trong khung panel
		// transform chinh la anh
		transform.localPosition = new Vector3 (Random.Range (-223, 223), Random.Range (-167, 193), 0);
	}

	public override void OnBeginDrag(PointerEventData evData){

		// Lay vi tri cua con chuot
		Vector3 screenMousePos = Input.mousePosition;
		// Dua con chuot len he truc toa do
		Vector3 worldMousePos = Camera.main.ScreenToWorldPoint (screenMousePos);

		// Lay toa do canvas, tach roi thang bo
		Vector3 canvasMousePos = transform.parent.InverseTransformPoint (worldMousePos);

		// Lay vi tri giua con tro chuot va tam cua anh
		distance = canvasMousePos - transform.localPosition;



	}

	public override void OnDrag(PointerEventData evData){
	
		// Lay vi tri cua con chuot
		Vector3 screenMousePos = Input.mousePosition;
		// Dua con chuot len he truc toa do
		Vector3 worldMousePos = Camera.main.ScreenToWorldPoint (screenMousePos);

		// Lay toa do canvas, tach roi thang bo
		Vector3 canvasMousePos = transform.parent.InverseTransformPoint (worldMousePos);

		// Gioi han trong khung
		float restrictedX = Mathf.Clamp (canvasMousePos.x, -223, 223);
		float restrictedY = Mathf.Clamp (canvasMousePos.y, -167, 193);

		// Truyen vao cac gia tri x,y,z
		// z giu nguyen chi thay doi x,y
//		transform.localPosition = new Vector3 (
//										restrictedX, 
//										restrictedY, 
//										transform.localPosition.z);

		// Lay vi tri con chuot moi
		Vector3 newMousePos = new Vector3 (restrictedX, restrictedY, 0);


		// ??
		Vector3 expectedImagePos = newMousePos - distance;

		transform.localPosition = new Vector3 (
			Mathf.Clamp(expectedImagePos.x,-223,223),
			Mathf.Clamp(expectedImagePos.y,-167,193),
			transform.localPosition.z
		);

	}

}
