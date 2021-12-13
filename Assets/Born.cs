using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Born : MonoBehaviour {
	public int born_time,Day_time;
	public Transform mon_1, mon_2;
	public Vector3 pos;
	// Use this for initialization
	void Start () {
		born_time = 0;
		Day_time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Day_time++;
		if (Day_time >= 3000)
			Day_time = 0;
		if (born_time > 0) {
			born_time--;
		} else if (Day_time < 2250 && Day_time>=750 &&born_time==0) {
			Random.InitState(System.Guid.NewGuid().GetHashCode());
			int a = Random.Range (0,10000);
			if (a >= 8000) {
				Transform zombie = Instantiate (mon_1);
				zombie.parent = transform;
				pos.x = Random.Range (80.0f, 180.0f);
				pos.z = Random.Range (-100.0f, 30.0f);
				pos.y = 2f;
				zombie.position = pos;
				zombie.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
				zombie.gameObject.tag = "Zombie";
			}
			else if (a < 1000) {
				Transform devil = Instantiate (mon_2);
				devil.parent = transform;
				pos.x = Random.Range (80.0f, 180.0f);
				pos.z = Random.Range (-100.0f, 30.0f);
				pos.y = 2f;
				devil.position = pos;
				devil.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
				devil.gameObject.tag = "Devil";
			}
			born_time = 20;
		}
	}
}
