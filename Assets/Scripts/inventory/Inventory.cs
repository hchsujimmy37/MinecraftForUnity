using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    void Start()
    {
        mesh_renderer = GetComponent<MeshRenderer>();
        button1 = border1.GetComponent<Button>();
        button2 = border2.GetComponent<Button>();
        button3 = border3.GetComponent<Button>();
        button4 = border4.GetComponent<Button>();
        button5 = border5.GetComponent<Button>();
        button6 = border6.GetComponent<Button>();
        button7 = border7.GetComponent<Button>();
        button8 = border8.GetComponent<Button>();
        button9 = border9.GetComponent<Button>();
        button10 = border10.GetComponent<Button>();
        image1 = slot1.GetComponent<Image>();
        image2 = slot2.GetComponent<Image>();
        image3 = slot3.GetComponent<Image>();
        image4 = slot4.GetComponent<Image>();
        image5 = slot5.GetComponent<Image>();
        image6 = slot6.GetComponent<Image>();
        image7 = slot7.GetComponent<Image>();
        image8 = slot8.GetComponent<Image>();
        image9 = slot9.GetComponent<Image>();
        image10 = slot10.GetComponent<Image>();
        image11 = slot11.GetComponent<Image>();
        tree = Resources.Load("log", typeof(Sprite)) as Sprite;
        gold= Resources.Load("gold_ore", typeof(Sprite)) as Sprite;
		grass=Resources.Load("grass", typeof(Sprite)) as Sprite;
		glass=Resources.Load("glass", typeof(Sprite)) as Sprite;
		Cube[0]=Resources.Load("stone", typeof(Sprite)) as Sprite;
		Cube[1]=Resources.Load("gold_ore", typeof(Sprite)) as Sprite;
		Cube[2]=Resources.Load("glass", typeof(Sprite)) as Sprite;
		Cube[3]=Resources.Load("dirt", typeof(Sprite)) as Sprite;
		Cube[4]=Resources.Load("brick", typeof(Sprite)) as Sprite;
		Cube[5]=Resources.Load("log", typeof(Sprite)) as Sprite;
		Cube[6]=Resources.Load("grass", typeof(Sprite)) as Sprite;
        block = GetComponent<Transform>();
        for(int i=0;i<10;i++)
        {
            yesno[i] = false;
        }
        button1.onClick.AddListener(delegate
        {
            btn1click();
        });
        button2.onClick.AddListener(delegate
        {
            btn2click();
        });
        button3.onClick.AddListener(delegate
        {
            btn3click();
        });
        button4.onClick.AddListener(delegate
        {
            btn4click();
        });
        button5.onClick.AddListener(delegate
        {
            btn5click();
        });
        button6.onClick.AddListener(delegate
        {
            btn6click();
        });
        button7.onClick.AddListener(delegate
        {
            btn7click();
        });
        button8.onClick.AddListener(delegate
        {
            btn8click();
        });
        button9.onClick.AddListener(delegate
        {
            btn9click();
        });
        button10.onClick.AddListener(delegate
        {
            btn10click();
        });
    }
    public Transform block;
    public Transform rock;
    public Sprite gold;
    public Sprite tree;
	public Sprite grass;
	public Sprite glass;
	public Sprite [] Cube=new Sprite[7];
    private MeshRenderer mesh_renderer;
    public Transform rockelement;
    public Transform goldelement;
	public Transform [] Element=new Transform[10];
    public bool select = false;
	public GameObject k;
    void btn1click()
    {
        slotnumber = 0;
        select = true;
    }
    void btn2click()
    {
        slotnumber = 1;
        select = true;
    }
    void btn3click()
    {
        slotnumber = 2;
        select = true;
    }
    void btn4click()
    {
        slotnumber = 3;
        select = true;
    }
    void btn5click()
    {
        slotnumber = 4;
        select = true;
    }
    void btn6click()
    {
        slotnumber = 5;
        select = true;
    }
    void btn7click()
    {
        slotnumber = 6;
        select = true;
    }
    void btn8click()
    {
        slotnumber = 7;
        select = true;
    }
    void btn9click()
    {
        slotnumber = 8;
        select = true;
    }
    void btn10click()
    {
        slotnumber = 9;
        select = true;
    }
    
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject slot8;
    public GameObject slot9;
    public GameObject slot10;
    public GameObject slot11;
    public string[] collect = new string[10] {"0","0","0","0","0","0","0","0","0","0"};
    public bool[] yesno = new bool[10];//確認背包有無東西
    public int slotnumber=0;//第幾個
    public int totalnumber=0;//總共有幾個
    public GameObject border1;
    public GameObject border2;
    public GameObject border3;
    public GameObject border4;
    public GameObject border5;
    public GameObject border6;
    public GameObject border7;
    public GameObject border8;
    public GameObject border9;
    public GameObject border10;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;
    public Image image9;
    public Image image10;
    public Image image11;
	public GameObject actor;
    // Update is called once per frame
    void Update()
    {
        {
            if (select == true)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    if (yesno[slotnumber] == true)
                    {
						Transform block = Instantiate(Element [slotnumber]);
						block.gameObject.SetActive (true);
                        totalnumber--;
                        if (slotnumber == 0)
                        {
                            image1.sprite = image11.sprite;
                            yesno[0] = false;
                        }
                        if (slotnumber == 1)
                        {
                            image2.sprite = image11.sprite;
                            yesno[1] = false;
                        }
                        if (slotnumber == 2)
                        {
                            image3.sprite = image11.sprite;
                            yesno[2] = false;
                        }
                        if (slotnumber == 3)
                        {
                            image4.sprite = image11.sprite;
                            yesno[3] = false;
                        }
                        if (slotnumber == 4)
                        {
                            image5.sprite = image11.sprite;
                            yesno[4] = false;
                        }
                        if (slotnumber == 5)
                        {
                            image6.sprite = image11.sprite;
                            yesno[5] = false;
                        }
                        if (slotnumber == 6)
                        {
                            image7.sprite = image11.sprite;
                            yesno[6] = false;
                        }
                        if (slotnumber == 7)
                        {
                            image8.sprite = image11.sprite;
                            yesno[7] = false;
                        }
                        if (slotnumber == 8)
                        {
                            image9.sprite = image11.sprite;
                            yesno[8] = false;
                        }
                        if (slotnumber == 9)
                        {
                            image10.sprite = image11.sprite;
                            yesno[9] = false;
                        }

                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                        RaycastHit ray_cast_hit;
                        if (Physics.Raycast(ray, out ray_cast_hit))
                        {

                            float PosX = Mathf.Floor(ray_cast_hit.point.x) + block.transform.localScale.x / 2;
                            float PosY = Mathf.Floor(ray_cast_hit.point.y) + block.transform.localScale.y / 2;
                            float PosZ = Mathf.Floor(ray_cast_hit.point.z) + block.transform.localScale.z / 2;
                            block.transform.position = new Vector3(PosX, PosY, PosZ);
                        }
                    }
                }
            }
        }
        if (totalnumber < 10)
        {
            
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit ray_cast_hit; Transform temp;
                    if (Physics.Raycast(ray, out ray_cast_hit))
                    {
					float x_dis = actor.gameObject.transform.position.x - ray_cast_hit.collider.gameObject.transform.position.x;
					float y_dis = actor.gameObject.transform.position.y - ray_cast_hit.collider.gameObject.transform.position.y;
					float z_dis = actor.gameObject.transform.position.z - ray_cast_hit.collider.gameObject.transform.position.z;
					if (ray_cast_hit.transform.tag != "Player"&&ray_cast_hit.transform.tag != "Ground"&&ray_cast_hit.transform.tag != "Devil"&&ray_cast_hit.transform.tag != "Zombie"&&Mathf.Sqrt (Mathf.Pow (x_dis, 2) + Mathf.Pow (z_dis, 2)) <= 8f&&y_dis<=2f&&ray_cast_hit.transform.tag != "Untagged")
                        {
                            totalnumber = totalnumber + 1;
                        if (yesno[0]==false)
                        {
                            yesno[0] = true;
                            collect[0] = ray_cast_hit.transform.name;
							if (ray_cast_hit.transform.tag == "Tree") {
								image1.sprite = tree;
								Element [0] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Mushroom") {
								image1.sprite = gold;
								Element [0] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Rock") {
								image1.sprite = glass;
								Element [0] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Fence") {
								image1.sprite = grass;
								Element [0] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Stone") {
								image1.sprite = Cube[0];
								Element [0] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Gold") {
								image1.sprite =  Cube[1];
								Element [0] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Glass") {
								image1.sprite =  Cube[2];
								Element [0] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Dirt") {
								image1.sprite =  Cube[3];
								Element [0] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Brick") {
								image1.sprite =  Cube[4];
								Element [0] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Log") {
								image1.sprite = Cube[5];
								Element [0] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Grass") {
								image1.sprite = Cube[6];
								Element [0] = ray_cast_hit.transform;
							}

                        }
                        else if (yesno[1] == false)
                        {
                            yesno[1] = true;
                            collect[1] = ray_cast_hit.transform.name;
							if (ray_cast_hit.transform.tag == "Tree") {
								image2.sprite = tree;
								Element[1] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Mushroom") {
								image2.sprite = gold;
								Element[1] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Rock") {
								image2.sprite = glass;
								Element[1] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Fence") {
								image2.sprite = grass;
								Element[1] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Stone") {
								image2.sprite = Cube[0];
								Element[1] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Gold") {
								image2.sprite =  Cube[1];
								Element[1] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Glass") {
								image2.sprite =  Cube[2];
								Element[1] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Dirt") {
								image2.sprite =  Cube[3];
								Element[1] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Brick") {
								image2.sprite =  Cube[4];
								Element[1] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Log") {
								image2.sprite = Cube[5];
								Element[1] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Grass") {
								image2.sprite = Cube[6];
								Element[1] = ray_cast_hit.transform;
							}
                        }
                        else if (yesno[2] == false)
                        {
                            yesno[2] = true;
                            collect[2] = ray_cast_hit.transform.name;
							if (ray_cast_hit.transform.tag == "Tree") {
								image3.sprite = tree;
								Element[2] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Mushroom") {
								image3.sprite = gold;
								Element[2] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Rock") {
								image3.sprite = glass;
								Element[2] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Fence") {
								image3.sprite = grass;
								Element[2] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Stone") {
								image3.sprite = Cube[0];
								Element[2] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Gold") {
								image3.sprite =  Cube[1];
								Element[2] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Glass") {
								image3.sprite =  Cube[2];
								Element[2] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Dirt") {
								image3.sprite =  Cube[3];
								Element[2] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Brick") {
								image3.sprite =  Cube[4];
								Element[2] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Log") {
								image3.sprite = Cube[5];
								Element[2] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Grass") {
								image3.sprite = Cube[6];
								Element[2] = ray_cast_hit.transform;
							}
                        }
                        else if (yesno[3] == false)
                        {
                            yesno[3] = true;
                            collect[3] = ray_cast_hit.transform.name;
							if (ray_cast_hit.transform.tag == "Tree") {
								image4.sprite = tree;
								Element[3] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Mushroom") {
								image4.sprite = gold;
								Element[3] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Rock") {
								image4.sprite = glass;
								Element[3] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Fence") {
								image4.sprite = grass;
								Element[3] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Stone") {
								image4.sprite = Cube[0];
								Element[3] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Gold") {
								image4.sprite =  Cube[1];
								Element[3] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Glass") {
								image4.sprite =  Cube[2];
								Element[3] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Dirt") {
								image4.sprite =  Cube[3];
								Element[3] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Brick") {
								image4.sprite =  Cube[4];
								Element[3] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Log") {
								image4.sprite = Cube[5];
								Element[3] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Grass") {
								image4.sprite = Cube[6];
								Element[3] = ray_cast_hit.transform;
							}
                        }
                        else if (yesno[4] == false)
                        {
                            yesno[4] = true;
                            collect[4] = ray_cast_hit.transform.name;
							if (ray_cast_hit.transform.tag == "Tree") {
								image5.sprite = tree;
								Element[4] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Mushroom") {
								image5.sprite = gold;
								Element[4] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Rock") {
								image5.sprite = glass;
								Element[4] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Fence") {
								image5.sprite = grass;
								Element[4] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Stone") {
								image5.sprite = Cube[0];
								Element[4] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Gold") {
								image5.sprite =  Cube[1];
								Element[4] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Glass") {
								image5.sprite =  Cube[2];
								Element[4] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Dirt") {
								image5.sprite =  Cube[3];
								Element[4] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Brick") {
								image5.sprite =  Cube[4];
								Element[4] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Log") {
								image5.sprite = Cube[5];
								Element[4] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Grass") {
								image5.sprite = Cube[6];
								Element[4] = ray_cast_hit.transform;
							}
                        }
                        else if (yesno[5] == false)
                        {
                            yesno[5] = true;
                            collect[5] = ray_cast_hit.transform.name;
							if (ray_cast_hit.transform.tag == "Tree") {
								image6.sprite = tree;
								Element[5] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Mushroom") {
								image6.sprite = gold;
								Element[5] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Rock") {
								image6.sprite = glass;
								Element[5] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Fence") {
								image6.sprite = grass;
								Element[5] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Stone") {
								image6.sprite = Cube[0];
								Element[5] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Gold") {
								image6.sprite =  Cube[1];
								Element[5] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Glass") {
								image6.sprite =  Cube[2];
								Element[5] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Dirt") {
								image6.sprite =  Cube[3];
								Element[5] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Brick") {
								image6.sprite =  Cube[4];
								Element[5] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Log") {
								image6.sprite = Cube[5];
								Element[5] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Grass") {
								image6.sprite = Cube[6];
								Element[5] = ray_cast_hit.transform;
							}
                        }
                        else if (yesno[6] == false)
                        {
                            yesno[6] = true;
                            collect[6] = ray_cast_hit.transform.name;
							if (ray_cast_hit.transform.tag == "Tree") {
								image7.sprite = tree;
								Element[6] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Mushroom") {
								image7.sprite = gold;
								Element[6] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Rock") {
								image7.sprite = glass;
								Element[6] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Fence") {
								image7.sprite = grass;
								Element[6] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Stone") {
								image7.sprite = Cube[0];
								Element[6] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Gold") {
								image7.sprite =  Cube[1];
								Element[6] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Glass") {
								image7.sprite =  Cube[2];
								Element[6] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Dirt") {
								image7.sprite =  Cube[3];
								Element[6] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Brick") {
								image7.sprite =  Cube[4];
								Element[6] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Log") {
								image7.sprite = Cube[5];
								Element[6] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Grass") {
								image7.sprite = Cube[6];
								Element[6] = ray_cast_hit.transform;
							}
                        }
                        else if (yesno[7] == false)
                        {
                            yesno[7] = true;
                            collect[7] = ray_cast_hit.transform.name;
							if (ray_cast_hit.transform.tag == "Tree") {
								image8.sprite = tree;
								Element[7] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Mushroom") {
								image8.sprite = gold;
								Element[7] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Rock") {
								image8.sprite = glass;
								Element[7] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Fence") {
								image8.sprite = grass;
								Element[7] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Stone") {
								image8.sprite = Cube[0];
								Element[7] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Gold") {
								image8.sprite =  Cube[1];
								Element[7] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Glass") {
								image8.sprite =  Cube[2];
								Element[7] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Dirt") {
								image8.sprite =  Cube[3];
								Element[7] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Brick") {
								image8.sprite =  Cube[4];
								Element[7] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Log") {
								image8.sprite = Cube[5];
								Element[7] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Grass") {
								image8.sprite = Cube[6];
								Element[7] = ray_cast_hit.transform;
							}
                        }
                        else  if (yesno[8] == false)
                        {
                            yesno[8] = true;
                            collect[8] = ray_cast_hit.transform.name;
							if (ray_cast_hit.transform.tag == "Tree") {
								image9.sprite = tree;
								Element[8] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Mushroom") {
								image9.sprite = gold;
								Element[8] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Rock") {
								image9.sprite = glass;
								Element[8] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Fence") {
								image9.sprite = grass;
								Element[8] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Stone") {
								image9.sprite = Cube[0];
								Element[8] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Gold") {
								image9.sprite =  Cube[1];
								Element[8] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Glass") {
								image9.sprite =  Cube[2];
								Element[8] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Dirt") {
								image9.sprite =  Cube[3];
								Element[8] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Brick") {
								image9.sprite =  Cube[4];
								Element[8] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Log") {
								image9.sprite = Cube[5];
								Element[8] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Grass") {
								image9.sprite = Cube[6];
								Element[8] = ray_cast_hit.transform;
							}
                        }
                        else if (yesno[9] == false)
                        {
                            yesno[9] = true;
                            collect[9] = ray_cast_hit.transform.name;
							if (ray_cast_hit.transform.tag == "Tree") {
								image10.sprite = tree;
								Element[9] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Mushroom") {
								image10.sprite = gold;
								Element[9] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Rock") {
								image10.sprite = glass;
								Element[9] = ray_cast_hit.transform;
							} else if (ray_cast_hit.transform.tag == "Fence") {
								image10.sprite = grass;
								Element[9] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Stone") {
								image10.sprite = Cube[0];
								Element[9] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Gold") {
								image10.sprite =  Cube[1];
								Element[9] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Glass") {
								image10.sprite =  Cube[2];
								Element[9] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Dirt") {
								image10.sprite =  Cube[3];
								Element[9] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Brick") {
								image10.sprite =  Cube[4];
								Element[9] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Log") {
								image10.sprite = Cube[5];
								Element[9] = ray_cast_hit.transform;
							}
							else if (ray_cast_hit.transform.tag == "Grass") {
								image10.sprite = Cube[6];
								Element[9] = ray_cast_hit.transform;
							}
                        }
                     
                        }
                    }
                }
                //Resources.Load("gold_ore", typeof(Sprite)) as Sprite;
                // Use this for initialization
        }
    }
	public void  inPack(Image a,Transform b,Transform c){
		if (b.tag == "Tree") {
			a.sprite = tree;
			c = b;
		} else if (b.tag == "Mushroom") {
			a.sprite = gold;
			c = b;
		} else if (b.tag == "Rock") {
			a.sprite = glass;
			c = b;
		} else if (b.tag == "Fence") {
			a.sprite = grass;
			c = b;
			Debug.Log ("Fuck");
		}
		else if (b.tag == "Stone") {
			a.sprite = Cube[0];
			c = b;
		}
		else if (b.tag == "Gold") {
			a.sprite =  Cube[1];
			c = b;
		}
		else if (b.tag == "Glass") {
			a.sprite =  Cube[2];
			c = b;
		}
		else if (b.tag == "Dirt") {
			a.sprite =  Cube[3];
			c = b;
		}
		else if (b.tag == "Brick") {
			a.sprite =  Cube[4];
			c = b;
		}
		else if (b.tag == "Log") {
			a.sprite = Cube[5];
			c = b;
		}
		else if (b.tag == "Grass") {
			a.sprite = Cube[6];
			c = b;
		}
	}
}
