using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestH : MonoBehaviour
{
    private Rigidbody rb;
    //public int speed = 2; // скорость передвижения
    public int hpForHero = 1;


    void OnCollisionEnter(Collision enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            hpForHero -= 1; 

            if (hpForHero == 0)
            {
                SceneManager.LoadScene(3);
            }
        }
 
            
    }

    void Start()
    {

    }

    void Update()
    { 

    }
}