using UnityEngine;
using System.Collections;

public class hole_trap1 : MonoBehaviour {

	private float HOLE_WIDTH = 2.0f;
	
	private bool hantei = false;
	GameObject gameobject;
	bool flg_once;
	float buf;
	float buf_2;
	
	
	// Use this for initialization
	void Start () {
		gameobject = GameObject.Find("floor1");
		flg_once = false;
		buf = 2.0f*Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = this.transform.position;
		Vector2 pos_midori = GameObject.Find ("Midori").transform.position;

		
		if (Mathf.Abs (pos.x - pos_midori.x) <= HOLE_WIDTH / 2.0f) {
			buf_2 = buf_2 + buf;
			if(buf_2 <= 2.0f && buf_2>0){
				Vector2 pos_buf = this.transform.position;
				pos_buf.x = pos_buf.x + buf;
				this.transform.position = pos_buf;
			}

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
