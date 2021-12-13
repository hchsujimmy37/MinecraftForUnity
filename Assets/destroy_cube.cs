using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_cube : MonoBehaviour {
	Animator anime;
	public int CD;
	public GameObject x,mon;
	public GameObject actor;
	// Use this for initialization
	void Start () {
		anime = GetComponent<Animator>();
		CD = 20;
		anime.SetBool ("hacking",false);
	}

	// Update is called once per frame
	void Update () {
		Debug.Log (anime.GetBool("hacking")+","+CD);
		if (Input.GetMouseButtonDown (0)&& anime.GetBool("hacking")==false) {
			RaycastHit raycasthit;
			anime.SetBool ("hacking",true);
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if(Physics.Raycast(ray,out raycasthit)){
				float x_dis = actor.gameObject.transform.position.x - raycasthit.collider.gameObject.transform.position.x;
				float y_dis = actor.gameObject.transform.position.y - raycasthit.collider.gameObject.transform.position.y;
				float z_dis = actor.gameObject.transform.position.z - raycasthit.collider.gameObject.transform.position.z;
				if(raycasthit.collider.gameObject.tag!="Player"&&raycasthit.collider.gameObject.tag!="Ground"&&Mathf.Sqrt (Mathf.Pow (x_dis, 2) + Mathf.Pow (z_dis, 2)) <= 8f&&y_dis<=2f){
					if(raycasthit.collider.gameObject.tag=="Zombie"){
						mon=raycasthit.collider.gameObject;
						mon.GetComponent<zombie_setting> ().zombie_life -= 6;
						raycasthit.collider.gameObject.transform.localPosition += transform.forward * 2f;
					}
					else if(raycasthit.collider.gameObject.tag=="Devil"){
						mon=raycasthit.collider.gameObject;
						mon.GetComponent<devil_Setting> ().devil_life -= 6;
						raycasthit.collider.gameObject.transform.localPosition += transform.forward * 2f;
					}
					else x=raycasthit.collider.gameObject;
				}
			}
		}
		if (CD <= 0 && anime.GetBool("hacking")==true) {
			CD = 20;
			anime.SetBool ("hacking",false);
			x.SetActive(false);

		} else if(CD>0&& anime.GetBool("hacking")==true) {
			CD--;
		}

	}
}
