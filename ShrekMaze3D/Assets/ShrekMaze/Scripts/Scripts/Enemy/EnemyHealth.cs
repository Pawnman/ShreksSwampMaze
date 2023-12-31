using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            EnemyCount.enemies += 1;
            Destroy(gameObject);
        }
    }

    public void damageEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
