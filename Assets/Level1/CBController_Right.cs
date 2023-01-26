using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBController_Right : MonoBehaviour
{
    GameObject player;
    GameObject director;
    private Rigidbody2D CB;
    private float moveSpeed;

    void Start()
    {
        this.player = GameObject.Find("dust");
        this.director = GameObject.Find("GameDirector");
        this.CB = GetComponent<Rigidbody2D>();
        moveSpeed = 10f;
    }

    void Update()
    {
        CB.velocity = Vector2.left * moveSpeed;
        //transform.Translate(this.moveSpeed, 0, 0);

        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }

        if (director.GetComponent<GameDirector>().CheckGameover() == false)
        {
            Vector2 p1 = transform.position;
            Vector2 p2 = this.player.transform.position;

            Vector2 dir = p1 - p2;

            float d = dir.magnitude;

            float r1 = 0.4f;
            float r2 = 0.15f;

            if (d < r1 + r2)
            {
                this.director.GetComponent<GameDirector>().DecreaseHp();
                Destroy(gameObject);

                if (director.GetComponent<GameDirector>().GetGauge() <= 0)
                {
                    director.GetComponent<GameDirector>().GameEnd();
                }
            }
        }
        else
        {
            Destroy(gameObject);
        }
            
    }
}
