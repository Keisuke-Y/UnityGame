using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timelimit : MonoBehaviour {

	public Text msg;
	static public int MAX_TIME = 300;


	private bool gear_change = false;


	private float countdown;


	// Use this for initialization
	void Start () {
		msg = GameObject.Find("Canvas/time").GetComponent<Text>();
		countdown = MAX_TIME;
	}
	
	// Update is called once per frame
	void Update () {




		GameManeger gamemaneger = GameObject.Find("GameManeger").GetComponent<GameManeger> ();

		if (gamemaneger.GameOver == false ) {

			if (countdown <= 290) {
				gear_change = true;
			}

			if (countdown <= 0) {
				gamemaneger.GameOver = true;
				gear_change = false;
			}

			if (gamemaneger.Pause == false) {
				if (gear_change == false) {
					countdown = countdown - Time.deltaTime;
				} else {
					countdown = countdown - 5 * Time.deltaTime;
				}
			}
		}
		msg.text = "TIME:"+ Mathf.Floor(countdown);
	}
}
