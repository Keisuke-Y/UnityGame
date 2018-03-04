using UnityEngine;
using System.Collections;

public class teki1Move : MonoBehaviour {


	

	private Vector2 p;
	private Vector2 midori;
	private float sa;

	GameObject Midori;
	static private float WIDTH = 12.80f;
	GameManeger gamemaneger = GameObject.Find("GameManeger").GetComponent<GameManeger>();
	
	void Start () {

	}

	void Update () {


		EnemySpawn enemyspawn = gameObject.GetComponent<EnemySpawn>();// get Spawn flag

		if (enemyspawn.Spawn == true && gamemaneger.GameOver == false && gamemaneger.Pause == false) {  			//spawn avaliable
			Midori = GameObject.Find("Midori");
			p = this.transform.position;
			p.x = p.x - 0.03f;
			transform.position = p;
			midori = this.Midori.transform.position;
			sa = midori.x - p.x;

			if(sa >= WIDTH / 2 - 1.0){					// out of display 
				Destroy(gameObject);						//destroy this gameobject
			}
		}
	}

	void OnCollisionEnter2D ( Collision2D collision ){
		if (collision.gameObject.CompareTag ("Player") == true) {
			gamemaneger.GameOver = true;
			Debug.Log(gamemaneger.GameOver);
		}
	}


}
