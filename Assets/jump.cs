using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class jump : MonoBehaviour {
	public Vector3 forcedirection;
	public float forceAmount;
	private Rigidbody transformRB;
	bool isJumped=true;
	// Use this for initialization
	void Start () {
		transformRB = GetComponent<Rigidbody> ();
	}
	void OnCollisionEnter(Collision x){
		if (x.gameObject.tag != "Zombie"||x.gameObject.tag != "Devil") {
			isJumped = true;
		} else
			isJumped = false;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)&&isJumped==true) {
			transformRB.AddForce (forcedirection*forceAmount);		
			isJumped = false;
		}
	}
}
