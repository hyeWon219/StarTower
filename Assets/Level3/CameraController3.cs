using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController3 : MonoBehaviour
{
    GameObject player;
    GameObject director;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("dust");
        this.director = GameObject.Find("GameDirector3");
    }

    // Update is called once per frame
    void Update()
    {
        if (director.GetComponent<GameDirector3>().CheckGameover() == false)
        {
            if (player.transform.position.y > 0 && player.transform.position.y < 38)
            {
                Vector3 playerPos = this.player.transform.position;
                transform.position = new Vector3(
                transform.position.x, playerPos.y, transform.position.z);
            }
        }
    }
}
