using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devil_Setting : MonoBehaviour {
	public Transform zom,actor;
	Animator Anime;
	float x_speed,z_speed,x_dis,z_dis;
	public Light day;
	public GameObject life;
	public int devil_life=10;
	// Use this for initialization
	void Start () {
		zom =GetComponent<Transform>();
		zom.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
		Anime= GetComponent<Animator>();
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			actor.transform.localPosition -= transform.forward*2f;
			life.GetComponent<health>().decreaseheart (5);
		}
	}
	// Update is called once per frame
	void Update () {
		Anime.SetBool ("moving",false); Anime.SetBool ("attacking",false);
		x_dis = zom.position.x-actor.position.x;
		z_dis = zom.position.z-actor.position.z;
		x_speed = (x_dis / (Mathf.Sqrt (Mathf.Pow (x_dis, 2) + Mathf.Pow (z_dis, 2)))) * 0.6f;
		z_speed = (z_dis / (Mathf.Sqrt (Mathf.Pow (x_dis, 2) + Mathf.Pow (z_dis, 2)))) * 0.6f;
		if (Mathf.Sqrt (Mathf.Pow (x_dis, 2) + Mathf.Pow (z_dis, 2)) <= 20f) {
			Anime.SetBool ("moving",true);
			transform.Translate (-x_speed,0f,-z_speed);
			Vector3 targetDir = actor.transform.position - zom.transform.position;
			Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, 0.1f, 0.0F);
			zom.transform.rotation = Quaternion.LookRotation (newDir);
		}
		if (Mathf.Sqrt (Mathf.Pow (x_dis, 2) + Mathf.Pow (z_dis, 2)) <= 8f) {
			Random.InitState(System.Guid.NewGuid().GetHashCode());
			int a = Random.Range (0,10000);
			if (a > 8000) {
				Anime.SetBool ("attacking",true);
			}
		}
		if (day.transform.rotation.x>=0 && zom.gameObject.tag=="Devil") {
			Destroy (zom.transform.gameObject);
		}
		if (devil_life <= 0 && zom.gameObject.tag=="Devil") {
			Destroy (zom.transform.gameObject);
		}
	}
}
