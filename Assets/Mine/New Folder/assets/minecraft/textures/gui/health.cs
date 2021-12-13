using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class health : MonoBehaviour {
	public Image[] HeartImage;
	public Sprite[] Heartsprite;
	public int hp=20;
	// Use this for initialization
	void Start () {
		
	}
	public void decreaseheart(int a){
		hp -= a; int i;
		for (i= 0; i < hp / 2; i++) {
			HeartImage [i].sprite = Heartsprite [1];
		}
		if (hp % 2 != 0) {
			HeartImage [i].sprite = Heartsprite [2];
			i++;
		}
		while (i < 10) {
			HeartImage [i].sprite = Heartsprite [0];
			i++;
		}
	}
	// Update is called once per frame
	void Update () {
		if (hp <= 0) {
			SceneManager.LoadScene(3);
		}
	}
}
