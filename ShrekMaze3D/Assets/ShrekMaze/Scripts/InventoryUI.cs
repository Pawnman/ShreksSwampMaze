using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI tableText;
    

    // Start is called before the first frame update
    void Start()
    {
        tableText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTableText(PlayerInventory playerInventory)
    {
        tableText.text = playerInventory.NumberOfTables.ToString();
    }
}
