using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class background : MonoBehaviour {

    private bool isblack = false;
    private Image background_img;
	// Use this for initialization
	void Start () {
        background_img = GetComponent<Image>();
	}
	public void changecolor()
    {
        if (isblack)
        {
            background_img.color = new Color(255, 255, 255, 100);
            isblack = false;
        }
        else
        {
            background_img.color = new Color(0, 0, 0, 100);
            isblack = true;

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
