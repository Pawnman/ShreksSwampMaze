using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyUI : MonoBehaviour
{
    private TextMeshProUGUI enemyText;


    // Start is called before the first frame update
    void Start()
    {
        enemyText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateEnemyText(EnemiesKilled enemiesKilled)
    {
        enemyText.text = enemiesKilled.NumberOfEnemies.ToString();
    }
}