using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbHolderUse : MonoBehaviour
{
    public Sprite orbHolderFull;
    public Sprite orbHolderEmpty;

    void Start() {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = orbHolderEmpty;
    }

    public void orbActive() {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = orbHolderFull;
        if(FindObjectOfType<Disable>() != null) {
            if(gameObject.name == "orbHolder 1") {
                FindObjectOfType<Disable>().orb1Placed();
            }
            if(gameObject.name == "orbHolder 2") {
                FindObjectOfType<Disable>().orb2Placed();
            }
            if(gameObject.name == "orbHolder 3") {
                FindObjectOfType<Disable>().orb3Placed();
            }
        }
    }

    public void orbInactive() {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = orbHolderEmpty;
        if(FindObjectOfType<Disable>() != null) {
            if(gameObject.name == "orbHolder 1") {
                FindObjectOfType<Disable>().orb1Removed();
            }
            if(gameObject.name == "orbHolder 2") {
                FindObjectOfType<Disable>().orb2Removed();
            }
            if(gameObject.name == "orbHolder 3") {
                FindObjectOfType<Disable>().orb3Removed();
            }
        }
    }
}
