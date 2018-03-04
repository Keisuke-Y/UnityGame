using UnityEngine;
using System.Collections;


public class  midoriMove: MonoBehaviour {
	GameManeger gamemaneger;
	Rigidbody2D rb;
	Vector3 p;
	public float force =  100.0f;
	public int JumpCount = 0;
	public int MaxJump = 2;
	private int counter;

	bool push_right = false;
	public int jump_count;

	public bool l_move;
	public bool r_move;
	public bool j_move;

	// Use this for initialization
	void Start () {
		//Vector3 p = transform.position;
		rb = GetComponent<Rigidbody2D> ();

		Vector2 pos;
		pos.x = -3.0f;pos.y =-1.38f;
		this.gameObject.transform.position = pos;
		counter = 0;
		jump_count = 0;
		l_move = false;
		r_move = false;
		j_move = false;
	}
	
	// Update is called once per frame
	private void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) {
			//l_midori_move();
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			//r_midori_move();
		}

		if (r_move == true) {
			gamemaneger = GameObject.Find ("GameManeger").GetComponent<GameManeger> ();
			if (gamemaneger.GameOver == false && gamemaneger.Pause == false) {
				p = this.transform.position;
				p.x = p.x + 0.1f;
				this.transform.position = p;
				r_move = false;
			}
		}
		

			if(l_move == true){
				gamemaneger = GameObject.Find ("GameManeger").GetComponent<GameManeger> ();
				if (gamemaneger.GameOver == false && gamemaneger.Pause == false) {
					p = this.transform.position;
					p.x = p.x - 0.1f;
					this.transform.position = p;
					l_move = false;
				}
			}

			if(j_move == true){
				Rigidbody2D rb = this.GetComponent<Rigidbody2D> ();
				gamemaneger = GameObject.Find("GameManeger").GetComponent<GameManeger>();
				if (gamemaneger.GameOver == false && gamemaneger.Pause == false) {
					rb.AddForce(transform.up * 400.0f);
					j_move= false;
				}

			}

			

	}
	

	/*public void r_midori_move(){
		gamemaneger = GameObject.Find("GameManeger").GetComponent<GameManeger>();
		if (gamemaneger.GameOver == false && gamemaneger.Pause == false) {
			p = this.transform.position;
			p.x = p.x + 0.1f;
			this.transform.position = p;
		}
	}

	public void l_midori_move(){
		gamemaneger = GameObject.Find ("GameManeger").GetComponent<GameManeger> ();
		if (gamemaneger.GameOver == false && gamemaneger.Pause == false) {
			p = this.transform.position;
			p.x = p.x - 0.1f;
			this.transform.position = p;
		}
	}
		
	public void j_midori_move(){
		Rigidbody2D rb = this.GetComponent<Rigidbody2D> ();
		gamemaneger = GameObject.Find("GameManeger").GetComponent<GameManeger>();
		if (gamemaneger.GameOver == false && gamemaneger.Pause == false) {
			rb.AddForce(transform.up * 400.0f);
		}
	}*/

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.CompareTag ("Floor") == true) {
			jump_count = 0;
		}
	}

}
