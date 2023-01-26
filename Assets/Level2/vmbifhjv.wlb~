using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBController_Right2 : MonoBehaviour
{
    GameObject player;
    GameObject director;
    private Rigidbody2D CB;
    private float moveSpeed;

    void Start()
    {
        this.player = GameObject.Find("dust");
        this.director = GameObject.Find("GameDirector2");
        this.CB = GetComponent<Rigidbody2D>();
        moveSpeed = 15f;
    }

    void Update()
    {
        CB.velocity = Vector2.left * moveSpeed;
        //transform.Translate(this.moveSpeed, 0, 0);

        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }

        if (director.GetComponent<GameDirector2>().CheckGameover() == false)
        {
            Vector2 p1 = transform.position;
            Vector2 p2 = this.player.transform.position;

            Vector2 dir = p1 - p2;

            float d = dir.magnitude;

            float r1 = 0.4f;
            float r2 = 0.15f;

            if (d < r1 + r2)
            {
                this.director.GetComponent<GameDirector2>().DecreaseHp();
                Destroy(gameObject);

                if (director.GetComponent<GameDirector2>().GetGauge() <= 0)
                {
                    director.GetComponent<GameDirector2>().GameEnd();
                }
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
