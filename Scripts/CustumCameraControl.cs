using UnityEngine;
using System.Collections;

public class CustumCameraControl : MonoBehaviour {
	GameObject midori;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		this.midori = GameObject.Find("Midori");
		this.offset = this.transform.position - this.midori.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (
				this.midori.transform.position.x + this.offset.x,    //プレーヤーの横座標のみを追いかける 
				this.transform.position.y,
				this.transform.position.z);

	}
}
