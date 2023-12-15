using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemiesKilled : MonoBehaviour
{
    public static int EP;
    public int NumberOfEnemies { get; private set; }

    public UnityEvent<EnemiesKilled> OnEnemyKilled;


    public void EnemyKilled()
    {
        NumberOfEnemies++;
        OnEnemyKilled.Invoke(this);
        EnemiesKilled.EP += 1;

    }


}