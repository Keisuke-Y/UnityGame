using UnityEngine;
using System.Collections;

public class teki2Move : MonoBehaviour {


	private bool flg=false;
	private bool step_flg = true;
	
	private Vector2 p;
	private Vector2 midori;
	private float sa;
	
	GameObject Midori;
	Rigidbody2D rb;

	static private float WIDTH = 12.80f;
	static private float FORTH =  300.0f;

	GameManeger gamemaneger = GameObject.Find("GameManeger").GetComponent<GameManeger>();

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	

	void Update () {
		EnemySpawn enemyspawn = GetComponent<EnemySpawn> ();// get Spawn flag

		if (enemyspawn.Spawn == true && gamemaneger.GameOver == false && gamemaneger.Pause == false) {  								//spawn avaliable
			Midori = GameObject.Find ("Midori");
			p = this.transform.position;
			p.x = p.x - 0.03f;
			if(step_flg == true){
				this.rb.AddForce(transform.up * FORTH);
				step_flg = false;
			}
			transform.position = p;
			midori = this.Midori.transform.position;
			sa = midori.x - p.x;
			
			if (sa >= WIDTH / 2 - 1.0) {					// out of display 
				Destroy (gameObject);						//destroy this gameobject
			}
		}
	}

	void OnCollisionEnter2D ( Collision2D collision ){
		if ( collision.gameObject.CompareTag ("Floor") ) {
			step_flg = true;
		}
		if (collision.gameObject.CompareTag ("Player") == true) {
			gamemaneger.GameOver = true;
			Debug.Log(gamemaneger.GameOver);
		}
	}
}
	
