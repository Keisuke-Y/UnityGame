using UnityEngine;
using System.Collections;

public class ChildeColliderTrigger : MonoBehaviour {
	
	ColliderTriggerParent collidertriggerparent;
	
	// Use this for initialization
	void Start () {
		GameObject gameobject = this.transform.parent.gameObject;
		collidertriggerparent = gameobject.GetComponent<ColliderTriggerParent> ();
	}
	
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.CompareTag("Enemy")){
			collidertriggerparent.RelayOnTriggerEnter(collider);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}