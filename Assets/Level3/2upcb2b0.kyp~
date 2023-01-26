using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBGenerator3_1 : MonoBehaviour
{
    public GameObject BallPrefab1;
    public GameObject BallPrefab2;
    public GameObject BallPrefab3;
    public GameObject BallPrefab4;
    public GameObject BallPrefab5;
    float span = 1.5f;
    float delta = 0.0f;

    void Start()
    {

    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go1 = Instantiate(BallPrefab1) as GameObject;
            go1.transform.position = new Vector3(-8.6f, 10.0f, 0);
            //go1.GetComponent<CBController_Left3>().moveSpeed = 0.07f;

            GameObject go2 = Instantiate(BallPrefab2) as GameObject;
            go2.transform.position = new Vector3(8.64f,18.0f, 0);
            //go2.GetComponent<CBController_Right3>().moveSpeed = -0.07f;

            GameObject go3 = Instantiate(BallPrefab3) as GameObject;
            go3.transform.position = new Vector3(-8.6f, 27.0f, 0);
            //go3.GetComponent<CBController_Left3>().moveSpeed = 0.07f;

            GameObject go4 = Instantiate(BallPrefab4) as GameObject;
            go4.transform.position = new Vector3(8.64f, 33.0f, 0);
            //go4.GetComponent<CBController_Right3>().moveSpeed = -0.07f;

            GameObject go5 = Instantiate(BallPrefab2) as GameObject;
            go5.transform.position = new Vector3(8.64f, 3.0f, 0);
            //go5.GetComponent<CBController_Right3>().moveSpeed = -0.07f;
        }
    }
}
