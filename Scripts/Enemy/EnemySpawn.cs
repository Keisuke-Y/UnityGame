using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public bool Spawn = false;

	private GameObject midori;
	private Vector2 p;
	private Vector2 this_pos;

	private float sa;

	static private float WIDTH = 12.80f;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Spawn == false) {
			this.midori = GameObject.Find ("Midori");
			p = this.midori.transform.position;
			this_pos = this.transform.position;

			sa = this_pos.x - p.x;

			if(sa <= WIDTH / 2 + 2.5f){
				Spawn = true;
			}
		}
	}
}
