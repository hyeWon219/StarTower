using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBGenerator1 : MonoBehaviour
{
    public GameObject BallPrefab1;
    public GameObject BallPrefab2;
    public GameObject BallPrefab3;
    float span = 2.0f;
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
            go1.transform.position = new Vector3(-8.6f, 15f, 0);
            //go1.GetComponent<CBController_Left>().moveSpeed = 0.05f;

            GameObject go2 = Instantiate(BallPrefab2) as GameObject;
            go2.transform.position = new Vector3(8.64f, 5f, 0);
            //go2.GetComponent<CBController_Right>().moveSpeed = -0.05f;

            GameObject go3 = Instantiate(BallPrefab3) as GameObject;
            go3.transform.position = new Vector3(8.64f, 25f, 0);
            //go3.GetComponent<CBController_Right>().moveSpeed = -0.05f;
        }
    }
}
