using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextL2 : MonoBehaviour
{

    Text L2;

    // Use this for initialization
    void Start()
    {
        L2 = GetComponent<Text>();
    }

    public void textUpdate(float l2)
    {
        L2.text = "Length 2 = " + Math.Round(GameObject.Find("Particle2").GetComponent<StartPosition2>().l2, 2) + " m";
    }
}
