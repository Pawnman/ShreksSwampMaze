using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLvl1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToLevel1()
    {
        SceneManager.LoadScene(2);
    }
}
