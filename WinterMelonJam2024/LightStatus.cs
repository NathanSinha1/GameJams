using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightStatus : MonoBehaviour
{
    PolygonCollider2D myCollider;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize myCollider in the Start method
        myCollider = GetComponent<PolygonCollider2D>();
    }

    public void noLight()
    {
        myCollider.enabled = false;
    }

    public void Light()
    {
        myCollider.enabled = true;
    }
}
