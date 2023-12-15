using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    Text text;
    public static int enemies;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        enemies = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = enemies.ToString();
    }
}
