using UnityEngine;
using System.Collections;

public class teki3Move : MonoBehaviour {

	Vector2 kumo;
	Vector2 midori;
	Rigidbody2D rb;


	private float sa;

	GameManeger gamemaneger;
	// Use this for initialization
	void Start () {
		kumo = this.transform.position;
		rb = this.GetComponent<Rigidbody2D> ();
		gamemaneger = GameObject.Find("GameManeger").GetComponent<GameManeger>();
	}
	
	// Update is called once per frame
	void Update () {
		midori = GameObject.Find ("Midori").transform.position;

		sa = kumo.x - midori.x;

		if (sa <= 0.7 ) {
			rb.gravityScale = 5.0f;
		}
	}

	void OnCollisionEnter2D ( Collision2D collision ){
		if (collision.gameObject.CompareTag ("Player")) {
			gamemaneger.GameOver = true;
			Debug.Log(gamemaneger.GameOver);
		}
	}
}
