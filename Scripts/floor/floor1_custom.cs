using UnityEngine;
using System.Collections;

public class floor1_custom : MonoBehaviour {

	const float WIDTH = 12.80f;
	Vector2 START_POS;

	Vector2 this_pos;
	Vector2 cam_pos;
	Vector2 pos;

	GameObject gameobject;
	// Use this for initialization
	void Start () {
		START_POS.x = 0;
		START_POS.y = 0;
		gameobject = GameObject.Find("GameManeger");
		this.transform.position = START_POS;
	}
	
	// Update is called once per frame
	void Update () {
		cam_pos = Camera.main.transform.position;
		this_pos = this.transform.position;
		pos = this_pos;
		GameManeger gamemaneger = gameobject.GetComponent<GameManeger> ();

		if (gamemaneger.GameOver == false && gamemaneger.Pause == false) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				pos.x = pos.x - 0.1f * 3.0f / 4.0f ;
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				pos.x = pos.x + 0.1f * 3.0f / 4.0f ;
			}


			if(cam_pos.x - this_pos.x >= 1.5f * WIDTH){
				pos.x = pos.x + 3.0f * WIDTH;
			}
			else if(this_pos.x - cam_pos.x >= 1.5f * WIDTH){
				pos.x = pos.x - 3.0f * WIDTH;
			}
			this.transform.position = pos;
		}

		
	}
}
