using UnityEngine;
using System.Collections;

public class GameManeger : MonoBehaviour {

//////////important public valiable////////////
	public bool Pause = false;
	public bool GameOver = false;
	public bool GameClear = false;	
///////////////////////////////////////////////

////////////// moving ///////////////////
	public bool midori_right = false;
	public bool midori_left = false;
	public bool midori_jump = false;
///////////////////////////////////////



	GameObject gameobject;
	CircleCollider2D collider;
	Rigidbody2D rb;

	Vector2 midori;
	Vector2 offset;

	const string CLEAR_NUM = "clear_ninnzuu";


	private int phase;

	private float dt;
	private float timer;




	/// <summary>
	float tim;
	/// </summary>

	// Use this for initialization
	void Start () {
		gameobject = GameObject.Find("Midori");
		collider = gameobject.GetComponent<CircleCollider2D>();
		rb = gameobject.GetComponent<Rigidbody2D>();
		phase = 0;
		timer = 0;
		dt =  Time.deltaTime;

		//////
		tim = 0 ;
		/// 
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.P)) {
			Pause = true;
		}







		if(GameOver == true){
			Debug.Log("GameOver");
			if(phase==0){
				Time.timeScale = 0;
				timer = timer + dt;
				if(timer >= 1){
					phase++;
					Time.timeScale = 1;
				}

			}
			if(phase == 1){
				offset = gameobject.transform.position;
				phase++;
				rb.AddForce(transform.up * 300);
				collider.isTrigger = true;
			}
			if(phase == 2){
				midori = gameobject.transform.position;
				if(midori.y <= -10){
					collider.isTrigger = false;
					phase++;
				}
			}
			if(phase==3){
				////////////
				/// change picture
				////////////
				gameobject.transform.position = offset;
				phase++;
			}

			if(phase==4){
				///////
				///scene_change
				///////
			}


		}
	


		if(Pause == true){
			if(GameOver==false){
				bool stop_flg = true;
				Time.timeScale = 0;
				Debug.Log("pause");
				///////////
				/// gazou no hyoiji to atari hanntei
				/// if(atari hantei ok -> stop_flg = false;)
				//////////
	
				if(tim < 3){
					tim  = tim + dt;
				}
				else{
					stop_flg = false;
				}


				if(stop_flg/*atari hantei ari naraba */ == false){
					//////////////////////
					/// picture change
					////////////////////

					Time.timeScale = 1;
					Pause = false;
					/////
					tim = 0;
					/// 
					Debug.Log("retuen");
				}
			}
			else{
				Pause = false;
			}
		}


		if(GameClear == true){
			int num = PlayerPrefs.GetInt(CLEAR_NUM,0);
			num++;
			PlayerPrefs.SetInt(CLEAR_NUM,num);
			PlayerPrefs.Save();
			//Debug.Log("Clear!!");

			///////////
			/// scene change
			/// /////
			GameClear = false;
		}
	}
}
