using UnityEngine;
using System.Collections;

public class MoveBlock : MonoBehaviour {

	[SerializeField]
	public  GameObject Block;
	public  float WaitTime;
	private Vector3 Position;
	private Vector2 max;

	public void Awake(){
		Position = new Vector3 (0, 4.5f, 9);
		max =  Camera.main.ViewportToWorldPoint (Vector2.zero);
	}

	// Use this for initialization
	public void Start () {
		StartCoroutine ("BlockInstante");
	}

	private IEnumerator BlockInstante(){

		while (true) {
			yield return new WaitForSeconds (2f);
			Instantiate (Block, Position, transform.rotation);
		}
	}

	public void Update(){
		DeleteBlock ();
	}

	private void DeleteBlock(){

		// ブロックが画面外に出たら削除
		if (max.y >= transform.position.y) {
			Debug.Log ("max.y : " + max.y + "obj.y : " + transform.position.y);
			Destroy(gameObject);
		}
	}

}
