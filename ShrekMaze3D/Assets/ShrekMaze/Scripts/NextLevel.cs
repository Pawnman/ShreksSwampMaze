using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PlayerInventory.TP == 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlayerInventory.TP);
        if (PlayerInventory.TP == 6)
        {
            gameObject.SetActive(false);
        }
    }
}
