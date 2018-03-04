using UnityEngine;
using System.Collections;

public class touch_screen : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		touch_check ();
	}

	void touch_check(){
		if(Input.touchCount > 0){
			for(int i= 0; i<Input.touchCount; i++ ){
				Touch _touch = Input.GetTouch(i);
				Vector3 scr_pos = _touch.position;
				Vector3 tap_pos = Camera.main.ScreenToWorldPoint(scr_pos);
				Collider2D col = Physics2D.OverlapPoint(tap_pos);
				if(col == true){
					RaycastHit2D hitObject = Physics2D.Raycast(tap_pos,-Vector2.up);

					if(hitObject.collider.gameObject.CompareTag("l_button") == true){
						midoriMove midorimove =  GameObject.Find("Midori").GetComponent<midoriMove>();
						//midorimove.l_midori_move();
						GameObject.Find("Midori").GetComponent<midoriMove>().l_move = true;

					}

					else if(hitObject.collider.gameObject.CompareTag("r_button") == true){
						midoriMove midorimove =  GameObject.Find("Midori").GetComponent<midoriMove>();
						//midorimove.r_midori_move();
						GameObject.Find("Midori").GetComponent<midoriMove>().r_move = true;
					}

					else if(hitObject.collider.gameObject.CompareTag("j_button")== true){
						midoriMove midorimove = GameObject.Find("Midori").GetComponent<midoriMove>();
						if(_touch.phase == TouchPhase.Began && midorimove.jump_count <= 1){
							//midorimove.j_midori_move();
							GameObject.Find("Midori").GetComponent<midoriMove>().j_move =true;
							GameObject.Find("Midori").GetComponent<midoriMove>().jump_count = GameObject.Find("Midori").GetComponent<midoriMove>().jump_count + 1;
						}
					}
				}
			}
		}
	}
}
