using UnityEngine;
using System.Collections;

public class ColliderTriggerParent : MonoBehaviour {
	
	Rigidbody2D rb;


	// Use this for initialization
	void Start () {
	
	}
	
	public void RelayOnTriggerEnter(Collider2D collider){
		rb = GameObject.Find ("Midori").GetComponent<Rigidbody2D> ();
		GameObject gameobject = collider.gameObject;
		Destroy (gameobject);
		rb.AddForce(transform.up * 400);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}