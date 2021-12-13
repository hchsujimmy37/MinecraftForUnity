using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        Debug.Log("Start");
        Transform t = GetComponent<Transform>();

        mesh_renderer = GetComponent<MeshRenderer>();
        
    }
    public Vector3 moving_vector;
    private MeshRenderer mesh_renderer;
    private float moving_speed = 10f;
    public bool third = false;
    // Update is called once per frame
    public Transform dirttt;
    public Inventory inventory;
    void Update()
    {

        Transform t = GetComponent<Transform>();
     
           
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit ray_cast_hit;
            if (Physics.Raycast(ray, out ray_cast_hit))
            {
                if (ray_cast_hit.transform.name == "Viking_Axes")
                {

                }
                else
                {
                  
                   
                }
            }
        }
     
        /*/if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.right;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.forward * 2;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.back * 2;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.left * 2;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.right * 2;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.RightShift))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.forward * 2;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.RightShift))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.back * 2;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.RightShift))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.left * 2;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.RightShift))
        {
            transform.localPosition += moving_speed * Time.deltaTime * Vector3.right * 2;
        }
        if (Input.GetKey(KeyCode.C))
        {
            if(third==false)
            {
                var v = transform.localPosition;
                v.z = v.z + 4;
                transform.localPosition = v;
                third=true;
            }
            else if (third == true)
            {
                var v = transform.localPosition;
                v.z = v.z - 4;
                transform.localPosition = v;
                third = false;
            }
         
        }
    }*/
    }
}
