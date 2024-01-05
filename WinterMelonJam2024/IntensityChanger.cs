using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntensityChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
