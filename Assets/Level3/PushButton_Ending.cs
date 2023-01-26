using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PushButton_Ending : MonoBehaviour
{
    public void NextScene_Ending()
    {
        SceneManager.LoadScene("Ending");
    }
}
