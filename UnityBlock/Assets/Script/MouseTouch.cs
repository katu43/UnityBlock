using UnityEngine;
using System.Collections;

public class MouseTouch : MonoBehaviour {

	public void Update(){
		PrintClickPos ();
	}

	// タッチの位置を表示
	void PrintClickPos(){
		if (Input.GetMouseButtonDown (0)) {
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Debug.Log ("X: " + tapPoint.x + " Y: " + tapPoint.y);
		}
	}

}
