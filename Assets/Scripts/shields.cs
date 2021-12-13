using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shields : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Transform c = Instantiate(shieldss);
        c.parent = transform;
        int number1 = Random.Range(-30, 50);
        int number2 = Random.Range(2, 10);
        int number3 = Random.Range(-30, 50);
        c.localPosition = new Vector3(number1, number2, number3);

    }
    public Transform shieldss;
    [SerializeField]
    Vector3 rotation_direction;
    // Update is called once per frame
    void Update () {
		
	}
}
