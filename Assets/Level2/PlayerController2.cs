using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour
{
    public AudioClip ClickSound;
    AudioSource aud;
    Rigidbody2D rigid2D;
    Animator ani;
    GameObject director;
    float jumpForce = 780.0f;
    float walkForce;
    float maxWalkSpeed = 4.0f;
    bool Next = false;

    void Start()
    {
        walkForce = 30.0f;
        this.aud = GetComponent<AudioSource>();
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.ani = GetComponent<Animator>();
        this.director = GameObject.Find("GameDirector2");

    }

    void Update()
    {
        if (this.Next == false)
        {
            int key = 0;
            if (Input.GetKey(KeyCode.RightArrow)) key = 1;
            if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

            float speedx = Mathf.Abs(this.rigid2D.velocity.x);

            if (speedx < this.maxWalkSpeed)
            {
                this.rigid2D.AddForce(transform.right * key * this.walkForce);
            }

            if (Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
            {
                this.ani.SetTrigger("JumpTrigger");
                this.rigid2D.AddForce(transform.up * this.jumpForce);
            }

            if (key != 0)
            {
                transform.localScale = new Vector3(key, 1, 1);
            }
        }
    }
    public void PlayerDie()
    {
        walkForce = 0f;
        ani.SetTrigger("Die");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        this.Next = true;
        this.aud.PlayOneShot(this.ClickSound);
        this.director.GetComponent<GameDirector2>().NextScene();
    }
}
