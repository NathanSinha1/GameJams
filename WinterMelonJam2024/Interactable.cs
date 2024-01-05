using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public string targetTag; // The tag to check for interaction
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public UnityEvent noInteractAction;

    // Update is called once per frame
    void Update()
    {
        if (isInRange && targetTag == "Player")
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke(); // starts event
            }
        }
        else if (isInRange)
        {
            interactAction.Invoke(); // starts event
        }
        else if (!isInRange) {
            noInteractAction.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            isInRange = false;
        }
    }
}
