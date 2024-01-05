using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    // Update is called once per frame
    public Vector3 GetLocationPosition() 
    {
        Vector3 currentPosition = transform.position;
        return currentPosition;
    }
}
