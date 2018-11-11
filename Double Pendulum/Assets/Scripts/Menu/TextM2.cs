using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextM2 : MonoBehaviour {

    Text M2;

    // Use this for initialization
    void Start()
    {
        M2 = GetComponent<Text>();
    }

    public void textUpdate(float l1)
    {
        M2.text = "Mass 2 = " + Math.Round(GameObject.Find("Particle2").GetComponent<StartPosition2>().m2, 2) + " kg";
    }
}
