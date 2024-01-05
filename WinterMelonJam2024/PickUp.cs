using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool item = false;
    public PlayerPosition playerPosition;

    private LightStatus lightStatus;

    public void PickUpItem()
    {
        Inventory inventoryScript = FindObjectOfType<Inventory>();

        if (!inventoryScript.InventoryFull && !item)
        {
            transform.position = new Vector3(0, 30, 0);
            FindObjectOfType<UnityEngine.Rendering.Universal.Light2D>().intensity = 0f;
            FindObjectOfType<Inventory>().HasItem();
            FindObjectOfType<LightStatus>().noLight();
            item = true;
        }
    }

    public void PlaceItem()
    {
        Inventory inventoryScript = FindObjectOfType<Inventory>();

        if (inventoryScript.InventoryFull && item)
        {
            Vector3 playerPos = playerPosition.GetLocationPosition();
            transform.position = playerPos;
            FindObjectOfType<UnityEngine.Rendering.Universal.Light2D>().intensity = 0.6f;
            FindObjectOfType<Inventory>().NoItem();
            FindObjectOfType<LightStatus>().Light();
            item = false;
        }
    }
}
