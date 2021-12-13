using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecoin : MonoBehaviour {
    [SerializeField]
    Vector3 rotation_direction;
    [SerializeField]
    float rotatespeed;
    private Rigidbody rigid;
	// Use this for initialization
	void Start () {
        
        rigid = GetComponent<Rigidbody>();
        int number1 = Random.Range(-30, 50);
        int number2 = Random.Range(2, 10);
        int number3 = Random.Range(-30, 50);
        gameObject.transform.localPosition = new Vector3(number1, number2, number3);
    }
    
    // Update is called once per frame
    void Update () {
        rigid.AddTorque(rotatespeed * rotation_direction);//放update 讓可以一直旋轉
    }
}
