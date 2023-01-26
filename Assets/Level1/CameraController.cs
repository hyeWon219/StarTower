using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    GameObject director;

    void Start()
    {
        this.player = GameObject.Find("dust");
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        if (director.GetComponent<GameDirector>().CheckGameover() == false)
        {
            if(player.transform.position.y > 0 && player.transform.position.y < 38)
            {
                Vector3 playerPos = this.player.transform.position;
                transform.position = new Vector3(
                transform.position.x, playerPos.y, transform.position.z);
            }
        }
    }
}
