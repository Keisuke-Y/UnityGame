using UnityEngine;
using System.Collections;

public class r_button_move : MonoBehaviour {


	Vector2 midori_pos;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		midori_pos = GameObject.Find ("Midori").transform.position;
		midori_pos.y = -2.8f;
		this.transform.position = midori_pos;
	}
}
