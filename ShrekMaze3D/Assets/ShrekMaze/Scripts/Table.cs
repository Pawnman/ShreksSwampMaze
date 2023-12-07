using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour

{
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.TableCollected();
            AudioManager.instance.Play("PickUp");
            gameObject.SetActive(false);
        }
    }
}
