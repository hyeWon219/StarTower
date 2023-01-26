using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector3 : MonoBehaviour
{
    GameObject hpGauge;
    public bool isGameOver;
    public GameObject gameover;
    public GameObject isGameClear;
    public AudioClip damage;
    public AudioClip gameoverSound;
    AudioSource aud;
    GameObject animator;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();
        this.hpGauge = GameObject.Find("hpGauge");
        this.isGameOver = false;
        this.gameover = GameObject.Find("GameoverText");
        this.isGameClear = GameObject.Find("NextButton");
        this.gameover.SetActive(false);
        this.isGameClear.SetActive(false);
        animator = GameObject.Find("dust");
    }

    public void DecreaseHp()
    {
        this.aud.PlayOneShot(this.damage);
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.25f;
    }

    public void GameEnd()
    {
        animator.GetComponent<PlayerController3>().PlayerDie();
        this.aud.PlayOneShot(this.gameoverSound);
        this.isGameOver = true;
        this.gameover.SetActive(true);
    }

    public float GetGauge()
    {
        return this.hpGauge.GetComponent<Image>().fillAmount;
    }

    public bool CheckGameover()
    {
        return this.isGameOver;
    }

    public void NextScene()
    {
        this.isGameClear.SetActive(true);
    }

    void Update()
    {
        if (this.isGameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Level3Scene");
            }
        }
    }
}
