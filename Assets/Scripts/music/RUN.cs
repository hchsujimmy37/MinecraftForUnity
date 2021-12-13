using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RUN : MonoBehaviour {
    private AudioSource bgm;
    private bool isplaying = false;
    [SerializeField]
    AudioClip clip1;
    [SerializeField]
    AudioClip clip2;
    [SerializeField]
    AudioClip clip3;
    // Use this for initialization
    void Start () {
        bgm = GetComponent<AudioSource>();
        bgm.clip = clip2;
        bgm.Stop();
    }
	
	// Update is called once per frame
	void Update () {
        if(isplaying==true)
        {
            bgm.clip = clip2;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                if (!Input.GetKey(KeyCode.RightShift))
                {
                    isplaying = false;
                    bgm.clip = clip1;
                    bgm.Play();
                }
                else
                {
                    isplaying = true;
                    bgm.clip = clip2;
                    bgm.Play();
                }
            }
            else
            {
                isplaying = true;
                bgm.clip = clip2;
                bgm.Play();
            }
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            bgm.Stop();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            bgm.Stop();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            bgm.Stop();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            bgm.Stop();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                if (!Input.GetKey(KeyCode.RightShift))
                {
                    isplaying = false;
                    bgm.clip = clip1;
                    bgm.Play();
                }
                else
                {
                    isplaying = true;
                    bgm.clip = clip2;
                    bgm.Play();
                }
            }
            else
            {
                isplaying = true;
                bgm.clip = clip2;
                bgm.Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                if (!Input.GetKey(KeyCode.RightShift))
                {
                    isplaying = false;
                    bgm.clip = clip1;
                    bgm.Play();
                }
                else
                {
                    isplaying = true;
                    bgm.clip = clip2;
                    bgm.Play();
                }
            }
            else
            {
                isplaying = true;
                bgm.clip = clip2;
                bgm.Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                if (!Input.GetKey(KeyCode.RightShift))
                {
                    isplaying = false;
                    bgm.clip = clip1;
                    bgm.Play();
                }
                else
                {
                    isplaying = true;
                    bgm.clip = clip2;
                    bgm.Play();
                }
            }
            else
            {
                isplaying = true;
                bgm.clip = clip2;
                bgm.Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            isplaying = true;
            bgm.clip = clip2;
            bgm.Play();
        }
        if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.LeftShift))
        {

            bgm.Stop();
        }
        if (Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.LeftShift))
        {
            bgm.Stop();
        }
        if (Input.GetKeyUp(KeyCode.S) && Input.GetKeyUp(KeyCode.LeftShift))
        {
            bgm.Stop();
        }
        if (Input.GetKeyUp(KeyCode.D) && Input.GetKeyUp(KeyCode.LeftShift))
        {
            bgm.Stop();
        }
        if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.RightShift))
        {
            bgm.Stop();
        }
        if (Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.RightShift))
        {
            bgm.Stop();
        }
        if (Input.GetKeyUp(KeyCode.S) && Input.GetKeyUp(KeyCode.RightShift))
        {
            bgm.Stop();
        }
        if (Input.GetKeyUp(KeyCode.D) && Input.GetKeyUp(KeyCode.RightShift))
        {
            bgm.Stop();
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            isplaying = true;
            bgm.clip = clip2;
            bgm.Play();
        }
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            isplaying = true;
            bgm.clip = clip2;
            bgm.Play();
        }
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            isplaying = true;
            bgm.clip = clip2;
            bgm.Play();
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.RightShift))
        {
            isplaying = true;
            bgm.clip = clip2;
            bgm.Play();
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.RightShift))
        {
            isplaying = true;
            bgm.clip = clip2;
            bgm.Play();
        }
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.RightShift))
        {
            isplaying = true;
            bgm.clip = clip2;
            bgm.Play();
        }
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.RightShift))
        {
            isplaying = true;
            bgm.clip = clip2;
            bgm.Play();
        }
       if(Input.GetKeyDown(KeyCode.LeftShift)|| Input.GetKey(KeyCode.RightShift))
        {
            bgm.clip = clip2;
            isplaying = true;
        }
    }
}
