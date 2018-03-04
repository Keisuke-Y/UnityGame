using UnityEngine;
using System.Collections;

public class custumFloorCtrl : MonoBehaviour {


	public    static float WIDTH = 12.80f;    //素材パーツの幅
	public    static    int    MODEL_NUM=3;    //構成する数
	float totalWidth;
	Vector3 initialPos;
	Vector2 midori;
	int code;

	// Use this for initialization
	void Start () {
		totalWidth = WIDTH * MODEL_NUM;
		initialPos = this.transform.position;
		code = 2;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 camPos= Camera.main.transform.position;
		Vector3 floorPos = initialPos;
		float sa;
		midori = GameObject.Find ("Midori").transform.position;



		Vector2 p = this.transform.position;    /// idoukyori
		if (Input.GetKey (KeyCode.LeftArrow)) {
			p.x -= 0.1f * 3 / 4;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			p.x += 0.1f * 3 / 4;
		}

		if ( midori.x - p.x >= WIDTH) {
			p.x = p.x + WIDTH;
		}
		else if(p.x - midori.x >= WIDTH){
			p.x = p.x - WIDTH;
		}

		Vector2 pos = initialPos;
		pos.x = p.x;


		if (code == 1) {
			this.transform.position = pos;
		}
		if(code == 2){
			pos.x = pos.x + WIDTH;
			this.transform.position = pos;
			pos.x = pos.x - WIDTH;
		}
		if(code == 3){
			pos.x = pos.x -WIDTH;
			this.transform.position =pos;
			pos.x = pos.x + WIDTH;
		}





	}
}
