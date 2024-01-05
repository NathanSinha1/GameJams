using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool InventoryFull = false;

    public void HasItem() {
        InventoryFull = true;
    }
    public void NoItem() {
        InventoryFull = false;
    }
}
