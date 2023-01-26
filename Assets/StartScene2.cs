using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene2 : MonoBehaviour
{
    public void NextScene2()
    {
        SceneManager.LoadScene("Level1Scene");
    }
}
