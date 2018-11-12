using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextM1 : MonoBehaviour
{

    Text M1;

    // Use this for initialization
    void Start()
    {
        M1 = GetComponent<Text>();
    }

    public void textUpdate(float l1)
    {
        M1.text = "Mass 1 = " + Math.Round(GameObject.Find("Particle1").GetComponent<StartPosition1>().m1, 2) + " kg";
    }
}
