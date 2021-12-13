using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Start");
        Transform t = GetComponent<Transform>();
        rigid = GetComponent<Rigidbody>();
        mesh_renderer = GetComponent<MeshRenderer>();
        t.position = new Vector3(1, 2, 2);
       
       
        animator = GetComponent<Animator>();
    }
    public  Transform Camera;
    public bool third = false;
    public float sensitivityX = 10f;
    public float sensitivityY = 10f;
    bool jumping = false;
    [SerializeField]float jump_amount;
   private Rigidbody rigid;
    [SerializeField]Vector3 jump_direction;
    public Vector3 moving_vector;
    private MeshRenderer mesh_renderer;
    private float speed = 10f;
    private Animator animator;
    float rotationX = 0f;
    float rotationY = 0f;
    float runspeed = 15f;
    // Update is called once per frame
    void Update () {
        Scene cur_scene = SceneManager.GetActiveScene();
        if (Input.GetKeyDown(KeyCode.E))
        {

            SceneManager.LoadScene(1);
        }
        var v = Camera.transform.localPosition;
       
        animator.SetFloat("speed",0f);

        if (Input.GetKey(KeyCode.W))
        {
            
            rigid.AddForce(speed * Camera.transform.forward);
            animator.SetFloat("speed",speed);
            
            
        }
        
        if (Input.GetKey(KeyCode.S))
        {
           
            rigid.AddForce(speed * Camera.transform.forward*-1);
            animator.SetFloat("speed", speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            
            rigid.AddForce(speed * Camera.transform.right*-1);
            animator.SetFloat("speed", speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
         
            rigid.AddForce(speed * Camera.transform.right);
            animator.SetFloat("speed", speed);


        }
        if (Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.LeftShift))
        {
          
            rigid.AddForce(runspeed * Camera.transform.forward);
            animator.SetFloat("speed", runspeed);


        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            
            rigid.AddForce(runspeed * Camera.transform.forward*-1);
            animator.SetFloat("speed", runspeed);

        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            
            rigid.AddForce(runspeed * Camera.transform.right*-1);
            animator.SetFloat("speed", runspeed);

        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            
            rigid.AddForce(runspeed * Camera.transform.right);
            animator.SetFloat("speed", runspeed);

        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.RightShift))
        {
       
            rigid.AddForce(runspeed * Camera.transform.forward);
            animator.SetFloat("speed", runspeed);


        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.RightShift))
        {
            
            rigid.AddForce(runspeed * Camera.transform.forward*-1);
            animator.SetFloat("speed", runspeed);

        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.RightShift))
        {

            rigid.AddForce(runspeed * Camera.transform.right*-1);
            animator.SetFloat("speed", runspeed);


        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.RightShift))
        { 
            rigid.AddForce(runspeed * Camera.transform.right);
            animator.SetFloat("speed",runspeed);


        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
           
            Debug.Log("current scene name= " + cur_scene.name);
            Debug.Log("current scene build index= " + cur_scene.buildIndex);

            SceneManager.LoadScene(0);
        }
        /*/if(Input.GetKey(KeyCode.R))
         {
             rigid.AddTorque(jump_direction * jump_amount);

         }*/
        if (Input.GetKeyDown(KeyCode.C))
          {
            if(third==false)
            {
                v.z = v.z - 4;
                Camera.transform.localPosition = v;
                third = true;
            }
            else {
                v.z = v.z + 4;
                Camera.transform.localPosition = v;
                third = false; }
        }
        if (Input.GetKeyDown(KeyCode.Space))//按著的時候會一直跳GetKey的話
        {
            if (jumping == false)
            { rigid.AddForce(jump_direction * jump_amount);
                jumping = true;
            }
            v = transform.localPosition;
           
        }

        
        rotationX += Input.GetAxis("Mouse X") * sensitivityX;
        
        rotationY-= Input.GetAxis("Mouse Y") * sensitivityY;

        transform.eulerAngles=new Vector3(0, rotationX, 0);
        Camera.eulerAngles = new Vector3(rotationY, rotationX, 0);



    }
    
      
    


    void OnCollisionEnter(Collision c)
    {
        if (c.transform.tag == "ground")
        {
            jumping = false;
        }
    }
}
