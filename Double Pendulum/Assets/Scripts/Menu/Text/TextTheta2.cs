using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextTheta2 : MonoBehaviour {

    Text Theta2;

    // Use this for initialization
    void Start()
    {
        Theta2 = GetComponent<Text>();
    }

    public void textUpdate(float theta1)
    {
        Theta2.text = "Angle 2 = " + Math.Round(GameObject.Find("Particle2").GetComponent<StartPosition2>().theta2 * 180 / Mathf.PI, 2) + " degrees";
    }
}
