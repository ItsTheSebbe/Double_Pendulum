using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextTheta1 : MonoBehaviour {

    Text Theta1;

    // Use this for initialization
    void Start()
    {
        Theta1 = GetComponent<Text>();
    }

    public void textUpdate(float theta1)
    {
        Theta1.text = "Angle 1 = " + Math.Round(GameObject.Find("Particle1").GetComponent<StartPosition1>().theta1*180/Mathf.PI, 2) + " degrees";
    }
}
