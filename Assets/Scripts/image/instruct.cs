using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class instruct : MonoBehaviour {

	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
        image.sprite= Resources.Load("instruct", typeof(Sprite)) as Sprite;
    }
    public Image image;
	// Update is called once per frame
	void Update () {
		
	}
}
