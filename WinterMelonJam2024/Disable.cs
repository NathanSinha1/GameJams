using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    public bool orb1, orb2, orb3;

    public void Update() {
        if (orb1 && orb2 && orb3) {
            gameObject.SetActive(false);
        }
    }

    public void orb1Placed() {
        orb1 = true;
    }
    public void orb2Placed() {
        orb2 = true;;
    }
    public void orb3Placed() {
        orb3 = true;
    }
    public void orb1Removed() {
        orb1 = false;
    }
    public void orb2Removed() {
        orb2 = false;
    }
    public void orb3Removed() {
        orb3 = false;
    }
}