using UnityEngine;
using System.Collections;

public class hole1 : MonoBehaviour {

	private float HOLE_WIDTH = 2.0f;

	private bool hantei = false;
	GameObject gameobject;
	bool flg_once;


	// Use this for initialization
	void Start () {
		gameobject = GameObject.Find("floor1");
		flg_once = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = this.transform.position;
		Vector2 pos_midori = GameObject.Find ("Midori").transform.position;


		if (Mathf.Abs (pos.x - pos_midori.x) <= HOLE_WIDTH / 2.0f) {
			gameobject.GetComponent<BoxCollider2D> ().isTrigger = true;
		} else {
			gameobject.GetComponent<BoxCollider2D>().isTrigger = false;
		}


		if (pos_midori.y <= -10) {
			if(flg_once == false){
				GameObject.Find("GameManeger").GetComponent<GameManeger>().GameOver = true;
				flg_once = true;
			}
		}
	}


}
