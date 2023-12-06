using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void NextScene_2()
    {
        SceneManager.LoadScene(2);
    }

    public void NextScene_0()
    {
        SceneManager.LoadScene(0);
    }
}